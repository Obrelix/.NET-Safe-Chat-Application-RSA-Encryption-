using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class frmGenerateKeys : Form
    {
        public static bool frmActive = false;
        public static string privateKey;

        public frmGenerateKeys()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string publicKey;
            RSATools.GenerateKeys(out publicKey, out privateKey);
            txtPublic.Text = publicKey;
            txtPrivate.Text = privateKey;
        }

        private void frmGenerateKeys_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            frmActive = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void frmGenerateKeys_Load(object sender, EventArgs e)
        {
            frmActive = true;
            this.Icon = Properties.Resources.key;
        }
    }
}
