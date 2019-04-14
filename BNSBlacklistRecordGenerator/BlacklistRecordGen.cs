using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using Markdig;
using BNSBan;
using System.Xml.Serialization;

namespace BNSBlacklistRecordGenerator
{
    /*
        Generate 3 parts:
        info file
        record md
        record html
    */
    public class BlacklistRecordGen
    {
        protected static string templateRootUrl = "https://raw.githubusercontent.com/bnsblacklist/bnsblacklist.records/master/template/";
        protected static string templateConfigName = "config.xml";
        protected static string configName = "simpleRecord";

        private class FieldConfig
        {
            public string name;
            public string replacement;
            public string usage;
        }

        protected Dictionary<string, string> replacement;
        private Dictionary<string, FieldConfig> availableFields;
        private Profile profile;
        private string markdownSource;

        public BlacklistRecordGen(Profile profile)
        {
            replacement = new Dictionary<string, string>();
            availableFields = new Dictionary<string, FieldConfig>();
            RetrieveTemplate();
            this.profile = profile;
        }

        protected IReadOnlyList<string> getAvailableFields()
        {
            return availableFields.Keys.ToList();
        }

        protected bool RetrieveTemplate()
        {
            string templateConfigURL = templateRootUrl + templateConfigName;
            XmlDocument result;
            using (var webClient = new System.Net.WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                try
                {
                    string xml = webClient.DownloadString(templateConfigURL);
                    result = new XmlDocument();
                    result.LoadXml(xml);
                }
                catch (Exception)
                {
                    return false;
                }
            }
            if(result.GetElementsByTagName("template").Count != 1)
            {
                return false;
            }
            XmlNode root = result.GetElementsByTagName("template")[0];
            XmlNode form = null;
            foreach(XmlNode formNode in root.ChildNodes)
            {
                if(formNode.Name.Equals("form") && formNode.Attributes["name"].Value.Equals(configName))
                {
                    form = formNode;
                    using (var webClient = new System.Net.WebClient())
                    {
                        webClient.Encoding = Encoding.UTF8;
                        try
                        {
                            markdownSource = webClient.DownloadString(templateRootUrl + formNode.Attributes["location"].Value);
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }
                    break;
                }
            }
            if(form == null)
            {
                return false;
            }
            availableFields.Clear();
            foreach(XmlNode field in form.ChildNodes)
            {
                if(field.Name.Equals("field"))
                {
                    FieldConfig fc = new FieldConfig();
                    fc.name = field.Attributes["name"].Value;
                    fc.replacement = field.Attributes["replace"].Value;
                    fc.usage = field.Attributes["usage"].Value;
                    availableFields.Add(fc.name, fc);
                }
            }
            return true;
        }

        public bool SetContent(string field, string content)
        {
            if (availableFields.ContainsKey(field))
            {
                replacement.Add(field, content);
                return true;
            } else
            {
                return false;
            }
        }

        private string getSubDirFile(string parent, string filename, bool isFolder = false)
        {
            string fn;
            if (parent.EndsWith("/") || parent.EndsWith("\\"))
            {
                fn = parent + filename;
            }
            else if (parent.Contains("/"))
            {
                fn = parent + "/" + filename;
            }
            else
            {
                fn = parent + "\\" + filename;
            }
            if (!isFolder)
            {
                return fn;
            }
            if (parent.Contains("/"))
            {
                fn = fn + "/" ;
            }
            else
            {
                fn = fn + "\\";
            }
            return fn;
        }

        protected string getDescription(string code)
        {
            string codeT = code.Replace(" ", string.Empty);
            switch (codeT)
            {
                case "B001":
                    return "Scam (Item Sellers / Gold Sellers)";
                case "B002":
                    return "Scam (Account Seller)";
                case "B003":
                    return "Scam (HMCS MOML / Raid Items)";
                case "C001":
                    return "Account Stealer";
                case "C002":
                    return "Potential Hacked Account";
                case "C003":
                    return "Cheater";
                case "I001":
                    return "Traps";
                case "I002":
                    return "AFKers";
                case "I003":
                    return "Negative Players";
                case "I004":
                    return "Wintrading";
                case "B999":
                    return "Custom (Blacklist)";
                case "C999":
                    return "Custom (Cheats)";
                case "I999":
                    return "Custom (Inappropriate)";
                default:
                    return "Unknown";
            }
        }

        public bool Generate(string rootDir, string caseName, bool linkCharacters = true, bool generatePackage = false)
        {
            Directory.CreateDirectory(rootDir);
            if(Directory.Exists(getSubDirFile(getSubDirFile(rootDir, MD5Helper.GetMd5Hash(profile.characterName), true), "casenumber", true)))
            {
                return false;
            }
            if(!replacement.ContainsKey("code"))
            {
                return false;
            }
            Dictionary<string, string> fileList = new Dictionary<string, string>();
            SortedList<string,string> links = new SortedList<string,string>();
            links.Add(MD5Helper.GetMd5Hash(profile.characterName), MD5Helper.GetMd5Hash(profile.characterName));
            StreamWriter writer;
            if (linkCharacters)
            {
                foreach (string alt in profile.altsName)
                {
                    links.Add(MD5Helper.GetMd5Hash(alt), MD5Helper.GetMd5Hash(alt));
                }
                foreach (string alt in profile.altsName)
                {
                    // find the subfolder
                    string uid = MD5Helper.GetMd5Hash(alt);
                    string folder = getSubDirFile(rootDir, uid, true);
                    // generate links if not exist
                    Directory.CreateDirectory(folder);
                    string linkfile = folder + "info";
                    if(File.Exists(linkfile))
                    {
                        string[] readin = File.ReadAllLines(linkfile);
                        int index = 0, line = 0;
                        StringBuilder build = new StringBuilder();
                        List<string> lines = new List<string>();
                        while(index < links.Count || line < readin.Length)
                        {
                            if(index == links.Count)
                            {
                                lines.Add(readin[line++]);
                            } else
                            {
                                string lineExpected;
                                if(links.Keys[index] == uid)
                                {
                                    lineExpected = "CURL|" + uid;
                                } else
                                {
                                    lineExpected = "LINK|" + links.Keys[index];
                                }
                                build.Append(lineExpected + "\n");
                                // check if line matches
                                if(readin[line].Equals(lineExpected))
                                {
                                    lines.Add(readin[line++]);
                                } else
                                {
                                    lines.Add(lineExpected);
                                }
                                index++;
                            }
                        }
                        fileList.Add(linkfile, build.ToString());
                        writer = new StreamWriter(linkfile);
                        foreach(string l in lines)
                        {
                            writer.WriteLine(l);
                        }
                        writer.Close();

                    } else
                    {
                        StringBuilder build = new StringBuilder();
                        int index = 0;
                        while (index < links.Count)
                        {
                                string lineExpected;
                                if (links.Keys[index] == uid)
                                {
                                    lineExpected = "CURL|" + uid;
                                }
                                else
                                {
                                    lineExpected = "LINK|" + links.Keys[index];
                                }
                                build.Append(lineExpected + "\n");
                                index++;
                        }
                        fileList.Add(linkfile, build.ToString());
                        writer = new StreamWriter(linkfile);
                        writer.WriteLine(build.ToString());
                        writer.Close();
                    }
                }
            }
            // find the actually charater's subfolder
            string cuid = MD5Helper.GetMd5Hash(profile.characterName);
            // generate link file
            string cfolder = getSubDirFile(rootDir, cuid, true);
            Directory.CreateDirectory(cfolder);
            string clinkfile = cfolder + "info";
            if (File.Exists(clinkfile))
            {
                string[] readin = File.ReadAllLines(clinkfile);
                int index = 0, line = 0;
                StringBuilder build = new StringBuilder();
                List<string> lines = new List<string>();
                while (index < links.Count || line < readin.Length)
                {
                    if (index == links.Count)
                    {
                        lines.Add(readin[line++]);
                    }
                    else
                    {
                        string lineExpected;
                        if (links.Keys[index] == cuid)
                        {
                            lineExpected = "CURL|" + cuid;
                        }
                        else
                        {
                            lineExpected = "LINK|" + links.Keys[index];
                        }
                        build.Append(lineExpected + "\n");
                        // check if line matches
                        if (readin[line].Equals(lineExpected))
                        {
                            lines.Add(readin[line++]);
                        }
                        else
                        {
                            lines.Add(lineExpected);
                        }
                        index++;
                    }
                }
                //Add current case
                string caseRecd = "RECD|" + replacement["code"].Replace(" ", string.Empty) + "|" + getDescription(replacement["code"]) + "|" + caseName;
                build.Append(caseRecd + "\n");
                fileList.Add(clinkfile, build.ToString());
                writer = new StreamWriter(clinkfile);
                foreach (string l in lines)
                {
                    writer.WriteLine(l);
                }
                writer.Close();

            }
            else
            {
                StringBuilder build = new StringBuilder();
                int index = 0;
                while (index < links.Count)
                {
                    string lineExpected;
                    if (links.Keys[index] == cuid)
                    {
                        lineExpected = "CURL|" + cuid;
                    }
                    else
                    {
                        lineExpected = "LINK|" + links.Keys[index];
                    }
                    build.Append(lineExpected + "\n");
                    index++;
                }
                //Add current case
                string caseRecd = "RECD|" + replacement["code"].Replace(" ", string.Empty) + "|" + getDescription(replacement["code"]) + "|" + caseName;
                build.Append(caseRecd + "\n");
                fileList.Add(clinkfile, build.ToString());
                writer = new StreamWriter(clinkfile);
                writer.WriteLine(build.ToString());
                writer.Close();
            }
            // generate case subfolder
            string casefolder = getSubDirFile(cfolder, caseName, true);
            Directory.CreateDirectory(casefolder);
            // generate markdown
            string resultMD = (string)markdownSource.Clone();
            foreach (FieldConfig config in availableFields.Values)
            {
                if(replacement.ContainsKey(config.name))
                {
                    resultMD = resultMD.Replace("$<" + config.replacement + ">", replacement[config.name]);
                }
            }
            // write markdown
            string markdownFilePath = casefolder + "record.md";
            writer = new StreamWriter(markdownFilePath);
            writer.WriteLine(resultMD);
            writer.Close();
            fileList.Add(markdownFilePath, resultMD);
            // generate html
            string resultHtml = Markdown.ToHtml(resultMD);
            // write html
            writer = new StreamWriter(casefolder + "record.html");
            writer.WriteLine(resultHtml);
            writer.Close();
            if (generatePackage)
            {
                // put all link & markdown into a xml file
                string submitPackageFolder = getSubDirFile(rootDir, "submitPackages", true);
                Directory.CreateDirectory(submitPackageFolder);
                DictionarySerializer ds = new DictionarySerializer(fileList);
                // write zip
                DictionarySerializer.Serialize(submitPackageFolder + profile.characterName + "CASE" + caseName + ".pkg", ds);
            }

            return true;
        }
    }
    
}
