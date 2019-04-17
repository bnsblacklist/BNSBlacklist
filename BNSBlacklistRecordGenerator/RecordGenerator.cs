using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BNSBan;

namespace BNSBlacklistRecordGenerator
{
    public partial class RecordGenerator : Form
    {
        public RecordGenerator()
        {
            InitializeComponent();
            string[] args = Environment.GetCommandLineArgs();
            if(args.Length > 2)
            {
                if (args[1].ToLower().Equals("na"))
                {
                    na.Checked = true;
                } else if (args[1].ToLower().Equals("eu"))
                {
                    eu.Checked = true;
                }
                charname.Text = args[2];
            }
            
        }

        private void RecordGenerator_Load(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            Profile pf;
            if (na.Checked)
                pf = Profile.RetriveProfile("na", charname.Text);
            else if (eu.Checked)
                pf = Profile.RetriveProfile("eu", charname.Text);
            else
                return;

            if(pf == null)
            {
                return;
            }

            BanCheck bc = BanCheck.RetriveBanRecords(pf);
            StringBuilder linkmdString = new StringBuilder("| ");
            linkmdString.Append(pf.accountName + " | " + pf.characterName);
            foreach (string alt in pf.altsName)
            {
                linkmdString.Append(" </br> " + alt);
            }
            linkmdString.Append(" | " + MD5Helper.GetMd5Hash(pf.characterName));
            foreach (string alt in pf.altsName)
            {
                linkmdString.Append(" </br> " + MD5Helper.GetMd5Hash(alt));
            }
            linkmdString.Append(" | [" + MD5Helper.GetMd5Hash(pf.characterName).Substring(0, 6) + "](/" + pf.region + "/" + MD5Helper.GetMd5Hash(pf.characterName) + "/)");
            foreach (string alt in pf.altsName)
            {
                string tempmd5 = MD5Helper.GetMd5Hash(alt);
                linkmdString.Append(" </br> [" + tempmd5.Substring(0, 6) + "](/" + pf.region + "/" + tempmd5 + "/)");
            }
            linkmdString.Append("|");
            Console.WriteLine(linkmdString.ToString());
            CreateRecord cr = new CreateRecord(pf, bc);
            cr.Show();
        }
    }
}
