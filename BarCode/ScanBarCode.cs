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
        public ScanBarCode()
        {
            InitializeComponent();
        }

        private void ScanBarCode_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'storageDataSet.PRODUCTS' 資料表。您可以視需要進行移動或移除。
            this.pRODUCTSTableAdapter.Fill(this.storageDataSet.PRODUCTS);
          //  this.listBox1.Text = "1,1";
            //this.pRODUCTSTableAdapter.Connection.Open();
            Item obj = null;
            foreach (DataRow dr in storageDataSet.PRODUCTS.Rows)
            {
//                MessageBox.Show(dr["Column1"].ToString());
                obj = new Item();
                obj.strText = "";
                if (dr["PRODUCT_ID"] != null)
                    obj.strText += "[" + (String)dr["PRODUCT_ID"] + "]";
                else
                    obj.strText += "[]";
                if (dr["PRODUCT_NAME"] != null)
                    obj.strText += "[" + (String)dr["PRODUCT_NAME"] + "]";
                else
                    obj.strText += "[]";
                if (dr["PRODUCT_DESC"] != null)
                    obj.strText += "[" + (String)dr["PRODUCT_DESC"] + "]";
                else
                    obj.strText += "[]";
                obj.strValue = (String)dr["BAR_CODE"];
                this.listBox1.Items.Add(obj);
                this.listBox1.SetSelected(0, true);
            }
            this.ActiveControl = ScanBarCodeTxt;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item k = (Item)this.listBox1.SelectedItem;
            //MessageBox.Show(k.strValue);
            this.ActiveControl = ScanBarCodeTxt;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ScanBarCodeTxt_TextChanged(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy/mm/dd hh:mm:ss"); // includes leading zeros
            OleDbCommand command = null;
            if (ScanBarCodeTxt.Text.Length == Convert.ToInt32(BarCodeLength.Text.ToString()))
            {
                try
                {
                    DataSet ds = new DataSet();
                OleDbConnection con = this.pRODUCTSTableAdapter.Connection;
                con.Open();
                OleDbDataAdapter adapter = this.pRODUCTSTableAdapter.Adapter;
                command = new OleDbCommand("select * from PRODUCTS WHERE BAR_CODE='" + ScanBarCodeTxt.Text+"'", con);
                    adapter.SelectCommand = command;
                    adapter.Fill(ds);


                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //MessageBox.Show(ds.Tables[0].Rows[i].ItemArray[1].ToString());
                        ScanResultStatus.Text = "OK!";
                        String sTemp = date + ",OK!," + ds.Tables[0].Rows[0].ItemArray[1].ToString() + "," + ds.Tables[0].Rows[0].ItemArray[2].ToString() + "," + ds.Tables[0].Rows[0].ItemArray[3].ToString();
                        listBox2.Items.Insert(0,sTemp);// +"\r\n" + listBox2.Text;
                        command = new OleDbCommand("INSERT INTO BAR_CODE_SCAN_HISTORY(LOG) values ('" + sTemp +"')", con);
                        command.ExecuteNonQuery();
                        
                    }
                    else
                    {
                        ScanResultStatus.Text = "FAIL!";
                        String sTemp = date + ",FAIL!," + ScanBarCodeTxt.Text;
                        listBox2.Items.Insert(0, sTemp);// +"\r\n" + listBox2.Text;
                        command = new OleDbCommand("INSERT INTO BAR_CODE_SCAN_HISTORY(LOG) values ('" + sTemp + "')", con);
                        command.ExecuteNonQuery();
                    }
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            }
            //ScanBarCodeTxt.SelectAll();
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

    }
    public class Item
    {
        public string strText;
        public string strValue;
        public override string ToString()
        {
            return this.strText;
        }
    }
}
