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
            this.bARCODESCANHISTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBARCODEDataSet = new BarCode.BARCODEDataSet();
            this.aBAR_CODE_SCAN_HISTORYTableAdapter = new BarCode.BARCODEDataSetTableAdapters.BAR_CODE_SCAN_HISTORYTableAdapter();
            this.wORKSTATION_NUMBERToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.sWORKSTATION_NUMBER = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.sSTATUS = new System.Windows.Forms.ToolStripComboBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.uIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORKSTATION_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bARCODESCANHISTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBARCODEDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
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
            this.WORKSTATION_NUMBER,
            this.SN,
            this.lOGDataGridViewTextBoxColumn,
            this.STATUS});
            this.dataGridView1.DataSource = this.bARCODESCANHISTORYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(354, 428);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // bARCODESCANHISTORYBindingSource
            // 
            this.bARCODESCANHISTORYBindingSource.DataMember = "BAR_CODE_SCAN_HISTORY";
            this.bARCODESCANHISTORYBindingSource.DataSource = this.aBARCODEDataSet;
            this.bARCODESCANHISTORYBindingSource.Sort = "LOG desc";
            this.bARCODESCANHISTORYBindingSource.CurrentChanged += new System.EventHandler(this.bARCODESCANHISTORYBindingSource_CurrentChanged);
            // 
            // aBARCODEDataSet
            // 
            this.aBARCODEDataSet.DataSetName = "BARCODEDataSet";
            this.aBARCODEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aBAR_CODE_SCAN_HISTORYTableAdapter
            // 
            this.aBAR_CODE_SCAN_HISTORYTableAdapter.ClearBeforeFill = true;
            // 
            // wORKSTATION_NUMBERToolStripLabel
            // 
            this.wORKSTATION_NUMBERToolStripLabel.Name = "wORKSTATION_NUMBERToolStripLabel";
            this.wORKSTATION_NUMBERToolStripLabel.Size = new System.Drawing.Size(31, 22);
            this.wORKSTATION_NUMBERToolStripLabel.Text = "線別";
            // 
            // sWORKSTATION_NUMBER
            // 
            this.sWORKSTATION_NUMBER.Name = "sWORKSTATION_NUMBER";
            this.sWORKSTATION_NUMBER.Size = new System.Drawing.Size(50, 25);
            this.sWORKSTATION_NUMBER.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sWORKSTATION_NUMBER.Click += new System.EventHandler(this.SWORKSTATION_NUMBER_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "狀態";
            // 
            // sSTATUS
            // 
            this.sSTATUS.Items.AddRange(new object[] {
            "ALL",
            "PASS",
            "FAIL"});
            this.sSTATUS.Name = "sSTATUS";
            this.sSTATUS.Size = new System.Drawing.Size(75, 25);
            this.sSTATUS.Text = "ALL";
            this.sSTATUS.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.sSTATUS.Click += new System.EventHandler(this.ToolStripDropDownButton1_Click);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(59, 22);
            this.fillByToolStripButton.Text = "按此篩選";
            this.fillByToolStripButton.Click += new System.EventHandler(this.FillByToolStripButton_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wORKSTATION_NUMBERToolStripLabel,
            this.sWORKSTATION_NUMBER,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.sSTATUS,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(376, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.FillByToolStrip_ItemClicked);
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
            // WORKSTATION_NUMBER
            // 
            this.WORKSTATION_NUMBER.DataPropertyName = "WORKSTATION_NUMBER";
            this.WORKSTATION_NUMBER.HeaderText = "線別";
            this.WORKSTATION_NUMBER.Name = "WORKSTATION_NUMBER";
            this.WORKSTATION_NUMBER.ReadOnly = true;
            this.WORKSTATION_NUMBER.Width = 54;
            // 
            // SN
            // 
            this.SN.DataPropertyName = "SN";
            this.SN.HeaderText = "BarCode";
            this.SN.Name = "SN";
            this.SN.ReadOnly = true;
            this.SN.Width = 72;
            // 
            // lOGDataGridViewTextBoxColumn
            // 
            this.lOGDataGridViewTextBoxColumn.DataPropertyName = "LOG";
            this.lOGDataGridViewTextBoxColumn.HeaderText = "掃描紀錄";
            this.lOGDataGridViewTextBoxColumn.Name = "lOGDataGridViewTextBoxColumn";
            this.lOGDataGridViewTextBoxColumn.ReadOnly = true;
            this.lOGDataGridViewTextBoxColumn.Width = 78;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "狀態";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Width = 54;
            // 
            // BarCodeScanHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 500);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BarCodeScanHistory";
            this.Text = "BarCodeScanHistory";
            this.Load += new System.EventHandler(this.BarCodeScanHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bARCODESCANHISTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBARCODEDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BARCODEDataSet aBARCODEDataSet;
        private System.Windows.Forms.BindingSource bARCODESCANHISTORYBindingSource;
        private BARCODEDataSetTableAdapters.BAR_CODE_SCAN_HISTORYTableAdapter aBAR_CODE_SCAN_HISTORYTableAdapter;
        private System.Windows.Forms.ToolStripLabel wORKSTATION_NUMBERToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox sWORKSTATION_NUMBER;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox sSTATUS;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WORKSTATION_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
    }
}