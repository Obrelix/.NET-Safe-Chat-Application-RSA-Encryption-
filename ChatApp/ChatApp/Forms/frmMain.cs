using System;
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
        public static bool encrypted = false, connected;
        public static string remotesPublicKey;
        public static string privateKey, ipLocal, ipRemote, portLocal, portRemote;
        string Username;
        int dataSize;

        frmConnection formCon = new frmConnection();
        frmRSA form = new frmRSA();

        public frmMain()
        {
            InitializeComponent();
            this.KeyPreview = true;
            playSound(2);
            Random rnd = new Random();
            txtUser.Text = "User" + rnd.Next(1, 1000);
            txtMessage.MaxLength = 100;
            dataSize = 128;
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            this.AcceptButton = btnSend;
        }
        
        

        private void btnConnect_Click(object sender, EventArgs e)
        {
            connect();
        }

        private void connect()
        {
            try
            {
                   
                    
                epLocal = new IPEndPoint(IPAddress.Parse(ipLocal), Convert.ToInt32(portLocal));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(ipRemote), Convert.ToInt32(portRemote));

                sck.Connect(epRemote);
                byte[] buffer = new byte[dataSize];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
                MessageBox.Show(exc.Message + Environment.NewLine + "Connection Error");
               
            }
        }


        private void messageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if (size > 0)
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
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
                MessageBox.Show(exc.Message + "   callBack");
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
            //if (e.KeyData == Keys.Enter && txtMessage.Text != string.Empty)
            //{
            //    sendMessage(txtMessage.Text);
            //    addText(txtMessage.Text, true);
            //}
        }

        private void playSound(int soundID = 0)
        {
            System.IO.Stream s;
            switch (soundID)
            {
                case 0:
                    s = Properties.Resources.ending;
                    break;
                case 1:
                    s = Properties.Resources.notification;
                    break;
                case 2:
                    s = Properties.Resources.welcome;
                    break;
                case 3:
                    s = Properties.Resources.ending2;
                    break;
                case 4:
                    s = Properties.Resources.goodbye;
                    break;
                case 5:
                    s = Properties.Resources.sms_alert;
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

        
        private void lblStatus_Click(object sender, EventArgs e)
        {
            frmConnection.frmActive = true;
            frmConShow();
        }

        private void mnuConnect_Click(object sender, EventArgs e)
        {
            frmConnection.frmActive = true;
            frmConShow();
        }
        private void mnuGenerate_Click(object sender, EventArgs e)
        {
            
        }

        private void frmConShow()
        {
            formCon.StartPosition = FormStartPosition.Manual;
            if (this.WindowState == FormWindowState.Maximized) formCon.Location = new Point(this.Location.X, this.Location.Y);
            else formCon.Location = new Point(this.Location.X - 200, this.Location.Y);
            //formCon.Width = this.Width;
            formCon.Show();
        }

        private void frmRSAShow()
        {
            form.StartPosition = FormStartPosition.Manual;
            if (this.WindowState == FormWindowState.Maximized) form.Location = new Point(this.Location.X, this.Location.Y);
            else form.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            //form.Width = this.Width;
            form.Show();
        }

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            if (!frmConnection.frmActive) formCon.Hide();
            if (!frmRSA.frmActive) form.Hide();

            Username = txtUser.Text;
            buttonInit();
            if (frmConnection.Connect)
            {
                connect();
                frmConnection.Connect = false;
            }
        }


        private void buttonInit()
        {
            if (sck.Connected)
            {
                lblStatus.ForeColor = Color.Green;
                btnSend.Enabled = true;
                txtMessage.Enabled = true;
                //txtMessage.Focus();
                connected = true;
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                btnSend.Enabled = false;
                txtMessage.Enabled = false;
                connected = false;
            }

        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.chat;
        }
        

        private void frmMain_LocationChanged(object sender, EventArgs e)
        {
            if (frmRSA.frmActive) frmRSAShow();
            else form.Hide();
            if (frmConnection.frmActive) frmConShow();
            else formCon.Hide();
        }

        private void mnuEncrypt_Click(object sender, EventArgs e)
        {
            frmRSA.frmActive = true;
            frmRSAShow();
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
            formCon.Close();
            form.Close();
            await Task.Delay(3000);
            flag = false;
            this.Close();
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
