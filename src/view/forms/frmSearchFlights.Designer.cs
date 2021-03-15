
namespace session_03.src.view.forms
{
    partial class frmSearchFlights
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchApply = new System.Windows.Forms.Button();
            this.dtpSearchReturn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpSearchOutbound = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rbntSearchOneWay = new System.Windows.Forms.RadioButton();
            this.rbntSearchReturn = new System.Windows.Forms.RadioButton();
            this.cmbxSearchCabinType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxSearchTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxSearchFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxSearchOutboundThreeDays = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxSearchReturnThreeDays = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudPassengersCount = new System.Windows.Forms.NumericUpDown();
            this.btnBookFlight = new System.Windows.Forms.Button();
            this.dgvOutboundFlights = new System.Windows.Forms.DataGridView();
            this.fromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightNumbersStrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopsNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outboundFlightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvReturnFlights = new System.Windows.Forms.DataGridView();
            this.returnFlightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fromDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightNumbersStrDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinPriceStrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopsNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassengersCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutboundFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outboundFlightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnFlightBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearchApply);
            this.groupBox1.Controls.Add(this.dtpSearchReturn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpSearchOutbound);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbntSearchOneWay);
            this.groupBox1.Controls.Add(this.rbntSearchReturn);
            this.groupBox1.Controls.Add(this.cmbxSearchCabinType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbxSearchTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbxSearchFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search parameters";
            // 
            // btnSearchApply
            // 
            this.btnSearchApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchApply.Image = global::session_03.Properties.Resources.icons8_search_20px;
            this.btnSearchApply.Location = new System.Drawing.Point(841, 76);
            this.btnSearchApply.Name = "btnSearchApply";
            this.btnSearchApply.Size = new System.Drawing.Size(120, 28);
            this.btnSearchApply.TabIndex = 12;
            this.btnSearchApply.Text = "Apply";
            this.btnSearchApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchApply.UseVisualStyleBackColor = true;
            // 
            // dtpSearchReturn
            // 
            this.dtpSearchReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSearchReturn.Checked = false;
            this.dtpSearchReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchReturn.Location = new System.Drawing.Point(616, 79);
            this.dtpSearchReturn.Name = "dtpSearchReturn";
            this.dtpSearchReturn.ShowCheckBox = true;
            this.dtpSearchReturn.Size = new System.Drawing.Size(180, 22);
            this.dtpSearchReturn.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Image = global::session_03.Properties.Resources.return_22px_2;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(540, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Return";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpSearchOutbound
            // 
            this.dtpSearchOutbound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpSearchOutbound.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchOutbound.Location = new System.Drawing.Point(331, 79);
            this.dtpSearchOutbound.Name = "dtpSearchOutbound";
            this.dtpSearchOutbound.Size = new System.Drawing.Size(178, 22);
            this.dtpSearchOutbound.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Image = global::session_03.Properties.Resources.outbound_22px;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(236, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Outbound";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbntSearchOneWay
            // 
            this.rbntSearchOneWay.Checked = true;
            this.rbntSearchOneWay.Location = new System.Drawing.Point(133, 78);
            this.rbntSearchOneWay.Name = "rbntSearchOneWay";
            this.rbntSearchOneWay.Size = new System.Drawing.Size(81, 24);
            this.rbntSearchOneWay.TabIndex = 7;
            this.rbntSearchOneWay.TabStop = true;
            this.rbntSearchOneWay.Text = "One way";
            this.rbntSearchOneWay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbntSearchOneWay.UseVisualStyleBackColor = true;
            // 
            // rbntSearchReturn
            // 
            this.rbntSearchReturn.Location = new System.Drawing.Point(9, 78);
            this.rbntSearchReturn.Name = "rbntSearchReturn";
            this.rbntSearchReturn.Size = new System.Drawing.Size(77, 24);
            this.rbntSearchReturn.TabIndex = 6;
            this.rbntSearchReturn.Text = "Return";
            this.rbntSearchReturn.UseVisualStyleBackColor = true;
            // 
            // cmbxSearchCabinType
            // 
            this.cmbxSearchCabinType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxSearchCabinType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSearchCabinType.FormattingEnabled = true;
            this.cmbxSearchCabinType.Location = new System.Drawing.Point(639, 33);
            this.cmbxSearchCabinType.Name = "cmbxSearchCabinType";
            this.cmbxSearchCabinType.Size = new System.Drawing.Size(322, 24);
            this.cmbxSearchCabinType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(555, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cabin type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbxSearchTo
            // 
            this.cmbxSearchTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbxSearchTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSearchTo.FormattingEnabled = true;
            this.cmbxSearchTo.Location = new System.Drawing.Point(293, 33);
            this.cmbxSearchTo.Name = "cmbxSearchTo";
            this.cmbxSearchTo.Size = new System.Drawing.Size(216, 24);
            this.cmbxSearchTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Location = new System.Drawing.Point(257, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbxSearchFrom
            // 
            this.cmbxSearchFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSearchFrom.FormattingEnabled = true;
            this.cmbxSearchFrom.Location = new System.Drawing.Point(56, 33);
            this.cmbxSearchFrom.Name = "cmbxSearchFrom";
            this.cmbxSearchFrom.Size = new System.Drawing.Size(158, 24);
            this.cmbxSearchFrom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Outbound flight details:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxSearchOutboundThreeDays
            // 
            this.cbxSearchOutboundThreeDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSearchOutboundThreeDays.Checked = true;
            this.cbxSearchOutboundThreeDays.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSearchOutboundThreeDays.Location = new System.Drawing.Point(760, 146);
            this.cbxSearchOutboundThreeDays.Name = "cbxSearchOutboundThreeDays";
            this.cbxSearchOutboundThreeDays.Size = new System.Drawing.Size(236, 24);
            this.cbxSearchOutboundThreeDays.TabIndex = 16;
            this.cbxSearchOutboundThreeDays.Text = "Display three days before and after";
            this.cbxSearchOutboundThreeDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxSearchOutboundThreeDays.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Return flight details:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxSearchReturnThreeDays
            // 
            this.cbxSearchReturnThreeDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSearchReturnThreeDays.Checked = true;
            this.cbxSearchReturnThreeDays.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSearchReturnThreeDays.Location = new System.Drawing.Point(760, 416);
            this.cbxSearchReturnThreeDays.Name = "cbxSearchReturnThreeDays";
            this.cbxSearchReturnThreeDays.Size = new System.Drawing.Size(236, 24);
            this.cbxSearchReturnThreeDays.TabIndex = 16;
            this.cbxSearchReturnThreeDays.Text = "Display three days before and after";
            this.cbxSearchReturnThreeDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxSearchReturnThreeDays.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(369, 695);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Passengers:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudPassengersCount
            // 
            this.nudPassengersCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudPassengersCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudPassengersCount.Location = new System.Drawing.Point(460, 695);
            this.nudPassengersCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudPassengersCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPassengersCount.Name = "nudPassengersCount";
            this.nudPassengersCount.Size = new System.Drawing.Size(53, 22);
            this.nudPassengersCount.TabIndex = 17;
            this.nudPassengersCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBookFlight
            // 
            this.btnBookFlight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBookFlight.Image = global::session_03.Properties.Resources.icons8_checkmark_20px_1;
            this.btnBookFlight.Location = new System.Drawing.Point(519, 692);
            this.btnBookFlight.Name = "btnBookFlight";
            this.btnBookFlight.Size = new System.Drawing.Size(103, 29);
            this.btnBookFlight.TabIndex = 13;
            this.btnBookFlight.Text = "Book flight";
            this.btnBookFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBookFlight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookFlight.UseVisualStyleBackColor = true;
            this.btnBookFlight.Click += new System.EventHandler(this.btnBookFlight_Click);
            // 
            // dgvOutboundFlights
            // 
            this.dgvOutboundFlights.AllowUserToAddRows = false;
            this.dgvOutboundFlights.AllowUserToDeleteRows = false;
            this.dgvOutboundFlights.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOutboundFlights.AutoGenerateColumns = false;
            this.dgvOutboundFlights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOutboundFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutboundFlights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromDataGridViewTextBoxColumn,
            this.toDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.flightNumbersStrDataGridViewTextBoxColumn,
            this.cabinPriceDataGridViewTextBoxColumn,
            this.stopsNumberDataGridViewTextBoxColumn});
            this.dgvOutboundFlights.DataSource = this.outboundFlightBindingSource;
            this.dgvOutboundFlights.Location = new System.Drawing.Point(12, 173);
            this.dgvOutboundFlights.MultiSelect = false;
            this.dgvOutboundFlights.Name = "dgvOutboundFlights";
            this.dgvOutboundFlights.ReadOnly = true;
            this.dgvOutboundFlights.RowHeadersVisible = false;
            this.dgvOutboundFlights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutboundFlights.Size = new System.Drawing.Size(984, 237);
            this.dgvOutboundFlights.TabIndex = 18;
            // 
            // fromDataGridViewTextBoxColumn
            // 
            this.fromDataGridViewTextBoxColumn.DataPropertyName = "From";
            this.fromDataGridViewTextBoxColumn.FillWeight = 40F;
            this.fromDataGridViewTextBoxColumn.HeaderText = "From";
            this.fromDataGridViewTextBoxColumn.Name = "fromDataGridViewTextBoxColumn";
            this.fromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toDataGridViewTextBoxColumn
            // 
            this.toDataGridViewTextBoxColumn.DataPropertyName = "To";
            this.toDataGridViewTextBoxColumn.FillWeight = 40F;
            this.toDataGridViewTextBoxColumn.HeaderText = "To";
            this.toDataGridViewTextBoxColumn.Name = "toDataGridViewTextBoxColumn";
            this.toDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.FillWeight = 50F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.FillWeight = 40F;
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flightNumbersStrDataGridViewTextBoxColumn
            // 
            this.flightNumbersStrDataGridViewTextBoxColumn.DataPropertyName = "FlightNumbersStr";
            this.flightNumbersStrDataGridViewTextBoxColumn.FillWeight = 110F;
            this.flightNumbersStrDataGridViewTextBoxColumn.HeaderText = "Flight number(s)";
            this.flightNumbersStrDataGridViewTextBoxColumn.Name = "flightNumbersStrDataGridViewTextBoxColumn";
            this.flightNumbersStrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cabinPriceDataGridViewTextBoxColumn
            // 
            this.cabinPriceDataGridViewTextBoxColumn.DataPropertyName = "CabinPriceStr";
            this.cabinPriceDataGridViewTextBoxColumn.FillWeight = 90F;
            this.cabinPriceDataGridViewTextBoxColumn.HeaderText = "Cabin price";
            this.cabinPriceDataGridViewTextBoxColumn.Name = "cabinPriceDataGridViewTextBoxColumn";
            this.cabinPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stopsNumberDataGridViewTextBoxColumn
            // 
            this.stopsNumberDataGridViewTextBoxColumn.DataPropertyName = "StopsNumber";
            this.stopsNumberDataGridViewTextBoxColumn.FillWeight = 70F;
            this.stopsNumberDataGridViewTextBoxColumn.HeaderText = "Stops number";
            this.stopsNumberDataGridViewTextBoxColumn.Name = "stopsNumberDataGridViewTextBoxColumn";
            this.stopsNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // outboundFlightBindingSource
            // 
            this.outboundFlightBindingSource.DataSource = typeof(session_03.src.logic.Flight);
            // 
            // dgvReturnFlights
            // 
            this.dgvReturnFlights.AllowUserToAddRows = false;
            this.dgvReturnFlights.AllowUserToDeleteRows = false;
            this.dgvReturnFlights.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReturnFlights.AutoGenerateColumns = false;
            this.dgvReturnFlights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReturnFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnFlights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromDataGridViewTextBoxColumn1,
            this.toDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn1,
            this.timeDataGridViewTextBoxColumn1,
            this.flightNumbersStrDataGridViewTextBoxColumn1,
            this.cabinPriceStrDataGridViewTextBoxColumn,
            this.stopsNumberDataGridViewTextBoxColumn1});
            this.dgvReturnFlights.DataSource = this.returnFlightBindingSource;
            this.dgvReturnFlights.Location = new System.Drawing.Point(12, 443);
            this.dgvReturnFlights.MultiSelect = false;
            this.dgvReturnFlights.Name = "dgvReturnFlights";
            this.dgvReturnFlights.ReadOnly = true;
            this.dgvReturnFlights.RowHeadersVisible = false;
            this.dgvReturnFlights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnFlights.Size = new System.Drawing.Size(984, 243);
            this.dgvReturnFlights.TabIndex = 19;
            // 
            // returnFlightBindingSource
            // 
            this.returnFlightBindingSource.DataSource = typeof(session_03.src.logic.Flight);
            // 
            // fromDataGridViewTextBoxColumn1
            // 
            this.fromDataGridViewTextBoxColumn1.DataPropertyName = "From";
            this.fromDataGridViewTextBoxColumn1.FillWeight = 40F;
            this.fromDataGridViewTextBoxColumn1.HeaderText = "From";
            this.fromDataGridViewTextBoxColumn1.Name = "fromDataGridViewTextBoxColumn1";
            this.fromDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // toDataGridViewTextBoxColumn1
            // 
            this.toDataGridViewTextBoxColumn1.DataPropertyName = "To";
            this.toDataGridViewTextBoxColumn1.FillWeight = 40F;
            this.toDataGridViewTextBoxColumn1.HeaderText = "To";
            this.toDataGridViewTextBoxColumn1.Name = "toDataGridViewTextBoxColumn1";
            this.toDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn1
            // 
            this.timeDataGridViewTextBoxColumn1.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn1.FillWeight = 40F;
            this.timeDataGridViewTextBoxColumn1.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn1.Name = "timeDataGridViewTextBoxColumn1";
            this.timeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // flightNumbersStrDataGridViewTextBoxColumn1
            // 
            this.flightNumbersStrDataGridViewTextBoxColumn1.DataPropertyName = "FlightNumbersStr";
            this.flightNumbersStrDataGridViewTextBoxColumn1.FillWeight = 110F;
            this.flightNumbersStrDataGridViewTextBoxColumn1.HeaderText = "Flight number(s)";
            this.flightNumbersStrDataGridViewTextBoxColumn1.Name = "flightNumbersStrDataGridViewTextBoxColumn1";
            this.flightNumbersStrDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cabinPriceStrDataGridViewTextBoxColumn
            // 
            this.cabinPriceStrDataGridViewTextBoxColumn.DataPropertyName = "CabinPriceStr";
            this.cabinPriceStrDataGridViewTextBoxColumn.FillWeight = 90F;
            this.cabinPriceStrDataGridViewTextBoxColumn.HeaderText = "Cabin price";
            this.cabinPriceStrDataGridViewTextBoxColumn.Name = "cabinPriceStrDataGridViewTextBoxColumn";
            this.cabinPriceStrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stopsNumberDataGridViewTextBoxColumn1
            // 
            this.stopsNumberDataGridViewTextBoxColumn1.DataPropertyName = "StopsNumber";
            this.stopsNumberDataGridViewTextBoxColumn1.FillWeight = 70F;
            this.stopsNumberDataGridViewTextBoxColumn1.HeaderText = "Stops number";
            this.stopsNumberDataGridViewTextBoxColumn1.Name = "stopsNumberDataGridViewTextBoxColumn1";
            this.stopsNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // frmSearchFlights
            // 
            this.AcceptButton = this.btnBookFlight;
            this.AccessibleDescription = " ";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.dgvReturnFlights);
            this.Controls.Add(this.dgvOutboundFlights);
            this.Controls.Add(this.nudPassengersCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBookFlight);
            this.Controls.Add(this.cbxSearchReturnThreeDays);
            this.Controls.Add(this.cbxSearchOutboundThreeDays);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(99999, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frmSearchFlights";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search for flights";
            this.Load += new System.EventHandler(this.frmSearchFlights_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPassengersCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutboundFlights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outboundFlightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnFlights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnFlightBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbntSearchOneWay;
        private System.Windows.Forms.RadioButton rbntSearchReturn;
        private System.Windows.Forms.ComboBox cmbxSearchCabinType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxSearchTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxSearchFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpSearchReturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpSearchOutbound;
        private System.Windows.Forms.Button btnSearchApply;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbxSearchOutboundThreeDays;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbxSearchReturnThreeDays;
        private System.Windows.Forms.Button btnBookFlight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudPassengersCount;
        private System.Windows.Forms.DataGridView dgvOutboundFlights;
        private System.Windows.Forms.BindingSource outboundFlightBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNumbersStrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopsNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvReturnFlights;
        private System.Windows.Forms.BindingSource returnFlightBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNumbersStrDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinPriceStrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopsNumberDataGridViewTextBoxColumn1;
    }
}