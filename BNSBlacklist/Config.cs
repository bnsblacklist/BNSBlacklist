using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace BNSBan
{
    static class Config
    {
        // FIXED for a build
        public static string version = "0.0.3";
        // Record Checking Settings
        public static bool enableLocalCheck = true;
        public static string localRecordDir = Directory.GetCurrentDirectory() + "\\records\\";
        public static bool enableNameChangeSubmission = true;
        // Auto Detect Settings
        public static bool enableAutoDetect = false;
        public static string screenshotDir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\BnS\\";
        public static string autodectectGap = "15";
        // Updating Settings
        public static bool checkUpdatesAtStart = true;
        public static bool autoInstallUpdates = false;
        


        public static void ReadConfig()
        {
            if (File.Exists("./config.xml"))
            {
                try
                {
                    XmlDocument config = new XmlDocument();
                    config.Load("./config.xml");
                    XmlNode root = config.DocumentElement;
                    foreach (XmlNode item in root.ChildNodes)
                    {
                        if (item.Name == "enableLocalCheck")
                        {
                            enableLocalCheck = bool.Parse(item.InnerText);
                        } else if(item.Name == "localRecordDir")
                        {
                            localRecordDir = item.InnerText;
                            if (!Directory.Exists(localRecordDir))
                            {
                                localRecordDir = Directory.GetCurrentDirectory() + "\\records\\";
                            }
                        } else if(item.Name == "enableNameChangeSubmission")
                        {
                            enableNameChangeSubmission = bool.Parse(item.InnerText);
                        } else if(item.Name == "enableAutoDetect")
                        {
                            enableAutoDetect = bool.Parse(item.InnerText);
                        } else if (item.Name == "screenshotDir")
                        {
                            screenshotDir = item.InnerText;
                            if (!Directory.Exists(screenshotDir))
                            {
                                screenshotDir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\BnS\\";
                            }
                        } else if (item.Name == "autodectectGap")
                        {
                            autodectectGap = item.InnerText;
                            int result;
                            if(!int.TryParse(autodectectGap, out result))
                            {
                                autodectectGap = "15";
                            }
                        } else if (item.Name == "checkUpdatesAtStart")
                        {
                            checkUpdatesAtStart = bool.Parse(item.InnerText);
                        } else if (item.Name == "autoInstallUpdates")
                        {
                            autoInstallUpdates = bool.Parse(item.InnerText);
                        }
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("The config file is corrupted. The program has reset the settings to default configuration.", "BNSBlacklist: Corrupted config file");
                    WriteConfig();
                }
            } else
            {
                MessageBox.Show("Welcome to BNS Blacklist Checker Tool. After dectection, this is the first time you open the tool. " +
                    "The program has generated a default configuration. You can change the configuration in \"Settings\" menu.", "BNSBlacklist: Default Configuration Generated");
                WriteConfig();
            }
        }

        public static void WriteConfig()
        {
            XmlWriter writer = XmlWriter.Create("./config.xml");
            writer.WriteStartDocument();
            writer.WriteStartElement("config");
            writer.WriteElementString("enableLocalCheck", enableLocalCheck.ToString());
            writer.WriteElementString("localRecordDir", localRecordDir);
            writer.WriteElementString("enableNameChangeSubmission", enableNameChangeSubmission.ToString());

            writer.WriteElementString("enableAutoDetect", enableAutoDetect.ToString());
            writer.WriteElementString("screenshotDir", screenshotDir);
            writer.WriteElementString("autodectectGap", autodectectGap);

            writer.WriteElementString("checkUpdatesAtStart", checkUpdatesAtStart.ToString());
            writer.WriteElementString("autoInstallUpdates", autoInstallUpdates.ToString());
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }

    }
}
