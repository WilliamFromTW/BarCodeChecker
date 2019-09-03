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
   
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            new ScanBarCode().Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new BarCodeScanHistory().Show();
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

        private void BindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
