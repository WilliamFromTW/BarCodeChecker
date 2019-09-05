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
        }

        private void BarCodeScanHistory_Load(object sender, EventArgs e)
        {
         
            
            try
            {
                this.aBAR_CODE_SCAN_HISTORYTableAdapter.Fill(this.aBARCODEDataSet.BAR_CODE_SCAN_HISTORY);
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
                if( row.Cells[3].Value.ToString().Equals("FAIL"))
                {
                    //    MessageBox.Show("red");
                    dataGridView1[1, count].Style.ForeColor = Color.Red;
                    dataGridView1[2, count].Style.ForeColor = Color.Red;
                    dataGridView1[3, count].Style.ForeColor = Color.Red;
                }
                else
                {
                    dataGridView1[1, count].Style.ForeColor = Color.Blue;
                    dataGridView1[2, count].Style.ForeColor = Color.Blue;
                    dataGridView1[3, count].Style.ForeColor = Color.Blue;
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
    }
}
