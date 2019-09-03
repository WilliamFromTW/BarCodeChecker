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
        public ScanBarCode()
        {
            InitializeComponent();
            con = this.aBAR_CODE_SCAN_HISTORYTableAdapter.Connection;
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
            string date  = DateTime.Now.ToString("MM月dd日 HH:mm:ss"); // includes leading zeros
            string date2 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // includes leading zeros
            System.Data.SqlClient.SqlCommand command = null;
         //   AddUpdateAppSettings("asdf","asdf");
            ReadSetting("asdf");
            if (ScanBarCodeTxt.Text.Length == Convert.ToInt32(BarCodeLength.Text.ToString()))
            {
                try
                {
                    DataSet ds = new DataSet();
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    //MessageBox.Show(listBox2.Text);
                    command = con.CreateCommand();
                    command.CommandText = "INSERT INTO BAR_CODE_SCAN_HISTORY(SN,LOG,STATUS,NOUSE) values ('" + this.ScanBarCodeTxt.Text + "','" + date + "','PASS','1')";
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
                        DataSet ds = new DataSet();
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        //MessageBox.Show(listBox2.Text);
                        command = con.CreateCommand();
                        command.CommandText = "INSERT INTO BAR_CODE_SCAN_HISTORY(SN,LOG,STATUS,NOUSE) values ('" + this.ScanBarCodeTxt.Text + "','" + date + "','FAIL','" + date2 + "')";
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
        static void ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                Console.WriteLine(result);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

    }

}
