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

namespace BNSBan
{
    public partial class AutoDetectForm : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private bool enable = false;
        private bool f2enable = false;
        private bool partyenable = false;
        private int gap = 15;
        private Util adutil;
        public AutoDetectForm()
        {
            InitializeComponent();
            adutil = new Util();
            resetTimer_Tick(null, null);
            resetTimer.Enabled = true;
        }

        private void AutoDetectForm_Load(object sender, EventArgs e)
        {

        }

        private void autoDetectTimer_Tick(object sender, EventArgs e)
        {
            tprogress.Value = 0;
            if (f2enable)
            {
                string f2result = adutil.DetectDetailPage();
                if(f2result != "" && f2result.Contains('[') && f2result.Contains(']'))
                {
                    int lbindex = f2result.IndexOf('[');
                    int rbindex = f2result.IndexOf(']');
                    f2result = f2result.Substring(lbindex + 1, rbindex - lbindex - 1);
                    recent.Text = f2result;
                }
            }
            
        }

        private void resetTimer_Tick(object sender, EventArgs e)
        {
            if (enable)
            {
                tprogress.Value += 100 / gap;
            } else
            {
                tprogress.Value = 0;
            }
            if (f2enable != Config.enableAutoDetect)
            {
                f2enable = Config.enableAutoDetect;
                if (f2enable)
                {
                    F2SurviceStatus.Image = AutoDetect.on;
                }
                else
                {
                    F2SurviceStatus.Image = AutoDetect.off;
                }
            }

            if (partyenable != Config.enableAutoDetect)
            {
                partyenable = Config.enableAutoDetect;
                if (partyenable)
                {
                    PartyProfileStatus.Image = AutoDetect.on;
                }
                else
                {
                    PartyProfileStatus.Image = AutoDetect.off;
                }
            }

            if (gap != int.Parse(Config.autodectectGap))
            {
                gap = int.Parse(Config.autodectectGap);
                autoDetectTimer.Enabled = false;
                autoDetectTimer.Interval = gap;
                tprogress.Value = 0;
                autoDetectTimer.Enabled = true;
            }

            if(enable != f2enable | partyenable)
            {
                enable = f2enable | partyenable;
                if(enable)
                {
                    autoDetectTimer.Enabled = true;
                } else
                {
                    autoDetectTimer.Enabled = false;
                    tprogress.Value = 0;
                }
            }
        }

        private void recent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(recent.Text == "No Detection Result")
            {
                return;
            }
            characterName.Text = recent.Text;
            Clipboard.SetText(recent.Text);
        }
    }
}
