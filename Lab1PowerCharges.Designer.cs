namespace Lab1PowerCharges
{
    partial class Lab1PowerCharges
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
            this.lblKwh = new System.Windows.Forms.Label();
            this.txtKwhResComm = new System.Windows.Forms.TextBox();
            this.lblTotalCharges = new System.Windows.Forms.Label();
            this.txtTotalCharges = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rdoResidential = new System.Windows.Forms.RadioButton();
            this.rdoIndustrial = new System.Windows.Forms.RadioButton();
            this.rdoCommercial = new System.Windows.Forms.RadioButton();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.pnlResidentialCommercial = new System.Windows.Forms.Panel();
            this.pnlIndustrial = new System.Windows.Forms.Panel();
            this.txtKwhIndOffPeak = new System.Windows.Forms.TextBox();
            this.txtKwhIndPeak = new System.Windows.Forms.TextBox();
            this.lblIndustrialOffPeak = new System.Windows.Forms.Label();
            this.lblIndustrialPeak = new System.Windows.Forms.Label();
            this.pnlResidentialCommercial.SuspendLayout();
            this.pnlIndustrial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKwh
            // 
            this.lblKwh.AutoSize = true;
            this.lblKwh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKwh.Location = new System.Drawing.Point(25, 29);
            this.lblKwh.Name = "lblKwh";
            this.lblKwh.Size = new System.Drawing.Size(158, 25);
            this.lblKwh.TabIndex = 0;
            this.lblKwh.Text = "Enter kwH Used:";
            // 
            // txtKwhResComm
            // 
            this.txtKwhResComm.Location = new System.Drawing.Point(257, 29);
            this.txtKwhResComm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKwhResComm.Name = "txtKwhResComm";
            this.txtKwhResComm.Size = new System.Drawing.Size(143, 22);
            this.txtKwhResComm.TabIndex = 1;
            this.txtKwhResComm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalCharges
            // 
            this.lblTotalCharges.AutoSize = true;
            this.lblTotalCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCharges.Location = new System.Drawing.Point(211, 450);
            this.lblTotalCharges.Name = "lblTotalCharges";
            this.lblTotalCharges.Size = new System.Drawing.Size(142, 25);
            this.lblTotalCharges.TabIndex = 2;
            this.lblTotalCharges.Text = "Total Charges:";
            // 
            // txtTotalCharges
            // 
            this.txtTotalCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCharges.Location = new System.Drawing.Point(385, 450);
            this.txtTotalCharges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalCharges.Name = "txtTotalCharges";
            this.txtTotalCharges.ReadOnly = true;
            this.txtTotalCharges.Size = new System.Drawing.Size(143, 30);
            this.txtTotalCharges.TabIndex = 3;
            this.txtTotalCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(138, 347);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(183, 49);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(359, 347);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 49);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(578, 347);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 49);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rdoResidential
            // 
            this.rdoResidential.AutoSize = true;
            this.rdoResidential.Checked = true;
            this.rdoResidential.Location = new System.Drawing.Point(105, 59);
            this.rdoResidential.Name = "rdoResidential";
            this.rdoResidential.Size = new System.Drawing.Size(99, 21);
            this.rdoResidential.TabIndex = 7;
            this.rdoResidential.TabStop = true;
            this.rdoResidential.Text = "Residential";
            this.rdoResidential.UseVisualStyleBackColor = true;
            this.rdoResidential.CheckedChanged += new System.EventHandler(this.rdoResidential_CheckedChanged);
            // 
            // rdoIndustrial
            // 
            this.rdoIndustrial.AutoSize = true;
            this.rdoIndustrial.Location = new System.Drawing.Point(389, 59);
            this.rdoIndustrial.Name = "rdoIndustrial";
            this.rdoIndustrial.Size = new System.Drawing.Size(86, 21);
            this.rdoIndustrial.TabIndex = 8;
            this.rdoIndustrial.Text = "Industrial";
            this.rdoIndustrial.UseVisualStyleBackColor = true;
            this.rdoIndustrial.CheckedChanged += new System.EventHandler(this.rdoIndustrial_CheckedChanged);
            // 
            // rdoCommercial
            // 
            this.rdoCommercial.AutoSize = true;
            this.rdoCommercial.Location = new System.Drawing.Point(251, 59);
            this.rdoCommercial.Name = "rdoCommercial";
            this.rdoCommercial.Size = new System.Drawing.Size(102, 21);
            this.rdoCommercial.TabIndex = 9;
            this.rdoCommercial.Text = "Commercial";
            this.rdoCommercial.UseVisualStyleBackColor = true;
            this.rdoCommercial.CheckedChanged += new System.EventHandler(this.rdoCommercial_CheckedChanged);
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.Location = new System.Drawing.Point(89, 23);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(219, 23);
            this.lblCustomerType.TabIndex = 10;
            this.lblCustomerType.Text = "Select customer type";
            // 
            // pnlResidentialCommercial
            // 
            this.pnlResidentialCommercial.Controls.Add(this.lblKwh);
            this.pnlResidentialCommercial.Controls.Add(this.txtKwhResComm);
            this.pnlResidentialCommercial.Location = new System.Drawing.Point(75, 95);
            this.pnlResidentialCommercial.Name = "pnlResidentialCommercial";
            this.pnlResidentialCommercial.Size = new System.Drawing.Size(453, 84);
            this.pnlResidentialCommercial.TabIndex = 11;
            // 
            // pnlIndustrial
            // 
            this.pnlIndustrial.Controls.Add(this.txtKwhIndOffPeak);
            this.pnlIndustrial.Controls.Add(this.txtKwhIndPeak);
            this.pnlIndustrial.Controls.Add(this.lblIndustrialOffPeak);
            this.pnlIndustrial.Controls.Add(this.lblIndustrialPeak);
            this.pnlIndustrial.Location = new System.Drawing.Point(75, 185);
            this.pnlIndustrial.Name = "pnlIndustrial";
            this.pnlIndustrial.Size = new System.Drawing.Size(602, 144);
            this.pnlIndustrial.TabIndex = 12;
            this.pnlIndustrial.Visible = false;
            // 
            // txtKwhIndOffPeak
            // 
            this.txtKwhIndOffPeak.Location = new System.Drawing.Point(416, 67);
            this.txtKwhIndOffPeak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKwhIndOffPeak.Name = "txtKwhIndOffPeak";
            this.txtKwhIndOffPeak.Size = new System.Drawing.Size(143, 22);
            this.txtKwhIndOffPeak.TabIndex = 2;
            this.txtKwhIndOffPeak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKwhIndPeak
            // 
            this.txtKwhIndPeak.Location = new System.Drawing.Point(416, 16);
            this.txtKwhIndPeak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKwhIndPeak.Name = "txtKwhIndPeak";
            this.txtKwhIndPeak.Size = new System.Drawing.Size(143, 22);
            this.txtKwhIndPeak.TabIndex = 3;
            this.txtKwhIndPeak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIndustrialOffPeak
            // 
            this.lblIndustrialOffPeak.AutoSize = true;
            this.lblIndustrialOffPeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndustrialOffPeak.Location = new System.Drawing.Point(25, 66);
            this.lblIndustrialOffPeak.Name = "lblIndustrialOffPeak";
            this.lblIndustrialOffPeak.Size = new System.Drawing.Size(360, 25);
            this.lblIndustrialOffPeak.TabIndex = 4;
            this.lblIndustrialOffPeak.Text = "Enter kwH Used During Off-Peak Hours:";
            // 
            // lblIndustrialPeak
            // 
            this.lblIndustrialPeak.AutoSize = true;
            this.lblIndustrialPeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndustrialPeak.Location = new System.Drawing.Point(25, 16);
            this.lblIndustrialPeak.Name = "lblIndustrialPeak";
            this.lblIndustrialPeak.Size = new System.Drawing.Size(327, 25);
            this.lblIndustrialPeak.TabIndex = 2;
            this.lblIndustrialPeak.Text = "Enter kwH Used During Peak Hours:";
            // 
            // Lab1PowerCharges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(935, 620);
            this.Controls.Add(this.pnlIndustrial);
            this.Controls.Add(this.pnlResidentialCommercial);
            this.Controls.Add(this.lblCustomerType);
            this.Controls.Add(this.rdoCommercial);
            this.Controls.Add(this.rdoIndustrial);
            this.Controls.Add(this.rdoResidential);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotalCharges);
            this.Controls.Add(this.lblTotalCharges);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lab1PowerCharges";
            this.Text = "Power Bill Calculations";
            this.Load += new System.EventHandler(this.Lab1PowerCharges_Load);
            this.pnlResidentialCommercial.ResumeLayout(false);
            this.pnlResidentialCommercial.PerformLayout();
            this.pnlIndustrial.ResumeLayout(false);
            this.pnlIndustrial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKwh;
        private System.Windows.Forms.TextBox txtKwhResComm;
        private System.Windows.Forms.Label lblTotalCharges;
        private System.Windows.Forms.TextBox txtTotalCharges;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdoResidential;
        private System.Windows.Forms.RadioButton rdoIndustrial;
        private System.Windows.Forms.RadioButton rdoCommercial;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Panel pnlResidentialCommercial;
        private System.Windows.Forms.Panel pnlIndustrial;
        private System.Windows.Forms.TextBox txtKwhIndOffPeak;
        private System.Windows.Forms.TextBox txtKwhIndPeak;
        private System.Windows.Forms.Label lblIndustrialOffPeak;
        private System.Windows.Forms.Label lblIndustrialPeak;
    }
}

