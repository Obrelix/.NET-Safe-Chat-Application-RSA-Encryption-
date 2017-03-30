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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPortLoacal = new System.Windows.Forms.TextBox();
            this.txtIPLocal = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPortForeign = new System.Windows.Forms.TextBox();
            this.txtIPForeign = new System.Windows.Forms.TextBox();
            this.tmrCheck = new System.Windows.Forms.Timer(this.components);
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.rtxtHistory = new System.Windows.Forms.RichTextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlProperties = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.pnlProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPortLoacal);
            this.groupBox1.Controls.Add(this.txtIPLocal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local Chat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP:";
            // 
            // txtPortLoacal
            // 
            this.txtPortLoacal.Location = new System.Drawing.Point(83, 42);
            this.txtPortLoacal.Name = "txtPortLoacal";
            this.txtPortLoacal.Size = new System.Drawing.Size(56, 22);
            this.txtPortLoacal.TabIndex = 1;
            this.txtPortLoacal.Text = "80";
            this.txtPortLoacal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIPLocal
            // 
            this.txtIPLocal.Location = new System.Drawing.Point(35, 16);
            this.txtIPLocal.Name = "txtIPLocal";
            this.txtIPLocal.Size = new System.Drawing.Size(104, 22);
            this.txtIPLocal.TabIndex = 0;
            this.txtIPLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnConnect.Location = new System.Drawing.Point(291, 43);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(104, 28);
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
            this.txtMessage.Location = new System.Drawing.Point(44, 348);
            this.txtMessage.MaxLength = 100;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(398, 22);
            this.txtMessage.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnSend.Location = new System.Drawing.Point(448, 347);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(150, 25);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPortForeign);
            this.groupBox2.Controls.Add(this.txtIPForeign);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(401, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remote Chat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "IP:";
            // 
            // txtPortForeign
            // 
            this.txtPortForeign.Location = new System.Drawing.Point(83, 42);
            this.txtPortForeign.Name = "txtPortForeign";
            this.txtPortForeign.Size = new System.Drawing.Size(54, 22);
            this.txtPortForeign.TabIndex = 1;
            this.txtPortForeign.Text = "80";
            this.txtPortForeign.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIPForeign
            // 
            this.txtIPForeign.Location = new System.Drawing.Point(35, 16);
            this.txtIPForeign.Name = "txtIPForeign";
            this.txtIPForeign.Size = new System.Drawing.Size(102, 22);
            this.txtIPForeign.TabIndex = 0;
            this.txtIPForeign.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tmrCheck
            // 
            this.tmrCheck.Enabled = true;
            this.tmrCheck.Tick += new System.EventHandler(this.tmrCheck_Tick);
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.DarkGray;
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(644, 25);
            this.mnuMain.TabIndex = 16;
            this.mnuMain.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGenerate,
            this.mnuProperties});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.menuToolStripMenuItem.Text = "&Menu";
            // 
            // mnuGenerate
            // 
            this.mnuGenerate.Name = "mnuGenerate";
            this.mnuGenerate.Size = new System.Drawing.Size(171, 22);
            this.mnuGenerate.Text = "&RSA Encryption";
            this.mnuGenerate.Click += new System.EventHandler(this.mnuGenerate_Click);
            // 
            // mnuProperties
            // 
            this.mnuProperties.Checked = true;
            this.mnuProperties.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuProperties.Name = "mnuProperties";
            this.mnuProperties.Size = new System.Drawing.Size(171, 22);
            this.mnuProperties.Text = "&Properties";
            this.mnuProperties.CheckedChanged += new System.EventHandler(this.mnuProperties_CheckedChanged);
            this.mnuProperties.Click += new System.EventHandler(this.mnuProperties_Click);
            // 
            // rtxtHistory
            // 
            this.rtxtHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtHistory.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtHistory.Location = new System.Drawing.Point(44, 110);
            this.rtxtHistory.Name = "rtxtHistory";
            this.rtxtHistory.ReadOnly = true;
            this.rtxtHistory.Size = new System.Drawing.Size(554, 235);
            this.rtxtHistory.TabIndex = 13;
            this.rtxtHistory.Text = "";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtUserName.Location = new System.Drawing.Point(159, 45);
            this.txtUserName.MaxLength = 8;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(98, 22);
            this.txtUserName.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(159, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "User Name";
            // 
            // pnlProperties
            // 
            this.pnlProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProperties.Controls.Add(this.label7);
            this.pnlProperties.Controls.Add(this.groupBox1);
            this.pnlProperties.Controls.Add(this.btnConnect);
            this.pnlProperties.Controls.Add(this.txtUserName);
            this.pnlProperties.Controls.Add(this.groupBox2);
            this.pnlProperties.Location = new System.Drawing.Point(44, 31);
            this.pnlProperties.Name = "pnlProperties";
            this.pnlProperties.Size = new System.Drawing.Size(554, 75);
            this.pnlProperties.TabIndex = 18;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(644, 382);
            this.Controls.Add(this.pnlProperties);
            this.Controls.Add(this.rtxtHistory);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.MinimumSize = new System.Drawing.Size(660, 280);
            this.Name = "frmMain";
            this.Text = "Safe Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.LocationChanged += new System.EventHandler(this.frmMain_LocationChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlProperties.ResumeLayout(false);
            this.pnlProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPortLoacal;
        private System.Windows.Forms.TextBox txtIPLocal;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPortForeign;
        private System.Windows.Forms.TextBox txtIPForeign;
        private System.Windows.Forms.Timer tmrCheck;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerate;
        private System.Windows.Forms.RichTextBox rtxtHistory;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlProperties;
        private System.Windows.Forms.ToolStripMenuItem mnuProperties;
    }
}

