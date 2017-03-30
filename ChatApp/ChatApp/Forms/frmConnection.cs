using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class frmConnection : Form
    {
        public static bool Connect = false, frmActive = false;
        public frmConnection()
        {
            InitializeComponent();

            txtIPLocal.Text = getLocalIP();
            txtIPForeign.Text = getLocalIP();
        }
        private string getLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void frmConnection_Load(object sender, EventArgs e)
        {
            frmActive = true;
            
            this.Icon = Properties.Resources.connection;
        }

        private void frmConnection_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            frmActive = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            frmMain.ipLocal = txtIPLocal.Text;
            frmMain.portLocal = txtPortLoacal.Text;
            frmMain.ipRemote = txtIPForeign.Text;
            frmMain.portRemote = txtPortForeign.Text;
            Connect = true;
            btnConnect.Enabled = false;

        }
    }
}
