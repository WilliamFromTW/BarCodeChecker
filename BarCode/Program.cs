using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarCode
{
    static  class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if( ReadSetting("PASSWORD").Equals(""))
               AddUpdateAppSettings("PASSWORD", "kafeiou");
            if (ReadSetting("IP").Equals(""))
                AddUpdateAppSettings("IP", "localhost");
            if (ReadSetting("UID").Equals(""))
                AddUpdateAppSettings("UID", "sa");
            if (ReadSetting("PWD").Equals(""))
                AddUpdateAppSettings("PWD", "");
            if (ReadSetting("PORT").Equals(""))
                AddUpdateAppSettings("PORT", "1433");
            if (ReadSetting("DB").Equals(""))
                AddUpdateAppSettings("DB", "BARCODE");
            if (ReadSetting("BarCodeLength").Equals(""))
                AddUpdateAppSettings("BarCodeLength", "8");
            if (ReadSetting("WorkStationNumber").Equals(""))
                AddUpdateAppSettings("WorkStationNumber", "0");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BarCodeMain());
        }
        public static string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "";
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
                return "";
            }
        }

        public static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
    }
}
