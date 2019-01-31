namespace BarCode
{
    partial class ScanBarCode
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ScanResultStatus = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.storageDataSet = new BarCode.storageDataSet();
            this.storageDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTSTableAdapter = new BarCode.storageDataSetTableAdapters.PRODUCTSTableAdapter();
            this.tableAdapterManager1 = new BarCode.storageDataSetTableAdapters.TableAdapterManager();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ScanBarCodeTxt = new System.Windows.Forms.TextBox();
            this.BarCodeLength = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ScanResultStatus);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "檢查結果";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ScanResultStatus
            // 
            this.ScanResultStatus.AutoSize = true;
            this.ScanResultStatus.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ScanResultStatus.Location = new System.Drawing.Point(598, 54);
            this.ScanResultStatus.Name = "ScanResultStatus";
            this.ScanResultStatus.Size = new System.Drawing.Size(90, 96);
            this.ScanResultStatus.TabIndex = 3;
            this.ScanResultStatus.Text = "  ";
            this.ScanResultStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox2
            // 
            this.listBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(6, 21);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(543, 172);
            this.listBox2.TabIndex = 2;
            // 
            // storageDataSet
            // 
            this.storageDataSet.DataSetName = "storageDataSet";
            this.storageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storageDataSetBindingSource
            // 
            this.storageDataSetBindingSource.DataSource = this.storageDataSet;
            this.storageDataSetBindingSource.Position = 0;
            // 
            // pRODUCTSBindingSource
            // 
            this.pRODUCTSBindingSource.DataMember = "PRODUCTS";
            this.pRODUCTSBindingSource.DataSource = this.storageDataSetBindingSource;
            // 
            // pRODUCTSTableAdapter
            // 
            this.pRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BAR_CODE_SCAN_HISTORYTableAdapter = null;
            this.tableAdapterManager1.PRODUCTSTableAdapter = this.pRODUCTSTableAdapter;
            this.tableAdapterManager1.UpdateOrder = BarCode.storageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(543, 212);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ScanBarCodeTxt);
            this.groupBox2.Controls.Add(this.BarCodeLength);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(882, 246);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(555, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "條碼 : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(555, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "條碼長度 : ";
            // 
            // ScanBarCodeTxt
            // 
            this.ScanBarCodeTxt.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ScanBarCodeTxt.Location = new System.Drawing.Point(613, 65);
            this.ScanBarCodeTxt.Name = "ScanBarCodeTxt";
            this.ScanBarCodeTxt.Size = new System.Drawing.Size(263, 27);
            this.ScanBarCodeTxt.TabIndex = 3;
            this.ScanBarCodeTxt.TextChanged += new System.EventHandler(this.ScanBarCodeTxt_TextChanged);
            // 
            // BarCodeLength
            // 
            this.BarCodeLength.ForeColor = System.Drawing.Color.Red;
            this.BarCodeLength.Location = new System.Drawing.Point(646, 17);
            this.BarCodeLength.Name = "BarCodeLength";
            this.BarCodeLength.Size = new System.Drawing.Size(44, 22);
            this.BarCodeLength.TabIndex = 2;
            this.BarCodeLength.Text = "7";
            this.BarCodeLength.TextChanged += new System.EventHandler(this.BarCodeLength_TextChanged);
            // 
            // ScanBarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ScanBarCode";
            this.Text = "ScanBarCode";
            this.Load += new System.EventHandler(this.ScanBarCode_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private storageDataSet storageDataSet;
        private System.Windows.Forms.BindingSource storageDataSetBindingSource;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private storageDataSetTableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        private storageDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ScanBarCodeTxt;
        private System.Windows.Forms.TextBox BarCodeLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ScanResultStatus;
        private System.Windows.Forms.ListBox listBox2;
    }
}