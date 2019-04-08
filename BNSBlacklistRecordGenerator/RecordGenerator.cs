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

namespace BNSBlacklistRecordCreater
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
            CreateRecord cr = new CreateRecord(pf, bc);
            cr.Show();
        }
    }
}
