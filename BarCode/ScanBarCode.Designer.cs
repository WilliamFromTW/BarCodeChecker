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
            this.textResultStatus = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.ScanResultStatus = new System.Windows.Forms.Label();
            this.aBARCODEDataSet = new BarCode.BARCODEDataSet();
            this.storageDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBAR_CODE_SCAN_HISTORYTableAdapter = new BarCode.BARCODEDataSetTableAdapters.BAR_CODE_SCAN_HISTORYTableAdapter();
            this.tableAdapterManager1 = new BarCode.BARCODEDataSetTableAdapters.TableAdapterManager();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ScanBarCodeTxt = new System.Windows.Forms.TextBox();
            this.BarCodeLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textWorkStationNumber = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aBARCODEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataSetBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textResultStatus);
            this.groupBox1.Controls.Add(this.textResult);
            this.groupBox1.Controls.Add(this.ScanResultStatus);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "檢查結果";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textResultStatus
            // 
            this.textResultStatus.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textResultStatus.Location = new System.Drawing.Point(6, 92);
            this.textResultStatus.Name = "textResultStatus";
            this.textResultStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textResultStatus.Size = new System.Drawing.Size(473, 84);
            this.textResultStatus.TabIndex = 5;
            this.textResultStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textResult
            // 
            this.textResult.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textResult.Location = new System.Drawing.Point(6, 31);
            this.textResult.Name = "textResult";
            this.textResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textResult.Size = new System.Drawing.Size(473, 42);
            this.textResult.TabIndex = 4;
            this.textResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // aBARCODEDataSet
            // 
            this.aBARCODEDataSet.DataSetName = "BARCODEDataSet";
            this.aBARCODEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storageDataSetBindingSource
            // 
            this.storageDataSetBindingSource.DataSource = this.aBARCODEDataSet;
            this.storageDataSetBindingSource.Position = 0;
            // 
            // aBAR_CODE_SCAN_HISTORYTableAdapter
            // 
            this.aBAR_CODE_SCAN_HISTORYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BAR_CODE_SCAN_HISTORYTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = BarCode.BARCODEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textWorkStationNumber);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ScanBarCodeTxt);
            this.groupBox2.Controls.Add(this.BarCodeLength);
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 117);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(13, 75);
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
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "條碼長度 : ";
            // 
            // ScanBarCodeTxt
            // 
            this.ScanBarCodeTxt.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ScanBarCodeTxt.Location = new System.Drawing.Point(71, 69);
            this.ScanBarCodeTxt.Name = "ScanBarCodeTxt";
            this.ScanBarCodeTxt.Size = new System.Drawing.Size(325, 27);
            this.ScanBarCodeTxt.TabIndex = 3;
            this.ScanBarCodeTxt.TextChanged += new System.EventHandler(this.ScanBarCodeTxt_TextChanged);
            // 
            // BarCodeLength
            // 
            this.BarCodeLength.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BarCodeLength.ForeColor = System.Drawing.Color.Red;
            this.BarCodeLength.Location = new System.Drawing.Point(104, 21);
            this.BarCodeLength.Name = "BarCodeLength";
            this.BarCodeLength.Size = new System.Drawing.Size(44, 27);
            this.BarCodeLength.TabIndex = 2;
            this.BarCodeLength.Text = "8";
            this.BarCodeLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BarCodeLength.TextChanged += new System.EventHandler(this.BarCodeLength_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(187, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "線別 : ";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // textWorkStationNumber
            // 
            this.textWorkStationNumber.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textWorkStationNumber.ForeColor = System.Drawing.Color.Red;
            this.textWorkStationNumber.Location = new System.Drawing.Point(245, 21);
            this.textWorkStationNumber.Name = "textWorkStationNumber";
            this.textWorkStationNumber.Size = new System.Drawing.Size(44, 27);
            this.textWorkStationNumber.TabIndex = 7;
            this.textWorkStationNumber.Text = "0";
            this.textWorkStationNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textWorkStationNumber.TextChanged += new System.EventHandler(this.TextWorkStationNumber_TextChanged);
            // 
            // ScanBarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 345);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ScanBarCode";
            this.Text = "ScanBarCode";
            this.Load += new System.EventHandler(this.ScanBarCode_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aBARCODEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataSetBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BARCODEDataSet aBARCODEDataSet;
        private System.Windows.Forms.BindingSource storageDataSetBindingSource;
        private BARCODEDataSetTableAdapters.BAR_CODE_SCAN_HISTORYTableAdapter aBAR_CODE_SCAN_HISTORYTableAdapter;
        private BARCODEDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ScanBarCodeTxt;
        private System.Windows.Forms.TextBox BarCodeLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ScanResultStatus;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.TextBox textResultStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textWorkStationNumber;
    }
}