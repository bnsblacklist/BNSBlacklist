using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BNSBan
{
    public partial class Detail : Form
    {
        private readonly Profile pf;
        private readonly BanCheck check;

        public Detail(Profile pf, BanCheck check)
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
            equipments.Items.Clear();
            if (pf.equipments.weapon == "")
                equipments.Items.Add("Weapon\t: None");
            else
                equipments.Items.Add("Weapon\t: " + pf.equipments.weapon);
            if (pf.equipments.ring == "")
                equipments.Items.Add("Ring\t: None");
            else
                equipments.Items.Add("Ring\t: " + pf.equipments.ring);
            if (pf.equipments.earing == "")
                equipments.Items.Add("Earing\t: None");
            else
                equipments.Items.Add("Earing\t: " + pf.equipments.earing);
            if (pf.equipments.bracelet == "")
                equipments.Items.Add("Bracelet\t: None");
            else
                equipments.Items.Add("Bracelet\t: " + pf.equipments.bracelet);
            if (pf.equipments.belt == "")
                equipments.Items.Add("Belt\t: None");
            else
                equipments.Items.Add("Belt\t: " + pf.equipments.belt);
            if (pf.equipments.pet == "")
                equipments.Items.Add("Pet Aura\t: None");
            else
                equipments.Items.Add("Pet Aura\t: " + pf.equipments.pet);
            if (pf.equipments.gloves == "")
                equipments.Items.Add("Gloves\t: None");
            else
                equipments.Items.Add("Gloves\t: " + pf.equipments.gloves);
            if (pf.equipments.soul == "")
                equipments.Items.Add("Soul\t: None");
            else
                equipments.Items.Add("Soul\t: " + pf.equipments.soul);
            if (pf.equipments.heart == "")
                equipments.Items.Add("Heart\t: None");
            else
                equipments.Items.Add("Heart\t: " + pf.equipments.heart);
            if (pf.equipments.talisman == "")
                equipments.Items.Add("Talisman\t: None");
            else
                equipments.Items.Add("Talisman\t: " + pf.equipments.talisman);
            if (pf.equipments.soulbadge == "")
                equipments.Items.Add("SoulBadge: None");
            else
                equipments.Items.Add("SoulBadge: " + pf.equipments.soulbadge);
            if (pf.equipments.mysticbadge == "")
                equipments.Items.Add("MystBadge: None");
            else
                equipments.Items.Add("MystBadge: " + pf.equipments.mysticbadge);
            img.ImageLocation = pf.img;

            bool blacklist = false;
            bool warning = false;
            record.Items.Clear();
            foreach (BanRecord rec in check.records)
            {
                string[] row = { rec.bancode, rec.reason, rec.url };
                var listViewItem = new ListViewItem(row);
                record.Items.Add(listViewItem);
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
        }

        private void Detail_Load(object sender, EventArgs e)
        {

        }

        private void altlist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(altlist.SelectedItem.ToString());
        }

        private void record_DoubleClick(object sender, EventArgs e)
        {
            if(record.SelectedItems.Count > 0)
            {
                var item = record.SelectedItems[0];
                string url = item.SubItems[item.SubItems.Count - 1].Text;
                System.Diagnostics.Process.Start(url);
            }
        }
    }
}
