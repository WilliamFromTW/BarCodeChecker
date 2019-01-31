namespace BarCode
{
    partial class BarCodeScanHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bARCODESCANHISTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageDataSet = new BarCode.storageDataSet();
            this.bAR_CODE_SCAN_HISTORYTableAdapter = new BarCode.storageDataSetTableAdapters.BAR_CODE_SCAN_HISTORYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bARCODESCANHISTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uIDDataGridViewTextBoxColumn,
            this.SN,
            this.lOGDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bARCODESCANHISTORYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 468);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uIDDataGridViewTextBoxColumn
            // 
            this.uIDDataGridViewTextBoxColumn.DataPropertyName = "UID";
            this.uIDDataGridViewTextBoxColumn.HeaderText = "UID";
            this.uIDDataGridViewTextBoxColumn.Name = "uIDDataGridViewTextBoxColumn";
            this.uIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uIDDataGridViewTextBoxColumn.Visible = false;
            this.uIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // SN
            // 
            this.SN.DataPropertyName = "SN";
            this.SN.HeaderText = "SN";
            this.SN.Name = "SN";
            this.SN.ReadOnly = true;
            this.SN.Width = 44;
            // 
            // lOGDataGridViewTextBoxColumn
            // 
            this.lOGDataGridViewTextBoxColumn.DataPropertyName = "LOG";
            this.lOGDataGridViewTextBoxColumn.HeaderText = "掃描紀錄";
            this.lOGDataGridViewTextBoxColumn.Name = "lOGDataGridViewTextBoxColumn";
            this.lOGDataGridViewTextBoxColumn.ReadOnly = true;
            this.lOGDataGridViewTextBoxColumn.Width = 78;
            // 
            // bARCODESCANHISTORYBindingSource
            // 
            this.bARCODESCANHISTORYBindingSource.DataMember = "BAR_CODE_SCAN_HISTORY";
            this.bARCODESCANHISTORYBindingSource.DataSource = this.storageDataSet;
            // 
            // storageDataSet
            // 
            this.storageDataSet.DataSetName = "storageDataSet";
            this.storageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bAR_CODE_SCAN_HISTORYTableAdapter
            // 
            this.bAR_CODE_SCAN_HISTORYTableAdapter.ClearBeforeFill = true;
            // 
            // BarCodeScanHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 492);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BarCodeScanHistory";
            this.Text = "BarCodeScanHistory";
            this.Load += new System.EventHandler(this.BarCodeScanHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bARCODESCANHISTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private storageDataSet storageDataSet;
        private System.Windows.Forms.BindingSource bARCODESCANHISTORYBindingSource;
        private storageDataSetTableAdapters.BAR_CODE_SCAN_HISTORYTableAdapter bAR_CODE_SCAN_HISTORYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOGDataGridViewTextBoxColumn;
    }
}