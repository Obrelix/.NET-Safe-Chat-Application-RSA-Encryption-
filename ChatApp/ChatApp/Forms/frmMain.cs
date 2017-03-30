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
using System.Threading;

namespace ChatApp
{
    public partial class frmMain : Form
    {
        Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        EndPoint epLocal, epRemote;
        public static bool encrypted = false;
        public static string remotesPublicKey;
        public static string privateKey;
        string Username;
        int dataSize;

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
            txtMessage.MaxLength = 100;
            dataSize = 128;
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
        }

        private void connect()
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(txtIPLocal.Text), Convert.ToInt32(txtPortLoacal.Text));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(txtIPForeign.Text), Convert.ToInt32(txtPortForeign.Text));

                sck.Connect(epRemote);
                byte[] buffer = new byte[dataSize];
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
            if(txtMessage.Text != string.Empty)
            {
                sendMessage(txtMessage.Text);
                addText(txtMessage.Text, true);
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txtMessage.Text != string.Empty)
            {
                sendMessage(txtMessage.Text);
                addText(txtMessage.Text, true);
            }
        }

        private void playSound(int soundID = 0)
        {
            System.IO.Stream s;
            switch (soundID)
            {
                case 0:
                    s = Properties.Resources.goodbye;
                    break;
                case 1:
                    s = Properties.Resources.sms_alert;
                    break;
                case 2:
                    s = Properties.Resources.welcome;
                    break;
                //case 3:
                //    s = Properties.Resources.alert;
                //    break;
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
                byte[] msg = new byte[dataSize];
                msg = enc.GetBytes(Username + "</User>" + txtmessage);
                if (encrypted) msg = RSATools.RSAEncrypt(msg, remotesPublicKey, false);
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
                rtxtHistory.AppendText("[" + DateTime.Now.ToShortTimeString() + "]", Color.Black);
                rtxtHistory.AppendText(" ");
                rtxtHistory.AppendText(Username, Color.DarkGreen);
                rtxtHistory.AppendText(": ");
                rtxtHistory.AppendText(txt, Color.Green);
                rtxtHistory.AppendText(Environment.NewLine);
            }
            else
            {
                rtxtHistory.AppendText("[" + DateTime.Now.ToShortTimeString() + "]", Color.Black);
                rtxtHistory.AppendText(" ");
                rtxtHistory.AppendText(txt.Split(new string[] { "</User>" }, StringSplitOptions.None).First(), Color.DarkOrange);
                rtxtHistory.AppendText(": "); 
                rtxtHistory.AppendText(txt.Split(new string[] { "</User>" }, StringSplitOptions.None).Last(), Color.Orange);
                rtxtHistory.AppendText(Environment.NewLine);
            }
            rtxtHistory.SelectionStart = rtxtHistory.Text.Length;
            rtxtHistory.ScrollToCaret();
            txtMessage.Clear();
            txtMessage.Focus();
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
            else form.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            //form.Width = this.Width;
            form.Show();
        }

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            if (frmGenerateKeys.frmActive) frmGenerateShow();
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
                rtxtHistory.Location = new Point(rtxtHistory.Location.X , rtxtHistory.Location.Y - 75);
                rtxtHistory.Height += 75;
            }
            else
            {
                rtxtHistory.Location = new Point(rtxtHistory.Location.X, rtxtHistory.Location.Y + 75);
                rtxtHistory.Height -= 75;
            }
            
            
        }

        private void mnuProperties_Click(object sender, EventArgs e)
        {
            mnuProperties.Checked = !mnuProperties.Checked;
        }
        bool flag = true;
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            WaitSomeTime();
            e.Cancel = flag;
            
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //var thread = new Thread(DoTask)
            //{
            //    IsBackground = false,
            //    Name = "Closing thread.",
            //};
            //thread.Start();

            //base.OnFormClosed(e);
        }
        public async void WaitSomeTime()
        {
            playSound(0);
            await Task.Delay(3000);
            flag = false;
            Application.Exit();
        }

        private void messageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if(size > 0)
                {
                    byte[] receivedData = (byte[])aResult.AsyncState;
                    if (encrypted) receivedData = RSATools.RSADecrypt(receivedData, privateKey, false);
                    ASCIIEncoding eEnconding = new ASCIIEncoding();
                    string receivedMessage = eEnconding.GetString(receivedData);
                    addText(receivedMessage, false);
                    playSound(1);
                }
                byte[] buffer = new byte[dataSize];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);
            }
            catch(Exception exc)
            {
                Debug.WriteLine(exc.Message);
                MessageBox.Show(exc.Message + "   callBack");
            }

        }

    }

    public static class RichTextBoxExtensions
    {

        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
