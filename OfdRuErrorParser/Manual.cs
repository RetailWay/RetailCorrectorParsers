using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace OfdRuErrorParser
{
    public partial class Manual : Form
    {
        public Manual()
        {
            InitializeComponent();
        }

        private void Closed(object sender, FormClosedEventArgs e) => Program.main.Show();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var settings = new JsonSerializerSettings
                {
                    DateFormatString = "yyyy-MM-ddTHH:mm:ss"
                };
                var json = (JObject)JsonConvert.DeserializeObject(Source.Text, settings);
                var doc = json["Document"];
                var items = (JArray)doc["Items"];
                var rec = new Receipt
                {
                    items = new Position[items.Count],
                    payment = new Payment
                    {
                        cash = (double)doc["Amount_Cash"] / 100,
                        ecash = (double)doc["Amount_ECash"] / 100,
                        prepaid = (double)doc["Amount_Advance"] / 100,
                        credit = (double)doc["Amount_Loan"] / 100
                    },
                    correction = new CorrectionData
                    {
                        orderId = " ",
                        sign = (string)doc["DecimalFiscalSign"]
                    },
                    total = (double)doc["Amount_Total"] / 100,
                    operation = new Operation((int)doc["OperationType"])
                };
                rec.correction.date = Parse((string)doc["DateTime"]);
                for (var i = 0; i < items.Count; i++)
                {
                    var pos = items[i];
                    var item = new Position
                    {
                        name = pos["Name"] != null ? (string)pos["Name"] : Program.main.inpDefName.Text,
                        price = (double)pos["Price"] / 100,
                        quantity = (double)pos["Quantity"],
                        total = (double)pos["Total"] / 100,
                        payment = (int)pos["CalculationMethod"],
                        tax = (int)pos["NDS_Rate"],
                        measure = pos["ProductUnitOfMeasure"] != null ? (int)pos["ProductUnitOfMeasure"] : Measure,
                        type = pos["SubjectType"] != null ? (int)pos["SubjectType"] : SubjectType
                    };
                    rec.items[i] = item;
                }
                Receipts.Add(rec);
                Source.Text = "";
            }
            catch (Exception ex)
            {
                Logger.Error($"Неудачная попытка: {ex.Message}.");
            }
        }

        public DateTime Parse(string src)
        {
            var elem = src.Split(' ');
            var date = elem[0].Split('/');
            var time = elem[1].Split(':');
            return new DateTime(
                int.Parse(date[2]), int.Parse(date[0]), int.Parse(date[1]), 
                int.Parse(time[0]), int.Parse(time[1]), int.Parse(time[2]));
        }

        internal List<Receipt> Receipts = new List<Receipt>();
        private string RegId => inpRegId.Text;

        private int Measure
        {
            get
            {
                string text = "";
                Invoke(new MethodInvoker(delegate () { text = Program.main.inpDefMeasure.Text; }));
                switch (text)
                {
                    case "шт":
                        return 0;
                    case "гр":
                        return 10;
                    case "кг":
                        return 11;
                    case "т":
                        return 12;
                    case "см":
                        return 20;
                    case "дм":
                        return 21;
                    case "м":
                        return 22;
                    case "см²":
                        return 30;
                    case "дм²":
                        return 31;
                    case "м²":
                        return 32;
                    case "мл":
                        return 40;
                    case "л":
                        return 41;
                    case "м³":
                        return 42;
                    case "кВт/ч":
                        return 50;
                    case "ГКалл":
                        return 51;
                    case "д":
                        return 70;
                    case "ч":
                        return 71;
                    case "мин":
                        return 72;
                    case "сек":
                        return 73;
                    case "КБ":
                        return 80;
                    case "МБ":
                        return 81;
                    case "ГБ":
                        return 82;
                    case "ТБ":
                        return 83;
                    case "др.":
                        return 255;
                    default:
                        throw new Exception();
                }
            }
        }
        private int SubjectType
        {
            get
            {
                string text = "";
                Invoke(new MethodInvoker(delegate () { text = Program.main.inpDefType.Text; }));
                switch (text)
                {
                    case "Т":
                        return 1;
                    case "АТ":
                        return 2;
                    case "Р":
                        return 3;
                    case "У":
                        return 4;
                    case "СА":
                        return 5;
                    case "ВА":
                        return 6;
                    case "СЛ":
                        return 7;
                    case "ВЛ":
                        return 8;
                    case "РИД":
                        return 9;
                    case "П":
                        return 10;
                    case "АВ":
                        return 11;
                    case "СПР":
                        return 12;
                    case "ИПР":
                        return 13;
                    case "ИП":
                        return 14;
                    case "ВД":
                        return 15;
                    case "СВ":
                        return 16;
                    case "ТС":
                        return 17;
                    case "КС":
                        return 18;
                    case "З":
                        return 19;
                    case "РХ":
                        return 20;
                    case "ВОПСИП":
                        return 21;
                    case "ВОПС":
                        return 22;
                    case "ВОМСИП":
                        return 23;
                    case "ВОМС":
                        return 24;
                    case "ВОСС":
                        return 25;
                    case "ПК":
                        return 26;
                    case "ВДС":
                        return 27;
                    case "АТНМ":
                        return 30;
                    case "АТМ":
                        return 31;
                    case "ТНМ":
                        return 32;
                    case "ТМ":
                        return 33;
                    default:
                        throw new Exception();
                }
            }
        }

        public List<T> SubList<T>(List<T> src, int beginIndex, int endIndex)
        {
            var size = endIndex - beginIndex;
            var res = new List<T>(size);
            for (int i = 0; i < size; i++)
            {
                res.Add(src[beginIndex + i]);
            }
            return res;
        }
        private string ReceiptPop()
        {
            var p = SubList(Receipts, 0, Math.Min(10, Receipts.Count));
            Receipts.RemoveRange(0, p.Count);
            return JsonConvert.SerializeObject(p);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(RegId)) Directory.CreateDirectory(RegId);
            if (!Directory.Exists(Path.Combine(RegId, "Jobs"))) 
                Directory.CreateDirectory(Path.Combine(RegId, "Jobs"));

            string date = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
            int i = 1;
            while (ReceiptPop() is string req && req != "[]")
            {
                if (File.Exists(Path.Combine(RegId, "Jobs", $"{date}-{i}.json"))) i++;
                File.WriteAllText(Path.Combine(RegId, "Jobs", $"{date}-{i}.json"), req);
            }
        }
    }
}
