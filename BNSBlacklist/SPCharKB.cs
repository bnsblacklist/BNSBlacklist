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
    public partial class SPCharKB : Form
    {
        public SPCharKB()
        {
            InitializeComponent();
            altlist.Clear();
            foreach (char key in AltCode.alttable.Keys)
            {
                altlist.Items.Add(key.ToString());
            }
        }

        private void SPCharKB_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Key Down " + (char)e.KeyCode);
            if (Char.IsLetter((char)e.KeyCode))
            {
                keyShow.Text = ((char)e.KeyCode).ToString();
            }
        }

        private void keyShow_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Key Changed To " + keyShow.Text);
            altlist.Items.Clear();
            if (AltCode.alttable.ContainsKey(keyShow.Text.ToCharArray()[0]))
            {
                foreach (char c in AltCode.alttable[keyShow.Text.ToCharArray()[0]])
                {
                    altlist.Items.Add(c.ToString());
                }
            }
        }

        private void keyShow_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Key Down " + (char)e.KeyCode);
            if (Char.IsLetterOrDigit((char)e.KeyCode) || Char.IsSymbol((char)e.KeyCode))
            {
                keyShow.Text = ((char)e.KeyCode).ToString();
            }
        }

        private void SPCharKB_Load(object sender, EventArgs e)
        {

        }

        private void altlist_DoubleClick(object sender, EventArgs e)
        {
            if(altlist.SelectedItems.Count > 0)
            {
                Clipboard.SetText(altlist.SelectedItems[0].Text);
            }
        }
    }
}
