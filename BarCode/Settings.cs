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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            textSettingPassword.Text = Program.ReadSetting("PASSWORD");
            textIP.Text = Program.ReadSetting("IP");
            textPort.Text = Program.ReadSetting("PORT");
            textUID.Text = Program.ReadSetting("UID");
            textPWD.Text = Program.ReadSetting("PWD");
            textDB.Text = Program.ReadSetting("DB");
        }


        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Program.AddUpdateAppSettings("PASSWORD", textSettingPassword.Text);
            Program.AddUpdateAppSettings("PORT", textPort.Text);
            Program.AddUpdateAppSettings("IP", textIP.Text);
            Program.AddUpdateAppSettings("UID", textUID.Text);
            Program.AddUpdateAppSettings("PWD", textPWD.Text);
            Program.AddUpdateAppSettings("DB", textDB.Text);
            Dispose();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextDB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
