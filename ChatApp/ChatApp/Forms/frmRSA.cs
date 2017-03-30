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
    public partial class frmRSA : Form
    {
        public static bool frmActive = false;
        

        public frmRSA()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string publicKey;
            RSATools.GenerateKeys(out publicKey, out frmMain.privateKey);
            txtPublic.Text = publicKey;
            txtPrivate.Text = frmMain.privateKey;
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

        private void btnActivate_Click(object sender, EventArgs e)
        {
            frmMain.encrypted = !frmMain.encrypted;
            btnActivate.Text = (!frmMain.encrypted) ? "Activate Encryption" : "Deactivate Encryption";
            frmMain.remotesPublicKey = txtRemotesPublic.Text;
            //dataSize = (encrypted) ? 128 : 1500;
            //txtMessage.MaxLength = (encrypted) ? 100 : 1480;
            //if (encrypted) MessageBox.Show("Message length decreasing to 100 characters per message!!", "Message Length Decreased", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
