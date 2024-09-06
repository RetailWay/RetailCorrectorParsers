using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;

namespace OfdRuErrorParser
{
    public partial class Form1 : Form
    {
        internal List<Receipt> Receipts = new List<Receipt>();
        private string Token => inpToken.Text;
        private string RegId => inpRegId.Text;
        private string Vatin => inpVatin.Text;
        private DateTime BeginDate => inpPeriodBegin.Value.Date + new TimeSpan(23, 59, 59);
        private DateTime EndDate => inpPeriodEnd.Value.Date + new TimeSpan(23, 59, 59);
        private HttpClient http;
        private int MaxCountTry = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void SetActive(bool isActive)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                btnScan.Enabled = isActive;
                inpDefMeasure.Enabled = isActive;
                inpDefName.Enabled = isActive;
                inpDefType.Enabled = isActive;
                inpVatin.Enabled = isActive;
                inpPeriodBegin.Enabled = isActive;
                inpPeriodEnd.Enabled = isActive;
                inpRegId.Enabled = isActive;
                inpToken.Enabled = isActive;
            }));
        }

        private int Measure
        {
            get
            {
                string text = "";
                Invoke(new MethodInvoker(delegate () { text = inpDefMeasure.Text; }));
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
                Invoke(new MethodInvoker(delegate () { text = inpDefType.Text; }));
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
        private void ToFile()
        {
            Logger.Info("Выгрузка результатов сканирования в файлы.");
            string date = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
            if (!Directory.Exists("Jobs")) Directory.CreateDirectory("Jobs");
            int i = 1;
            while (ReceiptPop() is string req && req != "[]")
            {
                if (File.Exists(Path.Combine("Jobs", $"{date}-{i}.json"))) i++;
                File.WriteAllText(Path.Combine("Jobs", $"{date}-{i}.json"), req);
            }
        }

        private async void Scan()
        {
            Invoke(new MethodInvoker(delegate () { progressStatus.Value = 0; }));
            SetActive(false);

            Invoke(new MethodInvoker(delegate () { progressStatus.Maximum = (int)(EndDate - BeginDate).TotalDays + 2; }));
            for (DateTime d = BeginDate; d <= EndDate; d = d.AddDays(1))
            {
                SendSearch(d);
                Thread.Sleep(1500);
                Invoke(new MethodInvoker(delegate () { progressStatus.Value++; }));
            }
            Logger.Info($"Сканирование завершено: Найдено {Receipts.Count} некорректных чеков.");
            Invoke(new MethodInvoker(delegate () { textStatus.Text = $"Исправлено {Receipts.Count} чеков"; }));
            ToFile();
            Invoke(new MethodInvoker(delegate () { progressStatus.Value++; }));
            SetActive(true);
            Process.Start(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Jobs"));
        }

        private async void SendSearch(DateTime d, int totalCount = 1)
        {
            try
            {
                Logger.Info($"Сканирование чеков за {d:yyyy-MM-dd}");
                Invoke(new MethodInvoker(delegate () { textStatus.Text = $"Сканирование чеков за {d:yyyy-MM-dd}"; }));
                var df = $"{d:yyyy-MM-dd}T00:00:00";
                var dt = $"{d:yyyy-MM-dd}T{d:HH:mm:ss}";
                var uri = $"https://ofd.ru/api/integration/v2/inn/{Vatin}/kkt/{RegId}/receipts-info?dateFrom={df}&dateTo={dt}&AuthToken={Token}";
                var resp = await http.GetAsync(uri);
                var raw = await resp.Content.ReadAsStringAsync();
                var settings = new JsonSerializerSettings
                {
                    DateFormatString = "yyyy-MM-ddTHH:mm:ss"
                };
                var json = (JObject)JsonConvert.DeserializeObject(raw, settings);
                var errors = json["Data"].Where(i => (string)i["FnsStatus"] == "Error").ToArray();
                if (errors.Length == 0) return;
                foreach (var data in errors)
                {
                    var rec = new Receipt
                    {
                        items = new Position[(int)data["Depth"]],
                        payment = new Payment
                        {
                            cash = (double)data["CashSumm"] / 100,
                            ecash = (double)data["ECashSumm"] / 100,
                            prepaid = (double)data["PrepaidSumm"] / 100,
                            credit = (double)data["CreditSumm"] / 100
                        },
                        correction = new CorrectionData
                        {
                            orderId = " ",
                            sign = (string)data["DecimalFiscalSign"],
                            date = DateTime.Parse((string)data["DocDateTime"])
                        },
                        total = (double)data["TotalSumm"] / 100,
                        operation = new Operation((string)data["OperationType"])
                    };
                    for (var i = 0; i < rec.items.Length; i++)
                    {
                        var pos = data["Items"][i];
                        var item = new Position
                        {
                            name = pos["Name"] != null ? (string)pos["Name"] : inpDefName.Text,
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
                }
            }
            catch (Exception e)
            {
                if(totalCount < MaxCountTry)
                {
                    Logger.Error($"Неудачная попытка: {e.Message}.");
                    SendSearch(d, ++totalCount);
                }
            }
        }

        private void LogSettings()
        {
            Logger.Info("");
            Logger.Info("Параметры:");
            Logger.Info($" - Диапазон: {BeginDate:yyyy-MM-dd} - {EndDate:yyyy-MM-dd}");
            Logger.Info($" - ИНН: {Vatin}");
            Logger.Info($" - Регистрационный номер: {RegId}");
            Logger.Info($" - Макс. количество попыток: {MaxCountTry}");
            Logger.Info(" - Информация о позициях по-умолчанию:");
            Logger.Info($"   - Наименование: {inpDefName.Text}");
            Logger.Info($"   - Тип: {inpDefType.Text}");
            Logger.Info($"   - Единица измерения: {inpDefMeasure.Text}");
            Logger.Info("");
        }

        private void AutoToken(object sender, EventArgs e)
        {
            if(LibTokens.GetToken(inpVatin.Text, 0) is string token)
            {
                inpToken.Text = token;
                inpToken.Enabled = false;
            }
            else
            {
                inpToken.Text = "";
                inpToken.Enabled = true;
            }
        }

        private void btnScan_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                case MouseButtons.Left:
                    http = new HttpClient();
                    LogSettings();
                    Logger.Info("Начало сканирования.");
                    if (inpDefName.Text == "")
                    {
                        Logger.Info("Сканирование завершено с ошибкой: Значение названия позиции по-умолчанию обязательно!");
                        return;
                    }
                    new Thread(Scan) { IsBackground = true }.Start();
                    break;
                case MouseButtons.Middle:
                    new Manual().Show();
                    Program.main.Hide();
                    break;
            }
        }
    }
}
