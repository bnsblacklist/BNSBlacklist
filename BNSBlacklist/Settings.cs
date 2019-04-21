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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            version.Text = Config.version;
            enableLocalRecd.Checked = Config.enableLocalCheck;
            localRecdDir.Text = Config.localRecordDir;
            enableNCS.Checked = Config.enableNameChangeSubmission;
            enableAD.Checked = Config.enableAutoDetect;
            screenshotDir.Text = Config.screenshotDir;
            ADgap.Text = Config.autodectectGap;
            checkupd.Checked = Config.checkUpdatesAtStart;
            autoinstall.Checked = Config.autoInstallUpdates;

        }

        private void toubns_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://us.ncsoft.com/en/legal/blade-and-soul/content-terms-of-use.php");
        }

        private void ADgap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enableLocalRecd.Checked = Config.enableLocalCheck;
            localRecdDir.Text = Config.localRecordDir;
            enableNCS.Checked = Config.enableNameChangeSubmission;
            enableAD.Checked = Config.enableAutoDetect;
            screenshotDir.Text = Config.screenshotDir;
            ADgap.Text = Config.autodectectGap;
            checkupd.Checked = Config.checkUpdatesAtStart;
            autoinstall.Checked = Config.autoInstallUpdates;
        }

        private void save_Click(object sender, EventArgs e)
        {
            Config.enableLocalCheck = enableLocalRecd.Checked;
            Config.localRecordDir = localRecdDir.Text;
            Config.enableNameChangeSubmission = enableNCS.Checked;
            Config.enableAutoDetect = enableAD.Checked;
            Config.screenshotDir = screenshotDir.Text;
            Config.autodectectGap = ADgap.Text;
            Config.checkUpdatesAtStart = checkupd.Checked;
            Config.autoInstallUpdates = autoinstall.Checked;
            Config.WriteConfig();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
