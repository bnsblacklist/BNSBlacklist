using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }

        public static void WriteConfig()
        {

        }
    }
}
