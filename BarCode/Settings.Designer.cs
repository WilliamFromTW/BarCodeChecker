namespace BarCode
{
    partial class Settings
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
            this.PORT = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textPWD = new System.Windows.Forms.TextBox();
            this.textUID = new System.Windows.Forms.TextBox();
            this.textIP = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.PWD = new System.Windows.Forms.Label();
            this.UID = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textSettingPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textDB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PORT
            // 
            this.PORT.AutoSize = true;
            this.PORT.Location = new System.Drawing.Point(23, 18);
            this.PORT.Name = "PORT";
            this.PORT.Size = new System.Drawing.Size(34, 12);
            this.PORT.TabIndex = 0;
            this.PORT.Text = "PORT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textDB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textPWD);
            this.groupBox1.Controls.Add(this.textUID);
            this.groupBox1.Controls.Add(this.textIP);
            this.groupBox1.Controls.Add(this.textPort);
            this.groupBox1.Controls.Add(this.PWD);
            this.groupBox1.Controls.Add(this.UID);
            this.groupBox1.Controls.Add(this.IP);
            this.groupBox1.Controls.Add(this.PORT);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MSSQL";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // textPWD
            // 
            this.textPWD.Location = new System.Drawing.Point(72, 122);
            this.textPWD.Name = "textPWD";
            this.textPWD.PasswordChar = '*';
            this.textPWD.Size = new System.Drawing.Size(123, 22);
            this.textPWD.TabIndex = 6;
            // 
            // textUID
            // 
            this.textUID.Location = new System.Drawing.Point(72, 85);
            this.textUID.Name = "textUID";
            this.textUID.Size = new System.Drawing.Size(123, 22);
            this.textUID.TabIndex = 5;
            this.textUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(72, 52);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(123, 22);
            this.textIP.TabIndex = 4;
            this.textIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(72, 15);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(123, 22);
            this.textPort.TabIndex = 3;
            this.textPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWD
            // 
            this.PWD.AutoSize = true;
            this.PWD.Location = new System.Drawing.Point(23, 125);
            this.PWD.Name = "PWD";
            this.PWD.Size = new System.Drawing.Size(30, 12);
            this.PWD.TabIndex = 3;
            this.PWD.Text = "PWD";
            // 
            // UID
            // 
            this.UID.AutoSize = true;
            this.UID.Location = new System.Drawing.Point(23, 88);
            this.UID.Name = "UID";
            this.UID.Size = new System.Drawing.Size(25, 12);
            this.UID.TabIndex = 2;
            this.UID.Text = "UID";
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Location = new System.Drawing.Point(23, 52);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(15, 12);
            this.IP.TabIndex = 1;
            this.IP.Text = "IP";
            this.IP.Click += new System.EventHandler(this.Label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textSettingPassword);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 57);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // textSettingPassword
            // 
            this.textSettingPassword.Location = new System.Drawing.Point(72, 26);
            this.textSettingPassword.Name = "textSettingPassword";
            this.textSettingPassword.PasswordChar = '*';
            this.textSettingPassword.Size = new System.Drawing.Size(123, 22);
            this.textSettingPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "DB";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textDB
            // 
            this.textDB.Location = new System.Drawing.Point(72, 159);
            this.textDB.Name = "textDB";
            this.textDB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textDB.Size = new System.Drawing.Size(123, 22);
            this.textDB.TabIndex = 7;
            this.textDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textDB.TextChanged += new System.EventHandler(this.TextDB_TextChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 308);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PORT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textSettingPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UID;
        private System.Windows.Forms.Label PWD;
        private System.Windows.Forms.TextBox textPort;
        internal System.Windows.Forms.TextBox textIP;
        internal System.Windows.Forms.TextBox textPWD;
        internal System.Windows.Forms.TextBox textUID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox textDB;
    }
}