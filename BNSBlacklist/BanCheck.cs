using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BNSBan
{
    public class BanRecord
    {
        public string bancode;
        public string reason;
        public string url;

        public BanRecord() { }
        public BanRecord(string code, string reason, string url)
        {
            bancode = code;
            this.reason = reason;
            this.url = url;
        }

        public bool isBan()
        {
            return bancode.StartsWith("B") || bancode.StartsWith("C");
        }

        public bool isWarning()
        {
            return bancode.StartsWith("I");
        }
    }

    public class BanCheck
    {
        private static string recordURL = "https://raw.githubusercontent.com/bnsblacklist/bnsblacklist.records/master/";
        private static string linkURL = "https://github.com/bnsblacklist/bnsblacklist.records/blob/master/";
        public string uid;
        public List<BanRecord> records;
        private List<string> checkeduid;
        private List<string> checkedluid;

        public BanCheck()
        {
            records = new List<BanRecord>();
            checkeduid = new List<string>();
            checkedluid = new List<string>();
        }

        private void AddRecord(string region, string uid)
        {
            if(checkeduid.Contains(uid))
            {
                return;
            }
            checkeduid.Add(uid);
            string apibase = recordURL + region + "/" + uid + "/";
            string linkbase = linkURL + region + "/" + uid + "/";
            string apiurl = apibase + "info";
            Console.WriteLine("Checking [" + region + "] " + uid);
            using (var webClient = new System.Net.WebClient())
            {
                
                webClient.Encoding = Encoding.UTF8;
                string data;
                try
                {
                    data = webClient.DownloadString(apiurl);
                }
                catch (Exception)
                {
                    return;
                }
                string[] lines = data.Split('\n');
                foreach (string line in lines)
                {
                    if (line.StartsWith("RECD"))
                    {
                        string[] record = line.Split('|');
                        if(record.Length < 4)
                        {
                            Console.WriteLine("[" + region + "," + uid + "] Error record format: " + line);
                        } else
                        {
                            BanRecord bc = new BanRecord(record[1],record[2], linkbase + record[3] + "/record.md");
                            records.Add(bc);
                        }
                    } else if(line.StartsWith("LINK"))
                    {
                        string[] link = line.Split('|');
                        if (link.Length < 2)
                        {
                            Console.WriteLine("[" + region + "," + uid + "] Error link format: " + line);
                        } else
                        {
                            AddRecord(region, link[1]);
                        }
                    }
                }
            }
        }

        private void AddLocalRecord(string region, string uid)
        {
            if (checkedluid.Contains(uid))
            {
                return;
            }
            checkedluid.Add(uid);
            string apibase = Config.localRecordDir + "\\" + region + "\\" + uid + "\\";
            if(!Directory.Exists(apibase))
            {
                return;
            }
            string apiurl = apibase + "info";
            Console.WriteLine("Checking Local [" + region + "] " + uid);
            string[] lines = File.ReadAllLines(apiurl);
            foreach (string line in lines)
            {
                if (line.StartsWith("RECD"))
                {
                    string[] record = line.Split('|');
                    if (record.Length < 4)
                    {
                        Console.WriteLine("[Local, " + region + "," + uid + "] Error record format: " + line);
                    }
                    else
                    {
                        BanRecord bc = new BanRecord(record[1], record[2], apibase + record[3] + "\\record.html");
                        records.Add(bc);
                    }
                }
                else if (line.StartsWith("LINK"))
                {
                    string[] link = line.Split('|');
                    if (link.Length < 2)
                    {
                        Console.WriteLine("[Local, " + region + "," + uid + "] Error link format: " + line);
                    }
                    else
                    {
                        AddLocalRecord(region, link[1]);
                    }
                }
            }
        }

        public static BanCheck RetriveBanRecords(Profile profile)
        {
            BanCheck result = new BanCheck();
            result.uid = MD5Helper.GetMd5Hash(profile.characterName);
            result.AddRecord(profile.region, result.uid);
            foreach (string playername in profile.altsName)
            {
                result.AddRecord(profile.region, MD5Helper.GetMd5Hash(playername));
            }
            if(Config.enableLocalCheck)
            {
                result.AddLocalRecord(profile.region, result.uid);
                foreach (string playername in profile.altsName)
                {
                    result.AddLocalRecord(profile.region, MD5Helper.GetMd5Hash(playername));
                }
            }
            return result;
        }
    }
}
