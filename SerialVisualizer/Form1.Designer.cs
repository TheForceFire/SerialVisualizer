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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtRowName = new System.Windows.Forms.TextBox();
            this.txtColumnName = new System.Windows.Forms.TextBox();
            this.txtDeleteRow = new System.Windows.Forms.TextBox();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.chkDeleteFirstOnly = new System.Windows.Forms.CheckBox();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.btnDeleteColumn = new System.Windows.Forms.Button();
            this.btnDeleteAllColumns = new System.Windows.Forms.Button();
            this.btnClearRows = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboBoxSelectedPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefreshPortList = new System.Windows.Forms.Button();
            this.buttonConnectComPort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownDataBits = new System.Windows.Forms.NumericUpDown();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numericUpDownDataAmount = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButtonDouble = new System.Windows.Forms.RadioButton();
            this.radioButtonFloat = new System.Windows.Forms.RadioButton();
            this.radioButtonUint32 = new System.Windows.Forms.RadioButton();
            this.radioButtonInt32 = new System.Windows.Forms.RadioButton();
            this.radioButtonUint16 = new System.Windows.Forms.RadioButton();
            this.radioButtonInt16 = new System.Windows.Forms.RadioButton();
            this.radioButtonUint8 = new System.Windows.Forms.RadioButton();
            this.radioButtonInt8 = new System.Windows.Forms.RadioButton();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.saveButton = new System.Windows.Forms.Button();
            this.buttonRemoveScale = new System.Windows.Forms.Button();
            this.buttonAddScale = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxScaleValues = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.seriesChange = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.RenameBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDataBits)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDataAmount)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seriesChange)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.BorderColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 4);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.MinimumSize = new System.Drawing.Size(517, 185);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1700, 603);
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
            this.tabPage1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.txtRowName);
            this.tabPage1.Controls.Add(this.txtColumnName);
            this.tabPage1.Controls.Add(this.txtDeleteRow);
            this.tabPage1.Controls.Add(this.btnDeleteRow);
            this.tabPage1.Controls.Add(this.chkDeleteFirstOnly);
            this.tabPage1.Controls.Add(this.btnAddColumn);
            this.tabPage1.Controls.Add(this.btnDeleteColumn);
            this.tabPage1.Controls.Add(this.btnDeleteAllColumns);
            this.tabPage1.Controls.Add(this.btnClearRows);
            this.tabPage1.Controls.Add(this.buttonAdd);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1707, 681);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "+-";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtRowName
            // 
            this.txtRowName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtRowName.Location = new System.Drawing.Point(961, 357);
            this.txtRowName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRowName.Name = "txtRowName";
            this.txtRowName.Size = new System.Drawing.Size(192, 22);
            this.txtRowName.TabIndex = 46;
            // 
            // txtColumnName
            // 
            this.txtColumnName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtColumnName.Location = new System.Drawing.Point(961, 465);
            this.txtColumnName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtColumnName.Name = "txtColumnName";
            this.txtColumnName.Size = new System.Drawing.Size(192, 22);
            this.txtColumnName.TabIndex = 47;
            this.txtColumnName.TextChanged += new System.EventHandler(this.txtColumnName_TextChanged);
            // 
            // txtDeleteRow
            // 
            this.txtDeleteRow.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDeleteRow.Location = new System.Drawing.Point(1225, 357);
            this.txtDeleteRow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDeleteRow.Name = "txtDeleteRow";
            this.txtDeleteRow.Size = new System.Drawing.Size(212, 22);
            this.txtDeleteRow.TabIndex = 48;
            this.txtDeleteRow.TextChanged += new System.EventHandler(this.txtDeleteRow_TextChanged);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRow.Location = new System.Drawing.Point(1452, 356);
            this.btnDeleteRow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(181, 26);
            this.btnDeleteRow.TabIndex = 47;
            this.btnDeleteRow.Text = "Удалить строку";
            this.btnDeleteRow.UseVisualStyleBackColor = false;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // chkDeleteFirstOnly
            // 
            this.chkDeleteFirstOnly.AutoSize = true;
            this.chkDeleteFirstOnly.Location = new System.Drawing.Point(1220, 393);
            this.chkDeleteFirstOnly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDeleteFirstOnly.Name = "chkDeleteFirstOnly";
            this.chkDeleteFirstOnly.Size = new System.Drawing.Size(205, 20);
            this.chkDeleteFirstOnly.TabIndex = 48;
            this.chkDeleteFirstOnly.Text = "Удалять только последнее";
            this.chkDeleteFirstOnly.UseVisualStyleBackColor = true;
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddColumn.Location = new System.Drawing.Point(989, 500);
            this.btnAddColumn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(140, 57);
            this.btnAddColumn.TabIndex = 50;
            this.btnAddColumn.Text = "Добавить столбец";
            this.btnAddColumn.UseVisualStyleBackColor = false;
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // btnDeleteColumn
            // 
            this.btnDeleteColumn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteColumn.Location = new System.Drawing.Point(1452, 393);
            this.btnDeleteColumn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteColumn.Name = "btnDeleteColumn";
            this.btnDeleteColumn.Size = new System.Drawing.Size(181, 30);
            this.btnDeleteColumn.TabIndex = 51;
            this.btnDeleteColumn.Text = "Удалить столбец";
            this.btnDeleteColumn.UseVisualStyleBackColor = false;
            this.btnDeleteColumn.Click += new System.EventHandler(this.btnDeleteColumn_Click);
            // 
            // btnDeleteAllColumns
            // 
            this.btnDeleteAllColumns.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteAllColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAllColumns.Location = new System.Drawing.Point(1527, 508);
            this.btnDeleteAllColumns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteAllColumns.Name = "btnDeleteAllColumns";
            this.btnDeleteAllColumns.Size = new System.Drawing.Size(107, 48);
            this.btnDeleteAllColumns.TabIndex = 52;
            this.btnDeleteAllColumns.Text = "Убрать все столбы";
            this.btnDeleteAllColumns.UseVisualStyleBackColor = false;
            this.btnDeleteAllColumns.Click += new System.EventHandler(this.btnDeleteAllColumns_Click);
            // 
            // btnClearRows
            // 
            this.btnClearRows.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClearRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearRows.Location = new System.Drawing.Point(1525, 453);
            this.btnClearRows.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearRows.Name = "btnClearRows";
            this.btnClearRows.Size = new System.Drawing.Size(108, 48);
            this.btnClearRows.TabIndex = 43;
            this.btnClearRows.Text = "Убрать все строки";
            this.btnClearRows.UseVisualStyleBackColor = false;
            this.btnClearRows.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(989, 393);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(140, 57);
            this.buttonAdd.TabIndex = 42;
            this.buttonAdd.Text = "Добавить новую строку";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(961, 164);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(672, 185);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(228, 389);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(208, 65);
            this.button6.TabIndex = 40;
            this.button6.Text = "Read protocol settings";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(228, 316);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(208, 65);
            this.button7.TabIndex = 39;
            this.button7.Text = "Write protocol settings";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(12, 389);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(208, 65);
            this.button5.TabIndex = 38;
            this.button5.Text = "Read port settings";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(12, 316);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 65);
            this.button4.TabIndex = 37;
            this.button4.Text = "Write port settings";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.AutoSize = true;
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.button2);
            this.groupBox8.Controls.Add(this.checkBox1);
            this.groupBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox8.Location = new System.Drawing.Point(907, 10);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Size = new System.Drawing.Size(267, 138);
            this.groupBox8.TabIndex = 36;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Table";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 53);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "./";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Folder: ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(8, 84);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Open Folder";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(9, 23);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Enable table write";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboBoxSelectedPort);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.buttonRefreshPortList);
            this.groupBox7.Controls.Add(this.buttonConnectComPort);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.pictureBox1);
            this.groupBox7.Controls.Add(this.labelConnectionStatus);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.comboBoxStopBits);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.numericUpDownDataBits);
            this.groupBox7.Controls.Add(this.comboBoxBaudRate);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.comboBoxParity);
            this.groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox7.Location = new System.Drawing.Point(12, 10);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(312, 299);
            this.groupBox7.TabIndex = 35;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "COM port";
            // 
            // comboBoxSelectedPort
            // 
            this.comboBoxSelectedPort.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBoxSelectedPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectedPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSelectedPort.FormattingEnabled = true;
            this.comboBoxSelectedPort.Location = new System.Drawing.Point(55, 23);
            this.comboBoxSelectedPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSelectedPort.Name = "comboBoxSelectedPort";
            this.comboBoxSelectedPort.Size = new System.Drawing.Size(127, 24);
            this.comboBoxSelectedPort.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Port:";
            // 
            // buttonRefreshPortList
            // 
            this.buttonRefreshPortList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRefreshPortList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshPortList.Location = new System.Drawing.Point(199, 23);
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
            this.buttonConnectComPort.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonConnectComPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnectComPort.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonConnectComPort.Location = new System.Drawing.Point(20, 63);
            this.buttonConnectComPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConnectComPort.MinimumSize = new System.Drawing.Size(49, 14);
            this.buttonConnectComPort.Name = "buttonConnectComPort";
            this.buttonConnectComPort.Size = new System.Drawing.Size(279, 49);
            this.buttonConnectComPort.TabIndex = 5;
            this.buttonConnectComPort.Text = "Connect";
            this.buttonConnectComPort.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Orange;
            this.pictureBox1.Location = new System.Drawing.Point(69, 119);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Location = new System.Drawing.Point(136, 130);
            this.labelConnectionStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(96, 16);
            this.labelConnectionStatus.TabIndex = 8;
            this.labelConnectionStatus.Text = "Not Connected";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 267);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Stop Bits:";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStopBits.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "0",
            "1",
            "1,5",
            "2"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(97, 265);
            this.comboBoxStopBits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxStopBits.MinimumSize = new System.Drawing.Size(109, 0);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(171, 24);
            this.comboBoxStopBits.TabIndex = 4;
            this.comboBoxStopBits.SelectedIndexChanged += new System.EventHandler(this.comboBoxStopBits_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Baud Rate:";
            // 
            // numericUpDownDataBits
            // 
            this.numericUpDownDataBits.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numericUpDownDataBits.Location = new System.Drawing.Point(97, 233);
            this.numericUpDownDataBits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownDataBits.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.numericUpDownDataBits.Name = "numericUpDownDataBits";
            this.numericUpDownDataBits.Size = new System.Drawing.Size(172, 22);
            this.numericUpDownDataBits.TabIndex = 16;
            this.numericUpDownDataBits.ValueChanged += new System.EventHandler(this.numericUpDownDataBits_ValueChanged);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.comboBoxBaudRate.Location = new System.Drawing.Point(97, 170);
            this.comboBoxBaudRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(171, 24);
            this.comboBoxBaudRate.TabIndex = 11;
            this.comboBoxBaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaudRate_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data Bits:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Parity: ";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBoxParity.Location = new System.Drawing.Point(97, 199);
            this.comboBoxParity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(171, 24);
            this.comboBoxParity.TabIndex = 14;
            this.comboBoxParity.SelectedIndexChanged += new System.EventHandler(this.comboBoxParity_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.numericUpDownDataAmount);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Location = new System.Drawing.Point(669, 255);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(197, 54);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Data Amount";
            // 
            // numericUpDownDataAmount
            // 
            this.numericUpDownDataAmount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numericUpDownDataAmount.Location = new System.Drawing.Point(8, 22);
            this.numericUpDownDataAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownDataAmount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDataAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDataAmount.Name = "numericUpDownDataAmount";
            this.numericUpDownDataAmount.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownDataAmount.TabIndex = 35;
            this.numericUpDownDataAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDataAmount.ValueChanged += new System.EventHandler(this.numericUpDownDataAmount_ValueChanged);
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
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Location = new System.Drawing.Point(669, 10);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(197, 238);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Data type";
            // 
            // radioButtonDouble
            // 
            this.radioButtonDouble.AutoSize = true;
            this.radioButtonDouble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonDouble.Location = new System.Drawing.Point(5, 203);
            this.radioButtonDouble.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonDouble.Name = "radioButtonDouble";
            this.radioButtonDouble.Size = new System.Drawing.Size(71, 20);
            this.radioButtonDouble.TabIndex = 7;
            this.radioButtonDouble.Text = "Double";
            this.radioButtonDouble.UseVisualStyleBackColor = true;
            this.radioButtonDouble.CheckedChanged += new System.EventHandler(this.radioButtonDouble_CheckedChanged);
            // 
            // radioButtonFloat
            // 
            this.radioButtonFloat.AutoSize = true;
            this.radioButtonFloat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonFloat.Location = new System.Drawing.Point(5, 177);
            this.radioButtonFloat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonFloat.Name = "radioButtonFloat";
            this.radioButtonFloat.Size = new System.Drawing.Size(57, 20);
            this.radioButtonFloat.TabIndex = 6;
            this.radioButtonFloat.Text = "Float";
            this.radioButtonFloat.UseVisualStyleBackColor = true;
            this.radioButtonFloat.CheckedChanged += new System.EventHandler(this.radioButtonFloat_CheckedChanged);
            // 
            // radioButtonUint32
            // 
            this.radioButtonUint32.AutoSize = true;
            this.radioButtonUint32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonUint32.Location = new System.Drawing.Point(5, 151);
            this.radioButtonUint32.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUint32.Name = "radioButtonUint32";
            this.radioButtonUint32.Size = new System.Drawing.Size(176, 20);
            this.radioButtonUint32.TabIndex = 5;
            this.radioButtonUint32.Text = "Unsigned Integer 4 Bytes";
            this.radioButtonUint32.UseVisualStyleBackColor = true;
            this.radioButtonUint32.CheckedChanged += new System.EventHandler(this.radioButtonUint32_CheckedChanged);
            // 
            // radioButtonInt32
            // 
            this.radioButtonInt32.AutoSize = true;
            this.radioButtonInt32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonInt32.Location = new System.Drawing.Point(5, 126);
            this.radioButtonInt32.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonInt32.Name = "radioButtonInt32";
            this.radioButtonInt32.Size = new System.Drawing.Size(161, 20);
            this.radioButtonInt32.TabIndex = 4;
            this.radioButtonInt32.Text = "Signed Integer 4 Bytes";
            this.radioButtonInt32.UseVisualStyleBackColor = true;
            this.radioButtonInt32.CheckedChanged += new System.EventHandler(this.radioButtonInt32_CheckedChanged);
            // 
            // radioButtonUint16
            // 
            this.radioButtonUint16.AutoSize = true;
            this.radioButtonUint16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonUint16.Location = new System.Drawing.Point(5, 98);
            this.radioButtonUint16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUint16.Name = "radioButtonUint16";
            this.radioButtonUint16.Size = new System.Drawing.Size(176, 20);
            this.radioButtonUint16.TabIndex = 3;
            this.radioButtonUint16.Text = "Unsigned Integer 2 Bytes";
            this.radioButtonUint16.UseVisualStyleBackColor = true;
            this.radioButtonUint16.CheckedChanged += new System.EventHandler(this.radioButtonUint16_CheckedChanged);
            // 
            // radioButtonInt16
            // 
            this.radioButtonInt16.AutoSize = true;
            this.radioButtonInt16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonInt16.Location = new System.Drawing.Point(5, 73);
            this.radioButtonInt16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonInt16.Name = "radioButtonInt16";
            this.radioButtonInt16.Size = new System.Drawing.Size(161, 20);
            this.radioButtonInt16.TabIndex = 2;
            this.radioButtonInt16.Text = "Signed Integer 2 Bytes";
            this.radioButtonInt16.UseVisualStyleBackColor = true;
            this.radioButtonInt16.CheckedChanged += new System.EventHandler(this.radioButtonInt16_CheckedChanged);
            // 
            // radioButtonUint8
            // 
            this.radioButtonUint8.AutoSize = true;
            this.radioButtonUint8.Checked = true;
            this.radioButtonUint8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonUint8.Location = new System.Drawing.Point(5, 47);
            this.radioButtonUint8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUint8.Name = "radioButtonUint8";
            this.radioButtonUint8.Size = new System.Drawing.Size(169, 20);
            this.radioButtonUint8.TabIndex = 1;
            this.radioButtonUint8.TabStop = true;
            this.radioButtonUint8.Text = "Unsigned Integer 1 Byte";
            this.radioButtonUint8.UseVisualStyleBackColor = true;
            this.radioButtonUint8.CheckedChanged += new System.EventHandler(this.radioButtonUint8_CheckedChanged);
            // 
            // radioButtonInt8
            // 
            this.radioButtonInt8.AutoSize = true;
            this.radioButtonInt8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonInt8.Location = new System.Drawing.Point(5, 21);
            this.radioButtonInt8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonInt8.Name = "radioButtonInt8";
            this.radioButtonInt8.Size = new System.Drawing.Size(154, 20);
            this.radioButtonInt8.TabIndex = 0;
            this.radioButtonInt8.Text = "Signed Integer 1 Byte";
            this.radioButtonInt8.UseVisualStyleBackColor = true;
            this.radioButtonInt8.CheckedChanged += new System.EventHandler(this.radioButtonInt8_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxFrameStart);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.textBoxFrameStart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxFrameStart.ForeColor = System.Drawing.SystemColors.MenuText;
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
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.radioButtonEndianLittle.Checked = true;
            this.radioButtonEndianLittle.Location = new System.Drawing.Point(8, 23);
            this.radioButtonEndianLittle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonEndianLittle.Name = "radioButtonEndianLittle";
            this.radioButtonEndianLittle.Size = new System.Drawing.Size(100, 20);
            this.radioButtonEndianLittle.TabIndex = 29;
            this.radioButtonEndianLittle.TabStop = true;
            this.radioButtonEndianLittle.Text = "Little Endian";
            this.radioButtonEndianLittle.UseVisualStyleBackColor = true;
            this.radioButtonEndianLittle.CheckedChanged += new System.EventHandler(this.radioButtonEndianLittle_CheckedChanged);
            // 
            // radioButtonEndianBig
            // 
            this.radioButtonEndianBig.AutoSize = true;
            this.radioButtonEndianBig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonEndianBig.Location = new System.Drawing.Point(157, 23);
            this.radioButtonEndianBig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonEndianBig.Name = "radioButtonEndianBig";
            this.radioButtonEndianBig.Size = new System.Drawing.Size(92, 20);
            this.radioButtonEndianBig.TabIndex = 30;
            this.radioButtonEndianBig.Text = "Big Endian";
            this.radioButtonEndianBig.UseVisualStyleBackColor = true;
            this.radioButtonEndianBig.CheckedChanged += new System.EventHandler(this.radioButtonEndianBig_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonYesChecksum);
            this.groupBox2.Controls.Add(this.radioButtonNoChecksum);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.radioButtonYesChecksum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonYesChecksum.Location = new System.Drawing.Point(8, 49);
            this.radioButtonYesChecksum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonYesChecksum.Name = "radioButtonYesChecksum";
            this.radioButtonYesChecksum.Size = new System.Drawing.Size(51, 20);
            this.radioButtonYesChecksum.TabIndex = 29;
            this.radioButtonYesChecksum.Text = "Yes";
            this.radioButtonYesChecksum.UseVisualStyleBackColor = true;
            this.radioButtonYesChecksum.CheckedChanged += new System.EventHandler(this.radioButtonYesChecksum_CheckedChanged);
            // 
            // radioButtonNoChecksum
            // 
            this.radioButtonNoChecksum.AutoSize = true;
            this.radioButtonNoChecksum.Checked = true;
            this.radioButtonNoChecksum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonNoChecksum.Location = new System.Drawing.Point(8, 21);
            this.radioButtonNoChecksum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonNoChecksum.Name = "radioButtonNoChecksum";
            this.radioButtonNoChecksum.Size = new System.Drawing.Size(45, 20);
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
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.textBoxAddresLength.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.radioButtonYesAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonYesAddress.Location = new System.Drawing.Point(8, 52);
            this.radioButtonYesAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonYesAddress.Name = "radioButtonYesAddress";
            this.radioButtonYesAddress.Size = new System.Drawing.Size(51, 20);
            this.radioButtonYesAddress.TabIndex = 29;
            this.radioButtonYesAddress.TabStop = true;
            this.radioButtonYesAddress.Text = "Yes";
            this.radioButtonYesAddress.UseVisualStyleBackColor = true;
            this.radioButtonYesAddress.CheckedChanged += new System.EventHandler(this.radioButtonYesAddress_CheckedChanged);
            // 
            // radioButtonNoAddress
            // 
            this.radioButtonNoAddress.AutoSize = true;
            this.radioButtonNoAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonNoAddress.Location = new System.Drawing.Point(8, 23);
            this.radioButtonNoAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonNoAddress.Name = "radioButtonNoAddress";
            this.radioButtonNoAddress.Size = new System.Drawing.Size(45, 20);
            this.radioButtonNoAddress.TabIndex = 30;
            this.radioButtonNoAddress.Text = "No";
            this.radioButtonNoAddress.UseVisualStyleBackColor = true;
            this.radioButtonNoAddress.CheckedChanged += new System.EventHandler(this.radioButtonNoAddress_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.saveButton);
            this.tabPage2.Controls.Add(this.buttonRemoveScale);
            this.tabPage2.Controls.Add(this.buttonAddScale);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBoxScaleValues);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.seriesChange);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.RenameBox);
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
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1540, 631);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(113, 28);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save graphic";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // buttonRemoveScale
            // 
            this.buttonRemoveScale.Location = new System.Drawing.Point(741, 634);
            this.buttonRemoveScale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemoveScale.Name = "buttonRemoveScale";
            this.buttonRemoveScale.Size = new System.Drawing.Size(29, 28);
            this.buttonRemoveScale.TabIndex = 9;
            this.buttonRemoveScale.Text = "-";
            this.buttonRemoveScale.UseVisualStyleBackColor = true;
            this.buttonRemoveScale.Click += new System.EventHandler(this.buttonRemoveScale_Click);
            // 
            // buttonAddScale
            // 
            this.buttonAddScale.Location = new System.Drawing.Point(703, 634);
            this.buttonAddScale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddScale.Name = "buttonAddScale";
            this.buttonAddScale.Size = new System.Drawing.Size(31, 28);
            this.buttonAddScale.TabIndex = 8;
            this.buttonAddScale.Text = "+";
            this.buttonAddScale.UseVisualStyleBackColor = true;
            this.buttonAddScale.Click += new System.EventHandler(this.buttonAddScale_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(643, 617);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Scale:";
            // 
            // textBoxScaleValues
            // 
            this.textBoxScaleValues.Location = new System.Drawing.Point(643, 636);
            this.textBoxScaleValues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxScaleValues.Name = "textBoxScaleValues";
            this.textBoxScaleValues.ReadOnly = true;
            this.textBoxScaleValues.Size = new System.Drawing.Size(51, 22);
            this.textBoxScaleValues.TabIndex = 6;
            this.textBoxScaleValues.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 615);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Renaming:";
            // 
            // seriesChange
            // 
            this.seriesChange.Location = new System.Drawing.Point(189, 635);
            this.seriesChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seriesChange.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.seriesChange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seriesChange.Name = "seriesChange";
            this.seriesChange.Size = new System.Drawing.Size(160, 22);
            this.seriesChange.TabIndex = 4;
            this.seriesChange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seriesChange.ValueChanged += new System.EventHandler(this.seriesChange_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 635);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Rename";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RenameBox
            // 
            this.RenameBox.Location = new System.Drawing.Point(357, 635);
            this.RenameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RenameBox.Name = "RenameBox";
            this.RenameBox.Size = new System.Drawing.Size(168, 22);
            this.RenameBox.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 610);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 49);
            this.button3.TabIndex = 1;
            this.button3.Text = "Clear Graphic";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(677, 408);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(197, 109);
            this.button8.TabIndex = 53;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 706);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1721, 753);
            this.MinimumSize = new System.Drawing.Size(1721, 753);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDataBits)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDataAmount)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seriesChange)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown numericUpDownDataAmount;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RenameBox;
        private System.Windows.Forms.NumericUpDown seriesChange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAddScale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxScaleValues;
        private System.Windows.Forms.Button buttonRemoveScale;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClearRows;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button btnDeleteColumn;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.Button btnDeleteAllColumns;
        private System.Windows.Forms.TextBox txtRowName;
        private System.Windows.Forms.TextBox txtColumnName;
        private System.Windows.Forms.TextBox txtDeleteRow;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.CheckBox chkDeleteFirstOnly;
        private System.Windows.Forms.Button button8;
    }
}

