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
        public frmGenerateKeys()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string publicKey, privateKey;
            RSATools.GenerateKeys(out publicKey, out privateKey);
            txtPublic.Text = publicKey;
            txtPrivate.Text = privateKey;
        }
    }
}
