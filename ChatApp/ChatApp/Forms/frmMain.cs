using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Media;

namespace ChatApp
{
    public partial class frmMain : Form
    {
        Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        EndPoint epLocal, epRemote;
        public static bool encrypted = false;

        public frmMain()
        {
            InitializeComponent();
            this.KeyPreview = true;
            
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            txtIPLocal.Text = getLocalIP();
            txtIPForeign.Text = getLocalIP();
            btnSend.Enabled = false;
            playSound(2);
        }
        
        private string getLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(txtIPLocal.Text), Convert.ToInt32(txtPortLoacal.Text));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(txtIPForeign.Text), Convert.ToInt32(txtPortForeign.Text));

                sck.Connect(epRemote);
                byte[] buffer = new byte[128];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);
                btnConnect.Text = "Connected";
                btnConnect.Enabled = false;
                btnSend.Enabled = true;
                txtMessage.Focus();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
                MessageBox.Show(exc.Message + "   Connect");
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sendMessage();
        }

        private void playSound(int soundID = 0)
        {
            System.IO.Stream s;
            switch (soundID)
            {
                case 0:
                    s = Properties.Resources.chime_tone;
                    break;
                case 1:
                    s = Properties.Resources.sms_alert;
                    break;
                case 2:
                    s = Properties.Resources.iv_notification;
                    break;
                case 3:
                    s = Properties.Resources.alert;
                    break;
                default:
                    s = Properties.Resources.sms_alert;
                    break;
            }
            SoundPlayer player = new SoundPlayer(s);
            player.Play();
        }

        private void sendMessage()
        {
            try
            {
                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] msg = new byte[128];
                msg = enc.GetBytes(txtMessage.Text);
                if (encrypted) msg = RSATools.RSAEncrypt(msg, txtRemotesPublic.Text, false);
                sck.Send(msg);
                addText(txtMessage.Text, true);
                
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
                MessageBox.Show(exc.Message+"   sendMessage");
            }
        }

        private void addText(string txt, bool me)
        {
            if (me)
            {
                rtxtHistory.Select(rtxtHistory.TextLength, 0);
                rtxtHistory.SelectionColor = Color.Green;
                rtxtHistory.AppendText(Environment.NewLine + "[" + DateTime.Now.ToShortTimeString().Replace(" ","") + "] Me:  " + txt );
                rtxtHistory.SelectionAlignment = HorizontalAlignment.Left ;
            }
            else
            {
                rtxtHistory.Select(rtxtHistory.TextLength, 0);
                rtxtHistory.SelectionColor = Color.Red;
                rtxtHistory.AppendText(Environment.NewLine + "[" + DateTime.Now.ToShortTimeString().Replace(" ", "") + "] Other:  " + txt);
                rtxtHistory.SelectionAlignment = HorizontalAlignment.Left;
            }
            rtxtHistory.SelectionStart = rtxtHistory.Text.Length;
            rtxtHistory.ScrollToCaret();
            txtMessage.Clear();
            txtMessage.Focus();
        }


        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                sendMessage();
            }
        }
        


        private void btnActivate_Click(object sender, EventArgs e)
        {
            encrypted = !encrypted;
            btnActivate.Text = (!encrypted) ? "Activate Encryption" : "Deactivate Encryption";
        }

        private void mnuGenerate_Click(object sender, EventArgs e)
        {
            frmGenerateKeys form = new frmGenerateKeys();
            form.Show();
        }

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            if (frmGenerateKeys.frmActive) txtUsersPrivate.Text = frmGenerateKeys.privateKey;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.chat;
        }

        private void rtxtHistory_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void messageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if(size > 0)
                {
                    byte[] receivedData = (byte[])aResult.AsyncState;
                    if (encrypted) receivedData = RSATools.RSADecrypt(receivedData, txtUsersPrivate.Text, false);
                    ASCIIEncoding eEnconding = new ASCIIEncoding();
                    string receivedMessage = eEnconding.GetString(receivedData);
                    addText(receivedMessage, false);
                    playSound(1);
                }
                byte[] buffer = new byte[128];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);
            }
            catch(Exception exc)
            {
                Debug.WriteLine(exc.Message);
                MessageBox.Show(exc.Message + "   callBack");
            }

        }

    }
}
