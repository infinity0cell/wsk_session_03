
namespace session_03.src.view.forms
{
    partial class frmBooking
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
            this.lblOutboundFlightNumbers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOutboundCabinType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOutboundTo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOutboundFrom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPassengers = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtbxPhone = new System.Windows.Forms.MaskedTextBox();
            this.tbxLastname = new System.Windows.Forms.TextBox();
            this.tbxFirstname = new System.Windows.Forms.TextBox();
            this.tbxPassportNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddPassenger = new System.Windows.Forms.Button();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbxPassportCountry = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblReturnFlightNumbers = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblReturnCabinType = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblReturnTo = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblReturnFrom = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnRemovePassenger = new System.Windows.Forms.Button();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.passengerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportCountryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblOutboundFlightNumbers);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblOutboundCabinType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblOutboundTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblOutboundFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outbound flight details";
            // 
            // lblOutboundFlightNumbers
            // 
            this.lblOutboundFlightNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOutboundFlightNumbers.Location = new System.Drawing.Point(655, 20);
            this.lblOutboundFlightNumbers.Name = "lblOutboundFlightNumbers";
            this.lblOutboundFlightNumbers.Size = new System.Drawing.Size(158, 24);
            this.lblOutboundFlightNumbers.TabIndex = 5;
            this.lblOutboundFlightNumbers.Text = "Flight number";
            this.lblOutboundFlightNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(549, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Flight number(s):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutboundCabinType
            // 
            this.lblOutboundCabinType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOutboundCabinType.Location = new System.Drawing.Point(412, 20);
            this.lblOutboundCabinType.Name = "lblOutboundCabinType";
            this.lblOutboundCabinType.Size = new System.Drawing.Size(116, 24);
            this.lblOutboundCabinType.TabIndex = 4;
            this.lblOutboundCabinType.Text = "Cabin type";
            this.lblOutboundCabinType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(328, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cabin type:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutboundTo
            // 
            this.lblOutboundTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOutboundTo.Location = new System.Drawing.Point(220, 20);
            this.lblOutboundTo.Name = "lblOutboundTo";
            this.lblOutboundTo.Size = new System.Drawing.Size(78, 24);
            this.lblOutboundTo.TabIndex = 2;
            this.lblOutboundTo.Text = "To";
            this.lblOutboundTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(184, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutboundFrom
            // 
            this.lblOutboundFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOutboundFrom.Location = new System.Drawing.Point(56, 20);
            this.lblOutboundFrom.Name = "lblOutboundFrom";
            this.lblOutboundFrom.Size = new System.Drawing.Size(93, 24);
            this.lblOutboundFrom.TabIndex = 0;
            this.lblOutboundFrom.Text = "From";
            this.lblOutboundFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Passengers list:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvPassengers
            // 
            this.dgvPassengers.AllowUserToAddRows = false;
            this.dgvPassengers.AllowUserToDeleteRows = false;
            this.dgvPassengers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPassengers.AutoGenerateColumns = false;
            this.dgvPassengers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPassengers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassengers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.passportNumberDataGridViewTextBoxColumn,
            this.passportCountryIdDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dgvPassengers.DataSource = this.passengerBindingSource;
            this.dgvPassengers.Location = new System.Drawing.Point(9, 284);
            this.dgvPassengers.MultiSelect = false;
            this.dgvPassengers.Name = "dgvPassengers";
            this.dgvPassengers.ReadOnly = true;
            this.dgvPassengers.RowHeadersVisible = false;
            this.dgvPassengers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassengers.Size = new System.Drawing.Size(984, 163);
            this.dgvPassengers.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.mtbxPhone);
            this.groupBox2.Controls.Add(this.tbxLastname);
            this.groupBox2.Controls.Add(this.tbxFirstname);
            this.groupBox2.Controls.Add(this.tbxPassportNumber);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnAddPassenger);
            this.groupBox2.Controls.Add(this.dtpBirthdate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmbxPassportCountry);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 110);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Passengers details";
            // 
            // mtbxPhone
            // 
            this.mtbxPhone.Location = new System.Drawing.Point(614, 78);
            this.mtbxPhone.Mask = "(999) 000-0000";
            this.mtbxPhone.Name = "mtbxPhone";
            this.mtbxPhone.Size = new System.Drawing.Size(191, 22);
            this.mtbxPhone.TabIndex = 18;
            // 
            // tbxLastname
            // 
            this.tbxLastname.Location = new System.Drawing.Point(331, 33);
            this.tbxLastname.Name = "tbxLastname";
            this.tbxLastname.Size = new System.Drawing.Size(197, 22);
            this.tbxLastname.TabIndex = 17;
            // 
            // tbxFirstname
            // 
            this.tbxFirstname.Location = new System.Drawing.Point(84, 33);
            this.tbxFirstname.Name = "tbxFirstname";
            this.tbxFirstname.Size = new System.Drawing.Size(141, 22);
            this.tbxFirstname.TabIndex = 16;
            // 
            // tbxPassportNumber
            // 
            this.tbxPassportNumber.Location = new System.Drawing.Point(125, 78);
            this.tbxPassportNumber.Name = "tbxPassportNumber";
            this.tbxPassportNumber.Size = new System.Drawing.Size(100, 22);
            this.tbxPassportNumber.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Passport number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddPassenger
            // 
            this.btnAddPassenger.Location = new System.Drawing.Point(841, 77);
            this.btnAddPassenger.Name = "btnAddPassenger";
            this.btnAddPassenger.Size = new System.Drawing.Size(120, 24);
            this.btnAddPassenger.TabIndex = 12;
            this.btnAddPassenger.Text = "Add passenger";
            this.btnAddPassenger.UseVisualStyleBackColor = true;
            this.btnAddPassenger.Click += new System.EventHandler(this.btnAddPassenger_Click);
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdate.Location = new System.Drawing.Point(625, 33);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(180, 22);
            this.dtpBirthdate.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(555, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Phone";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(257, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Passport country";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(555, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "Birthdate";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(257, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "Lastname";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbxPassportCountry
            // 
            this.cmbxPassportCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPassportCountry.FormattingEnabled = true;
            this.cmbxPassportCountry.Location = new System.Drawing.Point(370, 77);
            this.cmbxPassportCountry.Name = "cmbxPassportCountry";
            this.cmbxPassportCountry.Size = new System.Drawing.Size(158, 24);
            this.cmbxPassportCountry.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Firstname";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lblReturnFlightNumbers);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.lblReturnCabinType);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.lblReturnTo);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.lblReturnFrom);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Location = new System.Drawing.Point(12, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(984, 60);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Return flight details";
            // 
            // lblReturnFlightNumbers
            // 
            this.lblReturnFlightNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReturnFlightNumbers.Location = new System.Drawing.Point(655, 20);
            this.lblReturnFlightNumbers.Name = "lblReturnFlightNumbers";
            this.lblReturnFlightNumbers.Size = new System.Drawing.Size(158, 24);
            this.lblReturnFlightNumbers.TabIndex = 5;
            this.lblReturnFlightNumbers.Text = "- - -";
            this.lblReturnFlightNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(549, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 24);
            this.label18.TabIndex = 5;
            this.label18.Text = "Flight number(s):";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReturnCabinType
            // 
            this.lblReturnCabinType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReturnCabinType.Location = new System.Drawing.Point(412, 20);
            this.lblReturnCabinType.Name = "lblReturnCabinType";
            this.lblReturnCabinType.Size = new System.Drawing.Size(116, 24);
            this.lblReturnCabinType.TabIndex = 4;
            this.lblReturnCabinType.Text = "- - -";
            this.lblReturnCabinType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(328, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 24);
            this.label20.TabIndex = 4;
            this.label20.Text = "Cabin type:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReturnTo
            // 
            this.lblReturnTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReturnTo.Location = new System.Drawing.Point(220, 20);
            this.lblReturnTo.Name = "lblReturnTo";
            this.lblReturnTo.Size = new System.Drawing.Size(78, 24);
            this.lblReturnTo.TabIndex = 2;
            this.lblReturnTo.Text = "- - -";
            this.lblReturnTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(184, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 24);
            this.label22.TabIndex = 2;
            this.label22.Text = "To:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReturnFrom
            // 
            this.lblReturnFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReturnFrom.Location = new System.Drawing.Point(56, 20);
            this.lblReturnFrom.Name = "lblReturnFrom";
            this.lblReturnFrom.Size = new System.Drawing.Size(93, 24);
            this.lblReturnFrom.TabIndex = 0;
            this.lblReturnFrom.Text = "- - -";
            this.lblReturnFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(6, 20);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 24);
            this.label24.TabIndex = 0;
            this.label24.Text = "From:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRemovePassenger
            // 
            this.btnRemovePassenger.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemovePassenger.Location = new System.Drawing.Point(851, 453);
            this.btnRemovePassenger.Name = "btnRemovePassenger";
            this.btnRemovePassenger.Size = new System.Drawing.Size(142, 25);
            this.btnRemovePassenger.TabIndex = 16;
            this.btnRemovePassenger.Text = "Remove passenger";
            this.btnRemovePassenger.UseVisualStyleBackColor = true;
            this.btnRemovePassenger.Click += new System.EventHandler(this.btnRemovePassenger_Click);
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmBooking.Image = global::session_03.Properties.Resources.icons8_checkmark_20px_1;
            this.btnConfirmBooking.Location = new System.Drawing.Point(540, 483);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(157, 31);
            this.btnConfirmBooking.TabIndex = 13;
            this.btnConfirmBooking.Text = "Confirm booking";
            this.btnConfirmBooking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.Image = global::session_03.Properties.Resources.icons8_restore_20px;
            this.btnBack.Location = new System.Drawing.Point(311, 483);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(223, 31);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back to search for flights";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // passengerBindingSource
            // 
            this.passengerBindingSource.DataSource = typeof(session_03.src.logic.Passenger);
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passportNumberDataGridViewTextBoxColumn
            // 
            this.passportNumberDataGridViewTextBoxColumn.DataPropertyName = "PassportNumber";
            this.passportNumberDataGridViewTextBoxColumn.HeaderText = "Passport number";
            this.passportNumberDataGridViewTextBoxColumn.Name = "passportNumberDataGridViewTextBoxColumn";
            this.passportNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passportCountryIdDataGridViewTextBoxColumn
            // 
            this.passportCountryIdDataGridViewTextBoxColumn.DataPropertyName = "PassportCountry";
            this.passportCountryIdDataGridViewTextBoxColumn.HeaderText = "Passport country";
            this.passportCountryIdDataGridViewTextBoxColumn.Name = "passportCountryIdDataGridViewTextBoxColumn";
            this.passportCountryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmBooking
            // 
            this.AcceptButton = this.btnAddPassenger;
            this.AccessibleDescription = " ";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 526);
            this.Controls.Add(this.btnRemovePassenger);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnConfirmBooking);
            this.Controls.Add(this.dgvPassengers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 565);
            this.Name = "frmBooking";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking confirmation";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPassengers;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddPassenger;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbxPassportCountry;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblOutboundFlightNumbers;
        private System.Windows.Forms.Label lblOutboundCabinType;
        private System.Windows.Forms.Label lblOutboundTo;
        private System.Windows.Forms.Label lblOutboundFrom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblReturnFlightNumbers;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblReturnCabinType;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblReturnTo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblReturnFrom;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxLastname;
        private System.Windows.Forms.TextBox tbxFirstname;
        private System.Windows.Forms.TextBox tbxPassportNumber;
        private System.Windows.Forms.MaskedTextBox mtbxPhone;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRemovePassenger;
        private System.Windows.Forms.BindingSource passengerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportCountryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}