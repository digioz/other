////////////////////////////////////////////
/// Application Name: Tip Calculator
///  Target Platform: Pocket PC
///        Copyright: DigiOz Multimedia
///           Author: Pedram Soheil
///             Date: 10/05/2007
///          Website: http://www.digioz.com
////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tip_Calculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function to Determine if string is numeric or not
        /// </summary>
        /// <param name="s">string</param>
        /// <returns></returns>
        public bool IsNumeric(string s)
        {
            try
            {
                Double.Parse(s);
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Function To Reset All Fields
        /// </summary> 
        public void resetfields()
        {
            cmbPercent.SelectedItem = "15";
            txtBill.Text = "";
            txtTip.Text = "";
            txtBill.Focus();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            resetfields();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright 2007\nDigiOz Multimedia\nwww.digioz.com");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double ldBill, ldPercent, ldTip = 0.00;

            if (IsNumeric(txtBill.Text)== true)
            {
                ldBill = Double.Parse(txtBill.Text);
                ldPercent = Double.Parse(cmbPercent.Text) / 100;
                ldTip = ldBill * ldPercent;

                txtTip.Text = ldTip.ToString("N2");
            }
            else
            {
                resetfields();
            }                    
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetfields();
        }
    }
}