using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BNSBan.Resources;
using System.Diagnostics;
using BNSBlacklistRecordGenerator.Resources;

namespace BNSBan
{
    public partial class CreateRecord : Form
    {
        private readonly Profile pf;
        private readonly BanCheck check;
        private ButtonImageSet submitImg;

        public CreateRecord(Profile pf, BanCheck check)
        {
            InitializeComponent();
            this.pf = pf;
            this.check = check;
            charname.Text = pf.accountName + "[" + pf.characterName + "]";
            charinfo.Text = pf.pclass + "[" + pf.build + "] | Level" + pf.level + " · HongmoonLevel " + pf.hmlevel + " | " + pf.server + " | " + pf.guild;
            aplarge.Text = apsmall.Text = pf.ap.ToString();
            hplarge.Text = hpsmall.Text = pf.hp.ToString();
            altlist.Items.Clear();
            foreach (string alt in pf.altsName)
            {
                altlist.Items.Add(alt);
            }
            img.ImageLocation = pf.img;

            bool blacklist = false;
            bool warning = false;
            foreach (BanRecord rec in check.records)
            {
                string[] row = { rec.bancode, rec.reason, rec.url };
                var listViewItem = new ListViewItem(row);
                if (rec.isBan())
                {
                    blacklist = true;
                } else if(rec.isWarning())
                {
                    warning = true;
                }
            }
            if (blacklist)
            {
                charname.ForeColor = Color.FromArgb(196, 19, 48);
            } else if (warning)
            {
                charname.ForeColor = Color.FromArgb(236, 135, 40);
            }
            submitImg = new ButtonImageSet();
            submitImg.normal = CreateRecordBtn.submit_normal;
            submitImg.hover = CreateRecordBtn.submit_hover;
            submitBtn.Image = submitImg.normal;
        }

        private void Detail_Load(object sender, EventArgs e)
        {

        }

        private void altlist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(altlist.SelectedItem.ToString());
        }


        private void reportBtn_MouseEnter(object sender, EventArgs e)
        {
            submitBtn.Image = submitImg.hover;
        }

        private void reportBtn_MouseLeave(object sender, EventArgs e)
        {
            submitBtn.Image = submitImg.normal;
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
