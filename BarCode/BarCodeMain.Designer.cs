namespace BarCode
{
    partial class BarCodeMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storageDataSet = new BarCode.storageDataSet();
            this.bAR_CODE_SCAN_HISTORYTableAdapter = new BarCode.storageDataSetTableAdapters.BAR_CODE_SCAN_HISTORYTableAdapter();
            this.linkWebSite = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "檢測條碼是否重複";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "查看歷史記錄";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "備份歷史紀錄";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(564, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "清除歷史紀錄";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.storageDataSet;
            this.bindingSource1.Position = 0;
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
            // linkWebSite
            // 
            this.linkWebSite.AutoSize = true;
            this.linkWebSite.Location = new System.Drawing.Point(604, 61);
            this.linkWebSite.Name = "linkWebSite";
            this.linkWebSite.Size = new System.Drawing.Size(88, 12);
            this.linkWebSite.TabIndex = 5;
            this.linkWebSite.TabStop = true;
            this.linkWebSite.Text = "https://kafeiou.pw";
            this.linkWebSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWebSite_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "2019-08-29";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BarCodeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 105);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkWebSite);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "BarCodeMain";
            this.Text = "BarCode";
            this.Load += new System.EventHandler(this.BarCodeMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private storageDataSet storageDataSet;
        private storageDataSetTableAdapters.BAR_CODE_SCAN_HISTORYTableAdapter bAR_CODE_SCAN_HISTORYTableAdapter;
        private System.Windows.Forms.LinkLabel linkWebSite;
        private System.Windows.Forms.Label label1;
    }
}

