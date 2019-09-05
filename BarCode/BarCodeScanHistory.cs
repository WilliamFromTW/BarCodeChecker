using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarCode
{
    public partial class BarCodeScanHistory : Form
    {
        public BarCodeScanHistory()
        {
            InitializeComponent();
            aBAR_CODE_SCAN_HISTORYTableAdapter.Connection.ConnectionString = "Data Source=" + Program.ReadSetting("IP") +
    ";Initial Catalog=" + Program.ReadSetting("DB") + ";Persist Security Info=True;User ID=" +
    Program.ReadSetting("UID") + ";Password=" +
    Program.ReadSetting("PWD");
            if (sWORKSTATION_NUMBER.Text.Trim().Equals(""))
                sWORKSTATION_NUMBER.Text = Program.ReadSetting("WorkStationNumber");


        }

        private void BarCodeScanHistory_Load(object sender, EventArgs e)
        {
         
            
            try
            {
                //   this.aBAR_CODE_SCAN_HISTORYTableAdapter.Fill(this.aBARCODEDataSet.BAR_CODE_SCAN_HISTORY);
                if (sSTATUS.Text.Equals("ALL"))
                    this.aBAR_CODE_SCAN_HISTORYTableAdapter.FillBy1(this.aBARCODEDataSet.BAR_CODE_SCAN_HISTORY, sWORKSTATION_NUMBER.Text);
                else
                    this.aBAR_CODE_SCAN_HISTORYTableAdapter.FillBy(this.aBARCODEDataSet.BAR_CODE_SCAN_HISTORY, sWORKSTATION_NUMBER.Text, sSTATUS.Text);

            }
            catch (Exception ee)
            {
                MessageBox.Show("DB connection failed! Check Database Settings");
                Close();
            }

        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           // MessageBox.Show("complete" + e );
            int count = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //MessageBox.Show(row.Cells[3].Value.ToString());
                if( row.Cells[4].Value.ToString().Equals("FAIL"))
                {
                    //    MessageBox.Show("red");
                    dataGridView1[1, count].Style.ForeColor = Color.Red;
                    dataGridView1[2, count].Style.ForeColor = Color.Red;
                    dataGridView1[3, count].Style.ForeColor = Color.Red;
                    dataGridView1[4, count].Style.ForeColor = Color.Red;
                }
                else
                {
                    dataGridView1[1, count].Style.ForeColor = Color.Blue;
                    dataGridView1[2, count].Style.ForeColor = Color.Blue;
                    dataGridView1[3, count].Style.ForeColor = Color.Blue;
                    dataGridView1[4, count].Style.ForeColor = Color.Blue;
                };
                count++;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bARCODESCANHISTORYBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if( sSTATUS.Text.Equals("ALL"))
                this.aBAR_CODE_SCAN_HISTORYTableAdapter.FillBy1(this.aBARCODEDataSet.BAR_CODE_SCAN_HISTORY, sWORKSTATION_NUMBER.Text);
                else
                this.aBAR_CODE_SCAN_HISTORYTableAdapter.FillBy(this.aBARCODEDataSet.BAR_CODE_SCAN_HISTORY, sWORKSTATION_NUMBER.Text,sSTATUS.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void SWORKSTATION_NUMBER_Click(object sender, EventArgs e)
        {

        }

        private void FillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
        

        }

        private void SWORKSTATION_NUMBERToolStripTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
