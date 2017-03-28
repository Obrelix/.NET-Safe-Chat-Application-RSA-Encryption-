namespace ChatApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPortLoacal = new System.Windows.Forms.TextBox();
            this.txtIPLocal = new System.Windows.Forms.TextBox();
            this.lbChatHistory = new System.Windows.Forms.ListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPortForeign = new System.Windows.Forms.TextBox();
            this.txtIPForeign = new System.Windows.Forms.TextBox();
            this.chbAddEncryption = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPortLoacal);
            this.groupBox1.Controls.Add(this.txtIPLocal);
            this.groupBox1.Location = new System.Drawing.Point(44, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP:";
            // 
            // txtPortLoacal
            // 
            this.txtPortLoacal.Location = new System.Drawing.Point(109, 45);
            this.txtPortLoacal.Name = "txtPortLoacal";
            this.txtPortLoacal.Size = new System.Drawing.Size(30, 20);
            this.txtPortLoacal.TabIndex = 1;
            this.txtPortLoacal.Text = "80";
            this.txtPortLoacal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIPLocal
            // 
            this.txtIPLocal.Location = new System.Drawing.Point(64, 19);
            this.txtIPLocal.Name = "txtIPLocal";
            this.txtIPLocal.Size = new System.Drawing.Size(75, 20);
            this.txtIPLocal.TabIndex = 0;
            this.txtIPLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbChatHistory
            // 
            this.lbChatHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbChatHistory.FormattingEnabled = true;
            this.lbChatHistory.Location = new System.Drawing.Point(44, 120);
            this.lbChatHistory.Name = "lbChatHistory";
            this.lbChatHistory.Size = new System.Drawing.Size(488, 160);
            this.lbChatHistory.TabIndex = 5;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(384, 38);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(148, 20);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Location = new System.Drawing.Point(44, 286);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(334, 20);
            this.txtMessage.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(384, 286);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(148, 20);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPortForeign);
            this.groupBox2.Controls.Add(this.txtIPForeign);
            this.groupBox2.Location = new System.Drawing.Point(199, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 79);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Foreign";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "IP:";
            // 
            // txtPortForeign
            // 
            this.txtPortForeign.Location = new System.Drawing.Point(107, 45);
            this.txtPortForeign.Name = "txtPortForeign";
            this.txtPortForeign.Size = new System.Drawing.Size(30, 20);
            this.txtPortForeign.TabIndex = 1;
            this.txtPortForeign.Text = "80";
            this.txtPortForeign.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIPForeign
            // 
            this.txtIPForeign.Location = new System.Drawing.Point(62, 19);
            this.txtIPForeign.Name = "txtIPForeign";
            this.txtIPForeign.Size = new System.Drawing.Size(75, 20);
            this.txtIPForeign.TabIndex = 0;
            this.txtIPForeign.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chbAddEncryption
            // 
            this.chbAddEncryption.AutoSize = true;
            this.chbAddEncryption.Location = new System.Drawing.Point(384, 67);
            this.chbAddEncryption.Name = "chbAddEncryption";
            this.chbAddEncryption.Size = new System.Drawing.Size(98, 17);
            this.chbAddEncryption.TabIndex = 10;
            this.chbAddEncryption.Text = "Add Encryption";
            this.chbAddEncryption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbAddEncryption.UseVisualStyleBackColor = true;
            this.chbAddEncryption.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 320);
            this.Controls.Add(this.chbAddEncryption);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lbChatHistory);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Safe Chat";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPortLoacal;
        private System.Windows.Forms.TextBox txtIPLocal;
        private System.Windows.Forms.ListBox lbChatHistory;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPortForeign;
        private System.Windows.Forms.TextBox txtIPForeign;
        private System.Windows.Forms.CheckBox chbAddEncryption;
    }
}

