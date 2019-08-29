using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarCode
{
    public partial class BarCodeMain : Form
    {
        public BarCodeMain()
        {
            InitializeComponent();
        }

        private void BarCodeMain_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'storageDataSet.BAR_CODE_SCAN_HISTORY' 資料表。您可以視需要進行移動或移除。
            this.bAR_CODE_SCAN_HISTORYTableAdapter.Fill(this.storageDataSet.BAR_CODE_SCAN_HISTORY);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MaintainProductInfo().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ScanBarCode().Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new BarCodeScanHistory().Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("資料庫存放在("+ getDatabasePath() + ")\n備份資料前, 請關閉\"檢測條碼視窗\"", "備份", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                Backup();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        private String getDatabasePath()
        {
            string dbFileName = "storage.mdb";
            string CurrentDatabasePath = null;
            if (AppDomain.CurrentDomain.GetData("DataDirectory") != null)
                CurrentDatabasePath = System.IO.Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), dbFileName);
            else
                CurrentDatabasePath = ".\\" + dbFileName;
            return CurrentDatabasePath;
        }
        private void Backup()
        {
            string dbFileName = "storage.mdb";
            string CurrentDatabasePath = null;

            CurrentDatabasePath = getDatabasePath();

            string destFileName = DateTime.Now.ToString("yyyy_MM_dd_HHmm") +"-" + dbFileName;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string PathtobackUp = fbd.SelectedPath.ToString();
                destFileName = System.IO.Path.Combine(PathtobackUp, destFileName);
                File.Copy(CurrentDatabasePath, destFileName, true);
                MessageBox.Show("successful Backup! Backup File Name is " + destFileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection con = null;
            OleDbCommand command = null;
            InputBoxValidation validation = delegate (string val) {
                if (val == "")
                    return "Value cannot be empty.";
                if (!val.Equals("zuojian"))
                    return "password is not correct!";
                else
                return "";
            };
            string value = "info@example.com";
            if (InputBox.Show("請輸入密碼後刪除資料", "密碼:", ref value, validation) == DialogResult.OK)
            {


            DialogResult dialogResult = MessageBox.Show("刪除資料之前,請先備份,以及關閉\"檢測條碼視窗\"\r\n確定刪除嗎?", "刪除資料", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    con = this.bAR_CODE_SCAN_HISTORYTableAdapter.Connection;
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    command = new OleDbCommand("DELETE FROM BAR_CODE_SCAN_HISTORY", con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Delete Successful");
                    if (con != null && con.State == ConnectionState.Open)
                        con.Close();
                }
                catch (Exception eeee)
                {
                    if (con != null && con.State == ConnectionState.Open)
                        con.Close();

                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            }

        }

        private void linkWebSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url;
            if (e.Link.LinkData != null)
                url = e.Link.LinkData.ToString();
            else
                url = linkWebSite.Text.Substring(e.Link.Start, e.Link.Length);

            if (!url.Contains("://"))
                url = "https://" + url;

            var si = new ProcessStartInfo(url);
            Process.Start(si);
            linkWebSite.LinkVisited = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
