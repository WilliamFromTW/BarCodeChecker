using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace BarCode
{
    public partial class ScanBarCode : Form
    {
        System.Data.SqlClient.SqlConnection con = null;
        System.Data.SqlClient.SqlCommand command = null;
        public ScanBarCode()
        {
            InitializeComponent();
            
            Closing += new CancelEventHandler(ScanBarCode_Closing);
        }

        private void ScanBarCode_Load(object sender, EventArgs e)
        {
            this.ActiveControl = ScanBarCodeTxt;
            textWorkStationNumber.Text = Program.ReadSetting("WorkStationNumber");
            BarCodeLength.Text = Program.ReadSetting("BarCodeLength");
            aBAR_CODE_SCAN_HISTORYTableAdapter.Connection.ConnectionString = "Data Source=" + Program.ReadSetting("IP") +
                ";Initial Catalog=" + Program.ReadSetting("DB") + ";Persist Security Info=True;User ID=" +
                Program.ReadSetting("UID") + ";Password=" +
                Program.ReadSetting("PWD");
            con = this.aBAR_CODE_SCAN_HISTORYTableAdapter.Connection;
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("DB connection failed! Check Database Settings");
                    Close();
                }
            }
            //MessageBox.Show(listBox2.Text);

            command = con.CreateCommand();

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
            string date  = DateTime.Now.ToString("MM月dd日 HH:mm:ss"); // includes leading zeros
            string date2 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // includes leading zeros
            
        
            if (ScanBarCodeTxt.Text.Length == Convert.ToInt32(BarCodeLength.Text.ToString()))
            {
                try
                {
                    command.CommandText = "INSERT INTO BAR_CODE_SCAN_HISTORY(WORKSTATION_NUMBER,SN,LOG,STATUS,MEMO) values ('" + Program.ReadSetting("WorkStationNumber")+"','"+ this.ScanBarCodeTxt.Text + "','" + date + "','PASS','1')";
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
                    try
                    {
                        this.textResult.ForeColor = Color.Red;
                        this.textResultStatus.ForeColor = Color.Red;
                        this.textResult.Text = "檢查 " + this.ScanBarCodeTxt.Text + " ...";
                        this.textResultStatus.Text = "FAIL!";
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        //MessageBox.Show(listBox2.Text);
                        command = con.CreateCommand();
                        command.CommandText = "INSERT INTO BAR_CODE_SCAN_HISTORY(WORKSTATION_NUMBER,SN,LOG,STATUS,MEMO) values ('" + Program.ReadSetting("WorkStationNumber") + "','"+ this.ScanBarCodeTxt.Text + "','" + date + "','FAIL','" + date2 + "')";
                        command.ExecuteNonQuery();
                        ScanBarCodeTxt.Text = "";
                        ScanBarCodeTxt.Focus();
                    }catch(Exception ex2)
                    {
                        ScanBarCodeTxt.Text = "";
                        ScanBarCodeTxt.Focus();
                    }

                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BarCodeLength_TextChanged(object sender, EventArgs e)
        {
            Program.AddUpdateAppSettings("BarCodeLength", BarCodeLength.Text);
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

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextWorkStationNumber_TextChanged(object sender, EventArgs e)
        {
            Program.AddUpdateAppSettings("WorkStationNumber", textWorkStationNumber.Text );
        }
    }

}
