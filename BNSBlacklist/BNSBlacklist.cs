using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BNSBan.Resources;

namespace BNSBan
{
    public partial class BNSBlacklist : Form
    {
        private Util util = null;
        private SPCharKB keyboardForm = null;
        private ButtonImageSet searchImgSet = null;
        private ButtonImageSet detailImgSet = null;
        private Profile profile = null;
        private BanCheck check = null;
        private Settings settingsForm = null;
        public BNSBlacklist()
        {
            InitializeComponent();
            util = new Util();
            searchImgSet = new ButtonImageSet();
            searchImgSet.normal = MainWindowBtns.search_normal;
            searchImgSet.hover = MainWindowBtns.search_hover;
            detailImgSet = new ButtonImageSet();
            detailImgSet.normal = MainWindowBtns.details_normal;
            detailImgSet.hover = MainWindowBtns.details_hover;
            
        }

        private void BNSBan_Load(object sender, EventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            searchbtn.BackgroundImage = searchImgSet.hover;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            searchbtn.BackgroundImage = searchImgSet.normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (charname.Text == "")
            {
                return;
            }
            searchbtn.Enabled = false;
            profile = Profile.RetriveProfile("na", charname.Text);
            if (profile == null)
            {
                statusImg.Image = StatusImg.dne;
                detailsbtn.Visible = false;
            } else
            {
                check = BanCheck.RetriveBanRecords(profile);
                if(check == null || check.records.Count == 0)
                {
                    statusImg.Image = StatusImg.noban;
                } else
                {
                    bool blacklist = false;
                    bool warning = false;
                    foreach (BanRecord record in check.records)
                    {
                        if (record.isBan())
                        {
                            blacklist = true;
                        } else if(record.isWarning())
                        {
                            warning = true;
                        }
                    }
                    if(blacklist)
                    {
                        statusImg.Image = StatusImg.ban;
                    } else if(warning)
                    {
                        statusImg.Image = StatusImg.reported;
                    } else
                    {
                        statusImg.Image = StatusImg.noban;
                    }
                }
                
                detailsbtn.Visible = true;
            }
            resultPanel.Visible = true;
            searchbtn.Enabled = true;
        }

        private void spkb_Click(object sender, EventArgs e)
        {
            if (keyboardForm == null || keyboardForm.IsDisposed)
            {
                keyboardForm = new SPCharKB();
            }
            keyboardForm.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            detailsbtn.BackgroundImage = detailImgSet.hover;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            detailsbtn.BackgroundImage = detailImgSet.normal;
        }

        private void detailsbtn_Click(object sender, EventArgs e)
        {
            if (profile != null)
            {
                Detail detailForm = new Detail(profile, check);
                detailForm.Show();
            }
        }

        private void charname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && searchbtn.Enabled)
            {
                searchbtn.PerformClick();
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            if(settingsForm != null)
            {
                if(settingsForm.IsDisposed)
                {
                    settingsForm = new Settings();
                    settingsForm.Show();
                } else
                {
                    settingsForm.Show();
                }
            } else
            {
                settingsForm = new Settings();
                settingsForm.Show();
            }
        }
    }
}
