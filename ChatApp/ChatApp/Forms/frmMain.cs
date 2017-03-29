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
        string Username;

        public frmMain()
        {
            InitializeComponent();
            this.KeyPreview = true;
            
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            txtIPLocal.Text = getLocalIP();
            txtIPForeign.Text = getLocalIP();
            btnSend.Enabled = false;
            playSound(2);
            Random rnd = new Random();
            txtUserName.Text = "User" + rnd.Next(1, 1000);

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
            connect();
            //Username = txtUserName.Text;
            //txtUserName.Enabled = false;
        }

        private void connect()
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
                sck.Disconnect(false);
                btnConnect.Text = "Connect";
                btnConnect.Enabled = true;
                btnSend.Enabled = false;
                Debug.WriteLine(exc.Message);
                MessageBox.Show(exc.Message + Environment.NewLine + "Connection Error");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sendMessage(txtMessage.Text);
            addText(txtMessage.Text, true);
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

        private void sendMessage( string txtmessage)
        {
            try
            {
                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] msg = new byte[128];
                msg = enc.GetBytes(Username + "</User>" + txtmessage);
                if (encrypted) msg = RSATools.RSAEncrypt(msg, txtRemotesPublic.Text, false);
                sck.Send(msg);
                
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
                rtxtHistory.AppendText(Environment.NewLine + "[" + DateTime.Now.ToShortTimeString().Replace(" ","") + "] Me:  "+ txt );
                rtxtHistory.SelectionAlignment = HorizontalAlignment.Left ;
            }
            else
            {
                rtxtHistory.Select(rtxtHistory.TextLength, 0);
                rtxtHistory.SelectionColor = Color.Red;
                rtxtHistory.AppendText(Environment.NewLine + "[" + DateTime.Now.ToShortTimeString().Replace(" ", "") + "] " +
                    txt.Split(new string[] { "</User>" }, StringSplitOptions.None).First() + ":  " + 
                    txt.Split(new string[] { "</User>" }, StringSplitOptions.None).Last());
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
                sendMessage(txtMessage.Text);
                addText(txtMessage.Text, true);
            }
        }
        


        private void btnActivate_Click(object sender, EventArgs e)
        {
            encrypted = !encrypted;
            btnActivate.Text = (!encrypted) ? "Activate Encryption" : "Deactivate Encryption";
        }
        frmGenerateKeys form = new frmGenerateKeys();

        private void mnuGenerate_Click(object sender, EventArgs e)
        {
            frmGenerateKeys.frmActive = true;
            frmGenerateShow();
        }

        private void frmGenerateShow()
        {
            form.StartPosition = FormStartPosition.Manual;
            if (this.WindowState == FormWindowState.Maximized) form.Location = new Point(this.Location.X, this.Location.Y);
            else form.Location = new Point(this.Location.X, this.Location.Y + this.Height);
            form.Width = this.Width;
            form.Show();
        }

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            if (frmGenerateKeys.frmActive) txtUsersPrivate.Text = frmGenerateKeys.privateKey;
            else form.Hide();
            Username = txtUserName.Text;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.chat;
        }
        

        private void frmMain_LocationChanged(object sender, EventArgs e)
        {
            if (frmGenerateKeys.frmActive) frmGenerateShow();
            else form.Hide();
        }

        private void mnuProperties_CheckedChanged(object sender, EventArgs e)
        {
            pnlProperties.Visible = mnuProperties.Checked;
            if (!mnuProperties.Checked)
            {
                rtxtHistory.Location = new Point(rtxtHistory.Location.X , rtxtHistory.Location.Y - 150);
                rtxtHistory.Height += 150;
            }
            else
            {
                rtxtHistory.Location = new Point(rtxtHistory.Location.X, rtxtHistory.Location.Y + 150);
                rtxtHistory.Height -= 150;
            }
            
            
        }

        private void mnuProperties_Click(object sender, EventArgs e)
        {
            mnuProperties.Checked = !mnuProperties.Checked;
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
