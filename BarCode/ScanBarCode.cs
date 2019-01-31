using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BarCode
{
    public partial class ScanBarCode : Form
    {
        OleDbConnection con = null;
        public ScanBarCode()
        {
            InitializeComponent();
            con = this.bAR_CODE_SCAN_HISTORYTableAdapter.Connection;
            Closing += new CancelEventHandler(ScanBarCode_Closing);
        }

        private void ScanBarCode_Load(object sender, EventArgs e)
        {
            this.ActiveControl = ScanBarCodeTxt;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = ScanBarCodeTxt;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ScanBarCodeTxt_TextChanged(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"); // includes leading zeros
            OleDbCommand command = null;
            if (ScanBarCodeTxt.Text.Length == Convert.ToInt32(BarCodeLength.Text.ToString()))
            {
                try
                {
                    DataSet ds = new DataSet();
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    //MessageBox.Show(listBox2.Text);
                    command = new OleDbCommand("INSERT INTO BAR_CODE_SCAN_HISTORY(SN,LOG) values ('" + this.ScanBarCodeTxt.Text + "','" + date + "')", con);
                    command.ExecuteNonQuery();
                    this.textResult.ForeColor = Color.Blue;
                    this.textResultStatus.ForeColor = Color.Blue;
                    this.textResult.Text =  "檢查 "+ this.ScanBarCodeTxt.Text + " ...";
                    this.textResultStatus.Text = "PASS!";
                    ScanBarCodeTxt.Text = "";
                    ScanBarCodeTxt.Focus();
                }
                catch (Exception ex)
                {

                    ScanBarCodeTxt.Text = "";
                    ScanBarCodeTxt.Focus();
                    this.textResult.ForeColor = Color.Red;
                    this.textResultStatus.ForeColor = Color.Red;
                    this.textResult.Text = "檢查 " + this.ScanBarCodeTxt.Text + " ...";
                    this.textResultStatus.Text = "FAIL!";
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BarCodeLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ScanBarCode_Closing(object sender, CancelEventArgs e)

        {
            try
            {
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception ee)
            {

            }
        }
    }

}
