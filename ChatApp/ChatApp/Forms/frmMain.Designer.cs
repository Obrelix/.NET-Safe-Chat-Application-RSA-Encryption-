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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnActivate = new System.Windows.Forms.Button();
            this.txtRemotesPublic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsersPrivate = new System.Windows.Forms.TextBox();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerateKeys = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.generateKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPortLoacal);
            this.groupBox1.Controls.Add(this.txtIPLocal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox1.Location = new System.Drawing.Point(44, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP:";
            // 
            // txtPortLoacal
            // 
            this.txtPortLoacal.Location = new System.Drawing.Point(99, 45);
            this.txtPortLoacal.Name = "txtPortLoacal";
            this.txtPortLoacal.Size = new System.Drawing.Size(40, 22);
            this.txtPortLoacal.TabIndex = 1;
            this.txtPortLoacal.Text = "80";
            this.txtPortLoacal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIPLocal
            // 
            this.txtIPLocal.Location = new System.Drawing.Point(52, 19);
            this.txtIPLocal.Name = "txtIPLocal";
            this.txtIPLocal.Size = new System.Drawing.Size(87, 22);
            this.txtIPLocal.TabIndex = 0;
            this.txtIPLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbChatHistory
            // 
            this.lbChatHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbChatHistory.Font = new System.Drawing.Font("Cooper Std Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChatHistory.FormattingEnabled = true;
            this.lbChatHistory.ItemHeight = 20;
            this.lbChatHistory.Location = new System.Drawing.Point(44, 221);
            this.lbChatHistory.Name = "lbChatHistory";
            this.lbChatHistory.Size = new System.Drawing.Size(646, 184);
            this.lbChatHistory.TabIndex = 5;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnConnect.Location = new System.Drawing.Point(44, 185);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(150, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtMessage.Location = new System.Drawing.Point(44, 417);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(463, 22);
            this.txtMessage.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnSend.Location = new System.Drawing.Point(513, 417);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(177, 23);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPortForeign);
            this.groupBox2.Controls.Add(this.txtIPForeign);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox2.Location = new System.Drawing.Point(44, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Foreign";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "IP:";
            // 
            // txtPortForeign
            // 
            this.txtPortForeign.Location = new System.Drawing.Point(99, 45);
            this.txtPortForeign.Name = "txtPortForeign";
            this.txtPortForeign.Size = new System.Drawing.Size(38, 22);
            this.txtPortForeign.TabIndex = 1;
            this.txtPortForeign.Text = "80";
            this.txtPortForeign.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIPForeign
            // 
            this.txtIPForeign.Location = new System.Drawing.Point(52, 19);
            this.txtIPForeign.Name = "txtIPForeign";
            this.txtIPForeign.Size = new System.Drawing.Size(85, 22);
            this.txtIPForeign.TabIndex = 0;
            this.txtIPForeign.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnActivate);
            this.groupBox3.Controls.Add(this.txtRemotesPublic);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtUsersPrivate);
            this.groupBox3.Location = new System.Drawing.Point(200, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 172);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Keys";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Remote User\'s Public Key";
            // 
            // btnActivate
            // 
            this.btnActivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnActivate.Location = new System.Drawing.Point(313, 140);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(171, 26);
            this.btnActivate.TabIndex = 12;
            this.btnActivate.Text = "Activate Encryption";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // txtRemotesPublic
            // 
            this.txtRemotesPublic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemotesPublic.Location = new System.Drawing.Point(6, 114);
            this.txtRemotesPublic.MaxLength = 327670;
            this.txtRemotesPublic.Name = "txtRemotesPublic";
            this.txtRemotesPublic.PasswordChar = '*';
            this.txtRemotesPublic.Size = new System.Drawing.Size(478, 20);
            this.txtRemotesPublic.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "User\'s Private Key";
            // 
            // txtUsersPrivate
            // 
            this.txtUsersPrivate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsersPrivate.Location = new System.Drawing.Point(6, 38);
            this.txtUsersPrivate.MaxLength = 327670;
            this.txtUsersPrivate.Name = "txtUsersPrivate";
            this.txtUsersPrivate.PasswordChar = '*';
            this.txtUsersPrivate.Size = new System.Drawing.Size(478, 20);
            this.txtUsersPrivate.TabIndex = 9;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // mnuGenerateKeys
            // 
            this.mnuGenerateKeys.Name = "mnuGenerateKeys";
            this.mnuGenerateKeys.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.DimGray;
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem2,
            this.menuToolStripMenuItem3});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(736, 25);
            this.mnuMain.TabIndex = 16;
            this.mnuMain.Text = "mnuMain";
            // 
            // menuToolStripMenuItem2
            // 
            this.menuToolStripMenuItem2.Name = "menuToolStripMenuItem2";
            this.menuToolStripMenuItem2.Size = new System.Drawing.Size(12, 21);
            // 
            // mnuGenerate
            // 
            this.mnuGenerate.Name = "mnuGenerate";
            this.mnuGenerate.Size = new System.Drawing.Size(163, 22);
            this.mnuGenerate.Text = "&Generate Keys";
            this.mnuGenerate.Click += new System.EventHandler(this.mnuGenerate_Click);
            // 
            // menuToolStripMenuItem3
            // 
            this.menuToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateKeysToolStripMenuItem});
            this.menuToolStripMenuItem3.Name = "menuToolStripMenuItem3";
            this.menuToolStripMenuItem3.Size = new System.Drawing.Size(55, 21);
            this.menuToolStripMenuItem3.Text = "&Menu";
            // 
            // generateKeysToolStripMenuItem
            // 
            this.generateKeysToolStripMenuItem.Name = "generateKeysToolStripMenuItem";
            this.generateKeysToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.generateKeysToolStripMenuItem.Text = "&Generate Keys";
            this.generateKeysToolStripMenuItem.Click += new System.EventHandler(this.mnuGenerate_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(736, 451);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lbChatHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Safe Chat";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsersPrivate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemotesPublic;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateKeys;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerate;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem generateKeysToolStripMenuItem;
    }
}

