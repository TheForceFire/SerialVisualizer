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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label2 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea11.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart1.Legends.Add(legend11);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.MinimumSize = new System.Drawing.Size(388, 150);
            this.chart1.Name = "chart1";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chart1.Series.Add(series11);
            this.chart1.Size = new System.Drawing.Size(762, 237);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1286, 577);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1278, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Options";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxFrameStart);
            this.groupBox4.Location = new System.Drawing.Point(367, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 50);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Frame Start";
            // 
            // textBoxFrameStart
            // 
            this.textBoxFrameStart.Location = new System.Drawing.Point(6, 24);
            this.textBoxFrameStart.Name = "textBoxFrameStart";
            this.textBoxFrameStart.Size = new System.Drawing.Size(188, 20);
            this.textBoxFrameStart.TabIndex = 33;
            this.textBoxFrameStart.TextChanged += new System.EventHandler(this.textBoxFrameStart_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonEndianLittle);
            this.groupBox3.Controls.Add(this.radioButtonEndianBig);
            this.groupBox3.Location = new System.Drawing.Point(367, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 44);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type of reading";
            // 
            // radioButtonEndianLittle
            // 
            this.radioButtonEndianLittle.AutoSize = true;
            this.radioButtonEndianLittle.Location = new System.Drawing.Point(6, 19);
            this.radioButtonEndianLittle.Name = "radioButtonEndianLittle";
            this.radioButtonEndianLittle.Size = new System.Drawing.Size(83, 17);
            this.radioButtonEndianLittle.TabIndex = 29;
            this.radioButtonEndianLittle.Text = "Little Endian";
            this.radioButtonEndianLittle.UseVisualStyleBackColor = true;
            this.radioButtonEndianLittle.CheckedChanged += new System.EventHandler(this.radioButtonEndianLittle_CheckedChanged);
            // 
            // radioButtonEndianBig
            // 
            this.radioButtonEndianBig.AutoSize = true;
            this.radioButtonEndianBig.Checked = true;
            this.radioButtonEndianBig.Location = new System.Drawing.Point(118, 19);
            this.radioButtonEndianBig.Name = "radioButtonEndianBig";
            this.radioButtonEndianBig.Size = new System.Drawing.Size(76, 17);
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
            this.groupBox2.Location = new System.Drawing.Point(367, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 63);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Checksum";
            // 
            // radioButtonYesChecksum
            // 
            this.radioButtonYesChecksum.AutoSize = true;
            this.radioButtonYesChecksum.Location = new System.Drawing.Point(6, 40);
            this.radioButtonYesChecksum.Name = "radioButtonYesChecksum";
            this.radioButtonYesChecksum.Size = new System.Drawing.Size(43, 17);
            this.radioButtonYesChecksum.TabIndex = 29;
            this.radioButtonYesChecksum.Text = "Yes";
            this.radioButtonYesChecksum.UseVisualStyleBackColor = true;
            this.radioButtonYesChecksum.CheckedChanged += new System.EventHandler(this.radioButtonYesChecksum_CheckedChanged);
            // 
            // radioButtonNoChecksum
            // 
            this.radioButtonNoChecksum.AutoSize = true;
            this.radioButtonNoChecksum.Checked = true;
            this.radioButtonNoChecksum.Location = new System.Drawing.Point(6, 17);
            this.radioButtonNoChecksum.Name = "radioButtonNoChecksum";
            this.radioButtonNoChecksum.Size = new System.Drawing.Size(39, 17);
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
            this.groupBox1.Location = new System.Drawing.Point(367, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 68);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // textBoxAddresLength
            // 
            this.textBoxAddresLength.Location = new System.Drawing.Point(134, 40);
            this.textBoxAddresLength.Name = "textBoxAddresLength";
            this.textBoxAddresLength.Size = new System.Drawing.Size(43, 20);
            this.textBoxAddresLength.TabIndex = 34;
            this.textBoxAddresLength.Text = "1";
            this.textBoxAddresLength.TextChanged += new System.EventHandler(this.textBoxAddresLength_TextChanged);
            // 
            // radioButtonYesAddress
            // 
            this.radioButtonYesAddress.AutoSize = true;
            this.radioButtonYesAddress.Checked = true;
            this.radioButtonYesAddress.Location = new System.Drawing.Point(6, 42);
            this.radioButtonYesAddress.Name = "radioButtonYesAddress";
            this.radioButtonYesAddress.Size = new System.Drawing.Size(43, 17);
            this.radioButtonYesAddress.TabIndex = 29;
            this.radioButtonYesAddress.TabStop = true;
            this.radioButtonYesAddress.Text = "Yes";
            this.radioButtonYesAddress.UseVisualStyleBackColor = true;
            this.radioButtonYesAddress.CheckedChanged += new System.EventHandler(this.radioButtonYesAddress_CheckedChanged);
            // 
            // radioButtonNoAddress
            // 
            this.radioButtonNoAddress.AutoSize = true;
            this.radioButtonNoAddress.Location = new System.Drawing.Point(6, 19);
            this.radioButtonNoAddress.Name = "radioButtonNoAddress";
            this.radioButtonNoAddress.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNoAddress.TabIndex = 30;
            this.radioButtonNoAddress.Text = "No";
            this.radioButtonNoAddress.UseVisualStyleBackColor = true;
            this.radioButtonNoAddress.CheckedChanged += new System.EventHandler(this.radioButtonNoAddress_CheckedChanged);
            // 
            // comboBoxSelectedPort
            // 
            this.comboBoxSelectedPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectedPort.FormattingEnabled = true;
            this.comboBoxSelectedPort.Location = new System.Drawing.Point(38, 8);
            this.comboBoxSelectedPort.Name = "comboBoxSelectedPort";
            this.comboBoxSelectedPort.Size = new System.Drawing.Size(96, 21);
            this.comboBoxSelectedPort.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Stop Bits:";
            // 
            // numericUpDownDataBits
            // 
            this.numericUpDownDataBits.Location = new System.Drawing.Point(70, 183);
            this.numericUpDownDataBits.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.numericUpDownDataBits.Name = "numericUpDownDataBits";
            this.numericUpDownDataBits.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDataBits.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
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
            this.comboBoxParity.Location = new System.Drawing.Point(70, 154);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxParity.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Parity: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
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
            this.comboBoxBaudRate.Location = new System.Drawing.Point(70, 126);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudRate.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Port:";
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Location = new System.Drawing.Point(112, 93);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(79, 13);
            this.labelConnectionStatus.TabIndex = 8;
            this.labelConnectionStatus.Text = "Not Connected";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Orange;
            this.pictureBox1.Location = new System.Drawing.Point(70, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRefreshPortList
            // 
            this.buttonRefreshPortList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRefreshPortList.Location = new System.Drawing.Point(138, 7);
            this.buttonRefreshPortList.MinimumSize = new System.Drawing.Size(37, 11);
            this.buttonRefreshPortList.Name = "buttonRefreshPortList";
            this.buttonRefreshPortList.Size = new System.Drawing.Size(75, 21);
            this.buttonRefreshPortList.TabIndex = 6;
            this.buttonRefreshPortList.Text = "Refresh";
            this.buttonRefreshPortList.UseVisualStyleBackColor = true;
            // 
            // buttonConnectComPort
            // 
            this.buttonConnectComPort.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonConnectComPort.Location = new System.Drawing.Point(4, 35);
            this.buttonConnectComPort.MinimumSize = new System.Drawing.Size(37, 11);
            this.buttonConnectComPort.Name = "buttonConnectComPort";
            this.buttonConnectComPort.Size = new System.Drawing.Size(209, 40);
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
            this.comboBoxStopBits.Location = new System.Drawing.Point(70, 207);
            this.comboBoxStopBits.MinimumSize = new System.Drawing.Size(83, 0);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(120, 21);
            this.comboBoxStopBits.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1278, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data & Graphics";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Clear Graphic";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Addr length:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 583);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1295, 622);
            this.MinimumSize = new System.Drawing.Size(1295, 622);
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
    }
}

