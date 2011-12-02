namespace Tip_Calculator
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.lblBill = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.lblPercent = new System.Windows.Forms.Label();
            this.cmbPercent = new System.Windows.Forms.ComboBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.mnuExit);
            this.mainMenu1.MenuItems.Add(this.mnuAbout);
            // 
            // lblBill
            // 
            this.lblBill.Location = new System.Drawing.Point(17, 19);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(56, 20);
            this.lblBill.Text = "Bill";
            this.lblBill.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(79, 18);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(134, 21);
            this.txtBill.TabIndex = 1;
            // 
            // lblPercent
            // 
            this.lblPercent.Location = new System.Drawing.Point(17, 56);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(56, 20);
            this.lblPercent.Text = "Percent";
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbPercent
            // 
            this.cmbPercent.Items.Add("1");
            this.cmbPercent.Items.Add("2");
            this.cmbPercent.Items.Add("3");
            this.cmbPercent.Items.Add("4");
            this.cmbPercent.Items.Add("5");
            this.cmbPercent.Items.Add("6");
            this.cmbPercent.Items.Add("7");
            this.cmbPercent.Items.Add("8");
            this.cmbPercent.Items.Add("9");
            this.cmbPercent.Items.Add("10");
            this.cmbPercent.Items.Add("11");
            this.cmbPercent.Items.Add("12");
            this.cmbPercent.Items.Add("13");
            this.cmbPercent.Items.Add("14");
            this.cmbPercent.Items.Add("15");
            this.cmbPercent.Items.Add("16");
            this.cmbPercent.Items.Add("17");
            this.cmbPercent.Items.Add("18");
            this.cmbPercent.Items.Add("19");
            this.cmbPercent.Items.Add("20");
            this.cmbPercent.Location = new System.Drawing.Point(79, 54);
            this.cmbPercent.Name = "cmbPercent";
            this.cmbPercent.Size = new System.Drawing.Size(134, 22);
            this.cmbPercent.TabIndex = 3;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(79, 91);
            this.txtTip.Name = "txtTip";
            this.txtTip.ReadOnly = true;
            this.txtTip.Size = new System.Drawing.Size(134, 21);
            this.txtTip.TabIndex = 4;
            // 
            // lblTip
            // 
            this.lblTip.Location = new System.Drawing.Point(17, 92);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(56, 20);
            this.lblTip.Text = "Tip";
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(148, 129);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(65, 20);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(79, 129);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 20);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.cmbPercent);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.lblBill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "frmMain";
            this.Text = "Tip Calculator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.ComboBox cmbPercent;
        private System.Windows.Forms.MenuItem mnuExit;
        private System.Windows.Forms.MenuItem mnuAbout;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
    }
}

