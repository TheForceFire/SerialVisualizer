namespace SerialVisualizer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxFrameStart = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonEndianLittle = new System.Windows.Forms.RadioButton();
            this.radioButtonEndianBig = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonYesChecksum = new System.Windows.Forms.RadioButton();
            this.radioButtonNoChecksum = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAddresLength = new System.Windows.Forms.TextBox();
            this.radioButtonYesAddress = new System.Windows.Forms.RadioButton();
            this.radioButtonNoAddress = new System.Windows.Forms.RadioButton();
            this.comboBoxSelectedPort = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownDataBits = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRefreshPortList = new System.Windows.Forms.Button();
            this.buttonConnectComPort = new System.Windows.Forms.Button();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButtonInt8 = new System.Windows.Forms.RadioButton();
            this.radioButtonUint8 = new System.Windows.Forms.RadioButton();
            this.radioButtonInt16 = new System.Windows.Forms.RadioButton();
            this.radioButtonUint16 = new System.Windows.Forms.RadioButton();
            this.radioButtonInt32 = new System.Windows.Forms.RadioButton();
            this.radioButtonUint32 = new System.Windows.Forms.RadioButton();
            this.radioButtonFloat = new System.Windows.Forms.RadioButton();
            this.radioButtonDouble = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDataBits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea10.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart1.Legends.Add(legend10);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.MinimumSize = new System.Drawing.Size(517, 185);
            this.chart1.Name = "chart1";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(1016, 292);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1715, 710);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.comboBoxSelectedPort);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.numericUpDownDataBits);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.comboBoxParity);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBoxBaudRate);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labelConnectionStatus);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.buttonRefreshPortList);
            this.tabPage1.Controls.Add(this.buttonConnectComPort);
            this.tabPage1.Controls.Add(this.comboBoxStopBits);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1707, 681);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Options";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxFrameStart);
            this.groupBox4.Location = new System.Drawing.Point(345, 10);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(267, 62);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Frame Start";
            // 
            // textBoxFrameStart
            // 
            this.textBoxFrameStart.Location = new System.Drawing.Point(8, 30);
            this.textBoxFrameStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFrameStart.Name = "textBoxFrameStart";
            this.textBoxFrameStart.Size = new System.Drawing.Size(249, 22);
            this.textBoxFrameStart.TabIndex = 33;
            this.textBoxFrameStart.Text = "AABB";
            this.textBoxFrameStart.TextChanged += new System.EventHandler(this.textBoxFrameStart_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonEndianLittle);
            this.groupBox3.Controls.Add(this.radioButtonEndianBig);
            this.groupBox3.Location = new System.Drawing.Point(345, 78);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(267, 54);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type of reading";
            // 
            // radioButtonEndianLittle
            // 
            this.radioButtonEndianLittle.AutoSize = true;
            this.radioButtonEndianLittle.Location = new System.Drawing.Point(8, 23);
            this.radioButtonEndianLittle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonEndianLittle.Name = "radioButtonEndianLittle";
            this.radioButtonEndianLittle.Size = new System.Drawing.Size(100, 20);
            this.radioButtonEndianLittle.TabIndex = 29;
            this.radioButtonEndianLittle.Text = "Little Endian";
            this.radioButtonEndianLittle.UseVisualStyleBackColor = true;
            this.radioButtonEndianLittle.CheckedChanged += new System.EventHandler(this.radioButtonEndianLittle_CheckedChanged);
            // 
            // radioButtonEndianBig
            // 
            this.radioButtonEndianBig.AutoSize = true;
            this.radioButtonEndianBig.Checked = true;
            this.radioButtonEndianBig.Location = new System.Drawing.Point(157, 23);
            this.radioButtonEndianBig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonEndianBig.Name = "radioButtonEndianBig";
            this.radioButtonEndianBig.Size = new System.Drawing.Size(93, 20);
            this.radioButtonEndianBig.TabIndex = 30;
            this.radioButtonEndianBig.TabStop = true;
            this.radioButtonEndianBig.Text = "Big Endian";
            this.radioButtonEndianBig.UseVisualStyleBackColor = true;
            this.radioButtonEndianBig.CheckedChanged += new System.EventHandler(this.radioButtonEndianBig_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonYesChecksum);
            this.groupBox2.Controls.Add(this.radioButtonNoChecksum);
            this.groupBox2.Location = new System.Drawing.Point(345, 231);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(267, 78);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Checksum";
            // 
            // radioButtonYesChecksum
            // 
            this.radioButtonYesChecksum.AutoSize = true;
            this.radioButtonYesChecksum.Location = new System.Drawing.Point(8, 49);
            this.radioButtonYesChecksum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonYesChecksum.Name = "radioButtonYesChecksum";
            this.radioButtonYesChecksum.Size = new System.Drawing.Size(52, 20);
            this.radioButtonYesChecksum.TabIndex = 29;
            this.radioButtonYesChecksum.Text = "Yes";
            this.radioButtonYesChecksum.UseVisualStyleBackColor = true;
            this.radioButtonYesChecksum.CheckedChanged += new System.EventHandler(this.radioButtonYesChecksum_CheckedChanged);
            // 
            // radioButtonNoChecksum
            // 
            this.radioButtonNoChecksum.AutoSize = true;
            this.radioButtonNoChecksum.Checked = true;
            this.radioButtonNoChecksum.Location = new System.Drawing.Point(8, 21);
            this.radioButtonNoChecksum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonNoChecksum.Name = "radioButtonNoChecksum";
            this.radioButtonNoChecksum.Size = new System.Drawing.Size(46, 20);
            this.radioButtonNoChecksum.TabIndex = 30;
            this.radioButtonNoChecksum.TabStop = true;
            this.radioButtonNoChecksum.Text = "No";
            this.radioButtonNoChecksum.UseVisualStyleBackColor = true;
            this.radioButtonNoChecksum.CheckedChanged += new System.EventHandler(this.radioButtonNoChecksum_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxAddresLength);
            this.groupBox1.Controls.Add(this.radioButtonYesAddress);
            this.groupBox1.Controls.Add(this.radioButtonNoAddress);
            this.groupBox1.Location = new System.Drawing.Point(345, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(267, 84);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Addr length:";
            // 
            // textBoxAddresLength
            // 
            this.textBoxAddresLength.Location = new System.Drawing.Point(179, 49);
            this.textBoxAddresLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAddresLength.Name = "textBoxAddresLength";
            this.textBoxAddresLength.Size = new System.Drawing.Size(56, 22);
            this.textBoxAddresLength.TabIndex = 34;
            this.textBoxAddresLength.Text = "1";
            this.textBoxAddresLength.TextChanged += new System.EventHandler(this.textBoxAddresLength_TextChanged);
            // 
            // radioButtonYesAddress
            // 
            this.radioButtonYesAddress.AutoSize = true;
            this.radioButtonYesAddress.Checked = true;
            this.radioButtonYesAddress.Location = new System.Drawing.Point(8, 52);
            this.radioButtonYesAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonYesAddress.Name = "radioButtonYesAddress";
            this.radioButtonYesAddress.Size = new System.Drawing.Size(52, 20);
            this.radioButtonYesAddress.TabIndex = 29;
            this.radioButtonYesAddress.TabStop = true;
            this.radioButtonYesAddress.Text = "Yes";
            this.radioButtonYesAddress.UseVisualStyleBackColor = true;
            this.radioButtonYesAddress.CheckedChanged += new System.EventHandler(this.radioButtonYesAddress_CheckedChanged);
            // 
            // radioButtonNoAddress
            // 
            this.radioButtonNoAddress.AutoSize = true;
            this.radioButtonNoAddress.Location = new System.Drawing.Point(8, 23);
            this.radioButtonNoAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonNoAddress.Name = "radioButtonNoAddress";
            this.radioButtonNoAddress.Size = new System.Drawing.Size(46, 20);
            this.radioButtonNoAddress.TabIndex = 30;
            this.radioButtonNoAddress.Text = "No";
            this.radioButtonNoAddress.UseVisualStyleBackColor = true;
            this.radioButtonNoAddress.CheckedChanged += new System.EventHandler(this.radioButtonNoAddress_CheckedChanged);
            // 
            // comboBoxSelectedPort
            // 
            this.comboBoxSelectedPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectedPort.FormattingEnabled = true;
            this.comboBoxSelectedPort.Location = new System.Drawing.Point(51, 10);
            this.comboBoxSelectedPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSelectedPort.Name = "comboBoxSelectedPort";
            this.comboBoxSelectedPort.Size = new System.Drawing.Size(127, 24);
            this.comboBoxSelectedPort.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Stop Bits:";
            // 
            // numericUpDownDataBits
            // 
            this.numericUpDownDataBits.Location = new System.Drawing.Point(93, 225);
            this.numericUpDownDataBits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownDataBits.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.numericUpDownDataBits.Name = "numericUpDownDataBits";
            this.numericUpDownDataBits.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownDataBits.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data Bits:";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBoxParity.Location = new System.Drawing.Point(93, 190);
            this.comboBoxParity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(160, 24);
            this.comboBoxParity.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Parity: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Baud Rate:";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(93, 155);
            this.comboBoxBaudRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(160, 24);
            this.comboBoxBaudRate.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Port:";
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Location = new System.Drawing.Point(149, 114);
            this.labelConnectionStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(96, 16);
            this.labelConnectionStatus.TabIndex = 8;
            this.labelConnectionStatus.Text = "Not Connected";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Orange;
            this.pictureBox1.Location = new System.Drawing.Point(93, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRefreshPortList
            // 
            this.buttonRefreshPortList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRefreshPortList.Location = new System.Drawing.Point(184, 9);
            this.buttonRefreshPortList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRefreshPortList.MinimumSize = new System.Drawing.Size(49, 14);
            this.buttonRefreshPortList.Name = "buttonRefreshPortList";
            this.buttonRefreshPortList.Size = new System.Drawing.Size(100, 26);
            this.buttonRefreshPortList.TabIndex = 6;
            this.buttonRefreshPortList.Text = "Refresh";
            this.buttonRefreshPortList.UseVisualStyleBackColor = true;
            // 
            // buttonConnectComPort
            // 
            this.buttonConnectComPort.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonConnectComPort.Location = new System.Drawing.Point(5, 43);
            this.buttonConnectComPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConnectComPort.MinimumSize = new System.Drawing.Size(49, 14);
            this.buttonConnectComPort.Name = "buttonConnectComPort";
            this.buttonConnectComPort.Size = new System.Drawing.Size(279, 49);
            this.buttonConnectComPort.TabIndex = 5;
            this.buttonConnectComPort.Text = "Connect";
            this.buttonConnectComPort.UseVisualStyleBackColor = true;
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "0",
            "1",
            "1,5",
            "2"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(93, 255);
            this.comboBoxStopBits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxStopBits.MinimumSize = new System.Drawing.Size(109, 0);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(159, 24);
            this.comboBoxStopBits.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1707, 681);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data & Graphics";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 299);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 28);
            this.button3.TabIndex = 1;
            this.button3.Text = "Clear Graphic";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButtonDouble);
            this.groupBox5.Controls.Add(this.radioButtonFloat);
            this.groupBox5.Controls.Add(this.radioButtonUint32);
            this.groupBox5.Controls.Add(this.radioButtonInt32);
            this.groupBox5.Controls.Add(this.radioButtonUint16);
            this.groupBox5.Controls.Add(this.radioButtonInt16);
            this.groupBox5.Controls.Add(this.radioButtonUint8);
            this.groupBox5.Controls.Add(this.radioButtonInt8);
            this.groupBox5.Location = new System.Drawing.Point(669, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(198, 237);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Data type";
            // 
            // radioButtonInt8
            // 
            this.radioButtonInt8.AutoSize = true;
            this.radioButtonInt8.Location = new System.Drawing.Point(6, 21);
            this.radioButtonInt8.Name = "radioButtonInt8";
            this.radioButtonInt8.Size = new System.Drawing.Size(155, 20);
            this.radioButtonInt8.TabIndex = 0;
            this.radioButtonInt8.Text = "Signed Integer 1 Byte";
            this.radioButtonInt8.UseVisualStyleBackColor = true;
            this.radioButtonInt8.CheckedChanged += new System.EventHandler(this.radioButtonInt8_CheckedChanged);
            // 
            // radioButtonUint8
            // 
            this.radioButtonUint8.AutoSize = true;
            this.radioButtonUint8.Checked = true;
            this.radioButtonUint8.Location = new System.Drawing.Point(6, 47);
            this.radioButtonUint8.Name = "radioButtonUint8";
            this.radioButtonUint8.Size = new System.Drawing.Size(170, 20);
            this.radioButtonUint8.TabIndex = 1;
            this.radioButtonUint8.TabStop = true;
            this.radioButtonUint8.Text = "Unsigned Integer 1 Byte";
            this.radioButtonUint8.UseVisualStyleBackColor = true;
            this.radioButtonUint8.CheckedChanged += new System.EventHandler(this.radioButtonUint8_CheckedChanged);
            // 
            // radioButtonInt16
            // 
            this.radioButtonInt16.AutoSize = true;
            this.radioButtonInt16.Location = new System.Drawing.Point(6, 73);
            this.radioButtonInt16.Name = "radioButtonInt16";
            this.radioButtonInt16.Size = new System.Drawing.Size(162, 20);
            this.radioButtonInt16.TabIndex = 2;
            this.radioButtonInt16.Text = "Signed Integer 2 Bytes";
            this.radioButtonInt16.UseVisualStyleBackColor = true;
            this.radioButtonInt16.CheckedChanged += new System.EventHandler(this.radioButtonInt16_CheckedChanged);
            // 
            // radioButtonUint16
            // 
            this.radioButtonUint16.AutoSize = true;
            this.radioButtonUint16.Location = new System.Drawing.Point(6, 99);
            this.radioButtonUint16.Name = "radioButtonUint16";
            this.radioButtonUint16.Size = new System.Drawing.Size(177, 20);
            this.radioButtonUint16.TabIndex = 3;
            this.radioButtonUint16.Text = "Unsigned Integer 2 Bytes";
            this.radioButtonUint16.UseVisualStyleBackColor = true;
            this.radioButtonUint16.CheckedChanged += new System.EventHandler(this.radioButtonUint16_CheckedChanged);
            // 
            // radioButtonInt32
            // 
            this.radioButtonInt32.AutoSize = true;
            this.radioButtonInt32.Location = new System.Drawing.Point(6, 125);
            this.radioButtonInt32.Name = "radioButtonInt32";
            this.radioButtonInt32.Size = new System.Drawing.Size(162, 20);
            this.radioButtonInt32.TabIndex = 4;
            this.radioButtonInt32.Text = "Signed Integer 4 Bytes";
            this.radioButtonInt32.UseVisualStyleBackColor = true;
            this.radioButtonInt32.CheckedChanged += new System.EventHandler(this.radioButtonInt32_CheckedChanged);
            // 
            // radioButtonUint32
            // 
            this.radioButtonUint32.AutoSize = true;
            this.radioButtonUint32.Location = new System.Drawing.Point(6, 151);
            this.radioButtonUint32.Name = "radioButtonUint32";
            this.radioButtonUint32.Size = new System.Drawing.Size(177, 20);
            this.radioButtonUint32.TabIndex = 5;
            this.radioButtonUint32.Text = "Unsigned Integer 4 Bytes";
            this.radioButtonUint32.UseVisualStyleBackColor = true;
            this.radioButtonUint32.CheckedChanged += new System.EventHandler(this.radioButtonUint32_CheckedChanged);
            // 
            // radioButtonFloat
            // 
            this.radioButtonFloat.AutoSize = true;
            this.radioButtonFloat.Location = new System.Drawing.Point(6, 177);
            this.radioButtonFloat.Name = "radioButtonFloat";
            this.radioButtonFloat.Size = new System.Drawing.Size(58, 20);
            this.radioButtonFloat.TabIndex = 6;
            this.radioButtonFloat.Text = "Float";
            this.radioButtonFloat.UseVisualStyleBackColor = true;
            this.radioButtonFloat.CheckedChanged += new System.EventHandler(this.radioButtonFloat_CheckedChanged);
            // 
            // radioButtonDouble
            // 
            this.radioButtonDouble.AutoSize = true;
            this.radioButtonDouble.Location = new System.Drawing.Point(6, 203);
            this.radioButtonDouble.Name = "radioButtonDouble";
            this.radioButtonDouble.Size = new System.Drawing.Size(72, 20);
            this.radioButtonDouble.TabIndex = 7;
            this.radioButtonDouble.Text = "Double";
            this.radioButtonDouble.UseVisualStyleBackColor = true;
            this.radioButtonDouble.CheckedChanged += new System.EventHandler(this.radioButtonDouble_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 708);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1721, 755);
            this.MinimumSize = new System.Drawing.Size(1721, 755);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDataBits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelConnectionStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRefreshPortList;
        private System.Windows.Forms.Button buttonConnectComPort;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownDataBits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSelectedPort;
        private System.Windows.Forms.RadioButton radioButtonNoAddress;
        private System.Windows.Forms.RadioButton radioButtonYesAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonYesChecksum;
        private System.Windows.Forms.RadioButton radioButtonNoChecksum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonEndianLittle;
        private System.Windows.Forms.RadioButton radioButtonEndianBig;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxFrameStart;
        private System.Windows.Forms.TextBox textBoxAddresLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButtonFloat;
        private System.Windows.Forms.RadioButton radioButtonUint32;
        private System.Windows.Forms.RadioButton radioButtonInt32;
        private System.Windows.Forms.RadioButton radioButtonUint16;
        private System.Windows.Forms.RadioButton radioButtonInt16;
        private System.Windows.Forms.RadioButton radioButtonUint8;
        private System.Windows.Forms.RadioButton radioButtonInt8;
        private System.Windows.Forms.RadioButton radioButtonDouble;
    }
}

