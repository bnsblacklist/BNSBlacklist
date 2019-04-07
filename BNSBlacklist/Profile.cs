using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Json;

namespace BNSBan
{
    public class Profile
    {
        private static string NAProfileURL = "http://na-bns.ncsoft.com/ingame/bs/character/data/abilities.json?c=";
        private static string EUProfileURL = "http://eu-bns.ncsoft.com/ingame/bs/character/data/abilities.json?c=";
        private static bool usingSilveressAPI = true;
        private static string SilverssURL = "https://api.silveress.ie/bns/v3/character/full/";

        public string accountName;
        public string characterName;
        public List<string> altsName;
        public int level;
        public int hmlevel;
        public string pclass;
        public string server;
        public string region;
        public string guild;
        public string build;
        public int ap;
        public int hp;
        public Equipments equipments;
        public string img;

        public class Equipments
        {
            public string weapon;
            public string ring;
            public string earing;
            public string necklace;
            public string bracelet;
            public string belt;
            public string pet;
            public string gloves;
            public string soul;
            public string heart;
            public string talisman;
            public string soulbadge;
            public string mysticbadge;
        }

        private Profile()
        {
            altsName = new List<string>();
            equipments = new Equipments();
        }


        public static Profile RetriveProfile(string region, string charname)
        {
            string processedCharname = charname.Replace(" ", "%20");
            if (usingSilveressAPI) {
                string apiurl = SilverssURL + region + "/" + processedCharname;
                using (var webClient = new System.Net.WebClient())
                {
                    webClient.Encoding = Encoding.UTF8;
                    string json;
                    JsonValue result;
                    try {
                        json = webClient.DownloadString(apiurl);
                        result = JsonValue.Parse(json);
                    } catch (Exception)
                    {
                        return null;
                    }
                    
                    if (result.ContainsKey("error"))
                    {
                        return null;
                    }
                    Profile p = new Profile();
                    try
                    {
                        p.region = region;
                        p.accountName = result["accountName"];
                        p.characterName = result["characterName"];
                        foreach (JsonValue alt in result["otherNames"])
                        {
                            p.altsName.Add(alt);
                        }
                        p.level = result["playerLevel"];
                        p.pclass = result["playerClass"];
                        p.build = result["style"];
                        p.hmlevel = result["playerLevelHM"];
                        p.guild = result["guild"];
                        p.server = result["server"];
                        // load attr
                        p.ap = result["ap"];
                        p.hp = result["hp"];
                        // load equipments
                        p.equipments.weapon = result["weaponName"];
                        p.equipments.ring = result["ringName"];
                        p.equipments.earing = result["earringName"];
                        p.equipments.necklace = result["necklaceName"];
                        p.equipments.bracelet = result["braceletName"];
                        p.equipments.belt = result["beltName"];
                        p.equipments.pet = result["petAuraName"];
                        p.equipments.gloves = result["gloves"];
                        p.equipments.soul = result["soulName"];
                        p.equipments.heart = result["soulName2"];
                        p.equipments.talisman = result["talismanName"];
                        p.equipments.soulbadge = result["soulBadgeName"];
                        p.equipments.mysticbadge = result["mysticBadgeName"];
                        p.img = result["characterImg"];
                        
                    }
                    catch(Exception)
                    {
                        return null;
                    }
                    return p;
                }
            } else {
                return null;
            }
        }
    }
}
