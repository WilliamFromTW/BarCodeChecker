namespace BarCode
{
    partial class MaintainProductInfo
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
            this.ProductInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageDataSet = new BarCode.storageDataSet();
            this.pRODUCTSTableAdapter = new BarCode.storageDataSetTableAdapters.PRODUCTSTableAdapter();
            this.bARCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTDESCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductInfoDataGridView
            // 
            this.ProductInfoDataGridView.AutoGenerateColumns = false;
            this.ProductInfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProductInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bARCODEDataGridViewTextBoxColumn,
            this.pRODUCTIDDataGridViewTextBoxColumn,
            this.pRODUCTNAMEDataGridViewTextBoxColumn,
            this.pRODUCTDESCDataGridViewTextBoxColumn,
            this.uIDDataGridViewTextBoxColumn});
            this.ProductInfoDataGridView.DataSource = this.pRODUCTSBindingSource;
            this.ProductInfoDataGridView.Location = new System.Drawing.Point(22, 54);
            this.ProductInfoDataGridView.Name = "ProductInfoDataGridView";
            this.ProductInfoDataGridView.RowTemplate.Height = 24;
            this.ProductInfoDataGridView.Size = new System.Drawing.Size(800, 600);
            this.ProductInfoDataGridView.TabIndex = 0;
            this.ProductInfoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductInfoDataGridView_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "更新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(328, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "*條碼是唯一值,不可重複";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "產品條碼維護作業";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // pRODUCTSBindingSource
            // 
            this.pRODUCTSBindingSource.DataMember = "PRODUCTS";
            this.pRODUCTSBindingSource.DataSource = this.storageDataSet;
            // 
            // storageDataSet
            // 
            this.storageDataSet.DataSetName = "storageDataSet";
            this.storageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTSTableAdapter
            // 
            this.pRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // bARCODEDataGridViewTextBoxColumn
            // 
            this.bARCODEDataGridViewTextBoxColumn.DataPropertyName = "BAR_CODE";
            this.bARCODEDataGridViewTextBoxColumn.HeaderText = "條碼";
            this.bARCODEDataGridViewTextBoxColumn.Name = "bARCODEDataGridViewTextBoxColumn";
            this.bARCODEDataGridViewTextBoxColumn.Width = 54;
            // 
            // pRODUCTIDDataGridViewTextBoxColumn
            // 
            this.pRODUCTIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_ID";
            this.pRODUCTIDDataGridViewTextBoxColumn.HeaderText = "品號";
            this.pRODUCTIDDataGridViewTextBoxColumn.Name = "pRODUCTIDDataGridViewTextBoxColumn";
            this.pRODUCTIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // pRODUCTNAMEDataGridViewTextBoxColumn
            // 
            this.pRODUCTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_NAME";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.HeaderText = "品名";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.Name = "pRODUCTNAMEDataGridViewTextBoxColumn";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.Width = 54;
            // 
            // pRODUCTDESCDataGridViewTextBoxColumn
            // 
            this.pRODUCTDESCDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_DESC";
            this.pRODUCTDESCDataGridViewTextBoxColumn.HeaderText = "規格";
            this.pRODUCTDESCDataGridViewTextBoxColumn.Name = "pRODUCTDESCDataGridViewTextBoxColumn";
            this.pRODUCTDESCDataGridViewTextBoxColumn.Width = 54;
            // 
            // uIDDataGridViewTextBoxColumn
            // 
            this.uIDDataGridViewTextBoxColumn.DataPropertyName = "UID";
            this.uIDDataGridViewTextBoxColumn.HeaderText = "系統辨識用";
            this.uIDDataGridViewTextBoxColumn.Name = "uIDDataGridViewTextBoxColumn";
            this.uIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uIDDataGridViewTextBoxColumn.Visible = false;
            this.uIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // MaintainProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 674);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductInfoDataGridView);
            this.Name = "MaintainProductInfo";
            this.Text = "MaintainProductInfo";
            this.Load += new System.EventHandler(this.MaintainProductInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductInfoDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private storageDataSet storageDataSet;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private storageDataSetTableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bARCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTDESCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn;
    }
}