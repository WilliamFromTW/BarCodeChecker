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
            // TODO:  這行程式碼會將資料載入 'storageDataSet.BAR_CODE_SCAN_HISTORY' 資料表。您可以視需要進行移動或移除。
            this.bAR_CODE_SCAN_HISTORYTableAdapter.Fill(this.storageDataSet.BAR_CODE_SCAN_HISTORY);

        }
    }
}
