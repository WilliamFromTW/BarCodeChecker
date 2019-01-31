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
    public partial class MaintainProductInfo : Form
    {
        public MaintainProductInfo()
        {
            InitializeComponent();
        }

        private void MaintainProductInfo_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'storageDataSet.PRODUCTS' 資料表。您可以視需要進行移動或移除。
            this.pRODUCTSTableAdapter.Fill(this.storageDataSet.PRODUCTS);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.pRODUCTSTableAdapter.Update(this.storageDataSet);
                this.pRODUCTSTableAdapter.Fill(this.storageDataSet.PRODUCTS);
                MessageBox.Show("更新成功!");

            }
            catch (Exception ee)
            {
                MessageBox.Show("更新失敗!"+ee.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProductInfoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ProductInfoDataGridView__RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           // this.ProductInfoDataGridView.CurrentRow.Cells['UID']=
        }

    }
}
