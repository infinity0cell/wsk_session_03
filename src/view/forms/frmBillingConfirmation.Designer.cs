
namespace session_03.src.view.forms
{
    partial class frmBillingConfirmation
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
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.rbtnCreditCard = new System.Windows.Forms.RadioButton();
            this.rbtnVoucher = new System.Windows.Forms.RadioButton();
            this.btnIssueTickets = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total amount: $";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalAmount.Location = new System.Drawing.Point(120, 9);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(114, 24);
            this.lblTotalAmount.TabIndex = 6;
            this.lblTotalAmount.Text = "123456";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Paid using:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbtnCash
            // 
            this.rbtnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnCash.Location = new System.Drawing.Point(120, 74);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(114, 24);
            this.rbtnCash.TabIndex = 18;
            this.rbtnCash.Text = "Cash";
            this.rbtnCash.UseVisualStyleBackColor = true;
            // 
            // rbtnCreditCard
            // 
            this.rbtnCreditCard.Checked = true;
            this.rbtnCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnCreditCard.Location = new System.Drawing.Point(120, 44);
            this.rbtnCreditCard.Name = "rbtnCreditCard";
            this.rbtnCreditCard.Size = new System.Drawing.Size(114, 24);
            this.rbtnCreditCard.TabIndex = 17;
            this.rbtnCreditCard.TabStop = true;
            this.rbtnCreditCard.Text = "Credit card";
            this.rbtnCreditCard.UseVisualStyleBackColor = true;
            // 
            // rbtnVoucher
            // 
            this.rbtnVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnVoucher.Location = new System.Drawing.Point(120, 103);
            this.rbtnVoucher.Name = "rbtnVoucher";
            this.rbtnVoucher.Size = new System.Drawing.Size(114, 24);
            this.rbtnVoucher.TabIndex = 19;
            this.rbtnVoucher.Text = "Voucher";
            this.rbtnVoucher.UseVisualStyleBackColor = true;
            // 
            // btnIssueTickets
            // 
            this.btnIssueTickets.Image = global::session_03.Properties.Resources.icons8_checkmark_yes_20px;
            this.btnIssueTickets.Location = new System.Drawing.Point(13, 133);
            this.btnIssueTickets.Name = "btnIssueTickets";
            this.btnIssueTickets.Size = new System.Drawing.Size(142, 30);
            this.btnIssueTickets.TabIndex = 15;
            this.btnIssueTickets.Text = "Issue tickets";
            this.btnIssueTickets.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssueTickets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIssueTickets.UseVisualStyleBackColor = true;
            this.btnIssueTickets.Click += new System.EventHandler(this.btnIssueTickets_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::session_03.Properties.Resources.icons8_cancel_20px;
            this.btnCancel.Location = new System.Drawing.Point(161, 134);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmBillingConfirmation
            // 
            this.AcceptButton = this.btnIssueTickets;
            this.AccessibleDescription = " ";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(316, 171);
            this.Controls.Add(this.rbtnVoucher);
            this.Controls.Add(this.rbtnCash);
            this.Controls.Add(this.rbtnCreditCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIssueTickets);
            this.Controls.Add(this.btnCancel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBillingConfirmation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing confirmation";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnIssueTickets;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.RadioButton rbtnCreditCard;
        private System.Windows.Forms.RadioButton rbtnVoucher;
    }
}