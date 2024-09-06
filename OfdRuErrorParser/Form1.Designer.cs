namespace OfdRuErrorParser
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inpDefType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inpToken = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.inpVatin = new System.Windows.Forms.TextBox();
            this.inpRegId = new System.Windows.Forms.TextBox();
            this.inpPeriodEnd = new System.Windows.Forms.DateTimePicker();
            this.inpPeriodBegin = new System.Windows.Forms.DateTimePicker();
            this.inpDefMeasure = new System.Windows.Forms.ComboBox();
            this.inpDefName = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.textStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressStatus = new System.Windows.Forms.ProgressBar();
            this.btnScan = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.Controls.Add(this.inpDefType, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inpToken, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.inpVatin, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.inpRegId, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.inpPeriodEnd, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.inpPeriodBegin, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.inpDefMeasure, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.inpDefName, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 210);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // inpDefType
            // 
            this.inpDefType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpDefType.FormattingEnabled = true;
            this.inpDefType.Items.AddRange(new object[] {
            "Т",
            "АТ",
            "Р",
            "У",
            "СА",
            "ВА",
            "СЛ",
            "ВЛ",
            "РИД",
            "П",
            "АВ",
            "СПР",
            "ИПР",
            "ИП",
            "ВД",
            "СВ",
            "ТС",
            "КС",
            "З",
            "РХ",
            "ВОПСИП",
            "ВОПС",
            "ВОМСИП",
            "ВОМС",
            "ВОСС",
            "ПК",
            "ВДС",
            "ИПР",
            "ИПР",
            "АТНМ",
            "АТМ",
            "ТНМ",
            "ТМ"});
            this.inpDefType.Location = new System.Drawing.Point(211, 159);
            this.inpDefType.Name = "inpDefType";
            this.inpDefType.Size = new System.Drawing.Size(106, 21);
            this.inpDefType.TabIndex = 6;
            this.inpDefType.Text = "Т";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 27);
            this.label13.TabIndex = 102;
            this.label13.Text = "Тип позиции по-умолчанию";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 26);
            this.label1.TabIndex = 108;
            this.label1.Text = "Токен";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inpToken
            // 
            this.inpToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpToken.Location = new System.Drawing.Point(211, 3);
            this.inpToken.Name = "inpToken";
            this.inpToken.Size = new System.Drawing.Size(106, 20);
            this.inpToken.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 26);
            this.label4.TabIndex = 101;
            this.label4.Text = "ИНН организации";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 26);
            this.label7.TabIndex = 105;
            this.label7.Text = "Регистрационный номер ККМ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 26);
            this.label2.TabIndex = 107;
            this.label2.Text = "Начало диапазона сканирования";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 26);
            this.label3.TabIndex = 106;
            this.label3.Text = "Конец диапазона сканирования";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 27);
            this.label11.TabIndex = 103;
            this.label11.Text = "ЕИ позиции по-умолчанию";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 26);
            this.label9.TabIndex = 104;
            this.label9.Text = "Наименование позиции по-умолчанию";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inpVatin
            // 
            this.inpVatin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpVatin.Location = new System.Drawing.Point(211, 29);
            this.inpVatin.Name = "inpVatin";
            this.inpVatin.Size = new System.Drawing.Size(106, 20);
            this.inpVatin.TabIndex = 1;
            this.inpVatin.TextChanged += new System.EventHandler(this.AutoToken);
            // 
            // inpRegId
            // 
            this.inpRegId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpRegId.Location = new System.Drawing.Point(211, 55);
            this.inpRegId.Name = "inpRegId";
            this.inpRegId.Size = new System.Drawing.Size(106, 20);
            this.inpRegId.TabIndex = 2;
            // 
            // inpPeriodEnd
            // 
            this.inpPeriodEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpPeriodEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inpPeriodEnd.Location = new System.Drawing.Point(211, 107);
            this.inpPeriodEnd.Name = "inpPeriodEnd";
            this.inpPeriodEnd.Size = new System.Drawing.Size(106, 20);
            this.inpPeriodEnd.TabIndex = 4;
            // 
            // inpPeriodBegin
            // 
            this.inpPeriodBegin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpPeriodBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inpPeriodBegin.Location = new System.Drawing.Point(211, 81);
            this.inpPeriodBegin.Name = "inpPeriodBegin";
            this.inpPeriodBegin.Size = new System.Drawing.Size(106, 20);
            this.inpPeriodBegin.TabIndex = 3;
            // 
            // inpDefMeasure
            // 
            this.inpDefMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpDefMeasure.FormattingEnabled = true;
            this.inpDefMeasure.Items.AddRange(new object[] {
            "шт",
            "гр",
            "кг",
            "т",
            "см",
            "дм",
            "м",
            "см²",
            "дм²",
            "м²",
            "мл",
            "л",
            "м³",
            "кВт/ч",
            "ГКалл",
            "д",
            "ч",
            "мин",
            "сек",
            "КБ",
            "МБ",
            "ГБ",
            "ТБ",
            "др."});
            this.inpDefMeasure.Location = new System.Drawing.Point(211, 186);
            this.inpDefMeasure.Name = "inpDefMeasure";
            this.inpDefMeasure.Size = new System.Drawing.Size(106, 21);
            this.inpDefMeasure.TabIndex = 7;
            this.inpDefMeasure.Text = "шт";
            // 
            // inpDefName
            // 
            this.inpDefName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpDefName.Location = new System.Drawing.Point(211, 133);
            this.inpDefName.Name = "inpDefName";
            this.inpDefName.Size = new System.Drawing.Size(106, 20);
            this.inpDefName.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 255);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(344, 22);
            this.statusStrip1.TabIndex = 100;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // textStatus
            // 
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // progressStatus
            // 
            this.progressStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressStatus.Location = new System.Drawing.Point(18, 229);
            this.progressStatus.Name = "progressStatus";
            this.progressStatus.Size = new System.Drawing.Size(199, 23);
            this.progressStatus.TabIndex = 3;
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnScan.Location = new System.Drawing.Point(223, 229);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(106, 23);
            this.btnScan.TabIndex = 8;
            this.btnScan.Text = "Сканировать";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnScan_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 277);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.progressStatus);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Парсер некорректных чеков";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox inpRegId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inpToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker inpPeriodBegin;
        private System.Windows.Forms.DateTimePicker inpPeriodEnd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel textStatus;
        private System.Windows.Forms.ProgressBar progressStatus;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inpVatin;
        public System.Windows.Forms.ComboBox inpDefType;
        public System.Windows.Forms.TextBox inpDefName;
        public System.Windows.Forms.ComboBox inpDefMeasure;
    }
}

