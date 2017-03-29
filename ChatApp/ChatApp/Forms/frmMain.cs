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

        //string publicKey = "<RSAKeyValue><Modulus>6leFgSuURhJra3eo19lRDIKB005lXxjJLlXzzKDptxpj5DPZe7xfkzl6oE8hu4GWisKx+2oeEuCE/30DdxWZoVAwl9E0Toe6DhYe9UlxiqY5g7gaiYT4+MFg5+MSSi9C5ZcpWSLXb+ZxiZBF2fbvau4GmAAGYAOQ2aD3DMcAONc=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        //string privateKey = "<RSAKeyValue><Modulus>6leFgSuURhJra3eo19lRDIKB005lXxjJLlXzzKDptxpj5DPZe7xfkzl6oE8hu4GWisKx+2oeEuCE/30DdxWZoVAwl9E0Toe6DhYe9UlxiqY5g7gaiYT4+MFg5+MSSi9C5ZcpWSLXb+ZxiZBF2fbvau4GmAAGYAOQ2aD3DMcAONc=</Modulus><Exponent>AQAB</Exponent><P>7al3PRP64beX4u07Go6zVWYYDvi4JcX6mbywb0w53QK8wyffycRvzHY4UFwyCsTGxo/51POCV2JDBDdXqlPOQQ==</P><Q>/Gx5U6J663GAoNuU1a8Q9p7tTMWeo5vv3t0qVdC1Q0Bszp2ERU+D4Hru1zc39F5ULsjWlWwREAELkkRa++5xFw==</Q><DP>JNRaMhDilBALbZMt0ZPDnrxPhiJtBw2DJEflX5oEbYd7ERMgzveuC5VWbL2c06Zi12qAYMvLqxcDI6gf4blTAQ==</DP><DQ>xqHJW2HJHkrDsFD6LqhDTf5Dt5zut8o2mIYrETpZ2ODyfif/dNccbGHwXlSqaFZuIh6SlSRjzNc1ttSpUAQS4w==</DQ><InverseQ>yRtei8+pxVCZ6eulFYW9m+uROATFlDdYBVJU9zhpnk1RfUoKp6SE1BPaSJXj6IkoJY2fo16HS+ZQsaDKKTEoTA==</InverseQ><D>FGZrFla+Bn2VrATThiWCbeWHOhG8jGiYIY2qTBmD+a8f8V6ReQ6UfriwaU004WGuF8VMK4Kjkel0BS5pA1Bg5Q9FPw3DsX7ISMB6TwUIF0/Z+wK8+fj6SkGL+83XApwjJ3HhWj/kCCfp+mclMCRxElMn2ani8TP1WQHKwYqmecE=</D></RSAKeyValue>";
        public frmMain()
        {
            InitializeComponent();
            this.KeyPreview = true;
            
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            txtIPLocal.Text = getLocalIP();
            txtIPForeign.Text = getLocalIP();
            btnSend.Enabled = false;
            playSound();
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
            System.IO.Stream s = (soundID == 0) ? Properties.Resources.chime_tone : Properties.Resources.sms_alert;
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
                lbChatHistory.Items.Add("Me: " + txtMessage.Text);
                txtMessage.Clear();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
                MessageBox.Show(exc.Message+"   sendMessage");
            }
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
                    lbChatHistory.Items.Add("Other: "+receivedMessage);
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
