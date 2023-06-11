namespace TCP_IP_Server.View
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.cmsControlServer = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.cmsCloseServer = new System.Windows.Forms.ToolStripMenuItem();
            this.txtText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSend = new MaterialSkin.Controls.MaterialRaisedButton();
            this.User = new System.Windows.Forms.ListBox();
            this.btnStart = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblUser = new MaterialSkin.Controls.MaterialLabel();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.pbStatus = new System.Windows.Forms.PictureBox();
            this.pbServer = new System.Windows.Forms.PictureBox();
            this.cmsControlServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbServer)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbMessages
            // 
            this.rtbMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMessages.ContextMenuStrip = this.cmsControlServer;
            this.rtbMessages.ForeColor = System.Drawing.Color.White;
            this.rtbMessages.Location = new System.Drawing.Point(18, 148);
            this.rtbMessages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.ShortcutsEnabled = false;
            this.rtbMessages.Size = new System.Drawing.Size(361, 424);
            this.rtbMessages.TabIndex = 3;
            this.rtbMessages.Text = "";
            // 
            // cmsControlServer
            // 
            this.cmsControlServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmsControlServer.Depth = 0;
            this.cmsControlServer.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsControlServer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCloseServer});
            this.cmsControlServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmsControlServer.Name = "cmsControlServer";
            this.cmsControlServer.Size = new System.Drawing.Size(182, 36);
            // 
            // cmsCloseServer
            // 
            this.cmsCloseServer.Enabled = false;
            this.cmsCloseServer.Name = "cmsCloseServer";
            this.cmsCloseServer.Size = new System.Drawing.Size(181, 32);
            this.cmsCloseServer.Text = "Close Server";
            this.cmsCloseServer.Click += new System.EventHandler(this.CloseServerToolStripMenuItem_Click);
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtText.ContextMenuStrip = this.cmsControlServer;
            this.txtText.Depth = 0;
            this.txtText.Hint = "";
            this.txtText.Location = new System.Drawing.Point(18, 586);
            this.txtText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtText.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtText.Name = "txtText";
            this.txtText.PasswordChar = '\0';
            this.txtText.SelectedText = "";
            this.txtText.SelectionLength = 0;
            this.txtText.SelectionStart = 0;
            this.txtText.Size = new System.Drawing.Size(363, 32);
            this.txtText.TabIndex = 4;
            this.txtText.UseSystemPasswordChar = false;
            this.txtText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtText_KeyPress);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Depth = 0;
            this.btnSend.Location = new System.Drawing.Point(424, 583);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.Primary = true;
            this.btnSend.Size = new System.Drawing.Size(113, 35);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click_1);
            // 
            // User
            // 
            this.User.FormattingEnabled = true;
            this.User.ItemHeight = 20;
            this.User.Location = new System.Drawing.Point(424, 148);
            this.User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(240, 404);
            this.User.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Depth = 0;
            this.btnStart.Location = new System.Drawing.Point(545, 583);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStart.Name = "btnStart";
            this.btnStart.Primary = true;
            this.btnStart.Size = new System.Drawing.Size(120, 35);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lblUser
            // 
            this.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUser.ContextMenuStrip = this.cmsControlServer;
            this.lblUser.Depth = 0;
            this.lblUser.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUser.Location = new System.Drawing.Point(424, 108);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(240, 37);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "List Client\'s IP";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtServer
            // 
            this.txtServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServer.ContextMenuStrip = this.cmsControlServer;
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtServer.ForeColor = System.Drawing.Color.White;
            this.txtServer.Location = new System.Drawing.Point(18, 108);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(362, 32);
            this.txtServer.TabIndex = 10;
            this.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbStatus
            // 
            this.pbStatus.Image = global::TCP_IP_Server.Properties.Resources.icons8_100_;
            this.pbStatus.Location = new System.Drawing.Point(111, 42);
            this.pbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(32, 32);
            this.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbStatus.TabIndex = 12;
            this.pbStatus.TabStop = false;
            // 
            // pbServer
            // 
            this.pbServer.Image = global::TCP_IP_Server.Properties.Resources.icons8_server;
            this.pbServer.Location = new System.Drawing.Point(578, 42);
            this.pbServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbServer.Name = "pbServer";
            this.pbServer.Size = new System.Drawing.Size(32, 32);
            this.pbServer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbServer.TabIndex = 11;
            this.pbServer.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(683, 629);
            this.ContextMenuStrip = this.cmsControlServer;
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.pbServer);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.User);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.rtbMessages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.cmsControlServer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbServer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMessages;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtText;
        private MaterialSkin.Controls.MaterialRaisedButton btnSend;
        private System.Windows.Forms.ListBox User;
        private MaterialSkin.Controls.MaterialRaisedButton btnStart;
        private MaterialSkin.Controls.MaterialLabel lblUser;
        private System.Windows.Forms.TextBox txtServer;
        private MaterialSkin.Controls.MaterialContextMenuStrip cmsControlServer;
        private System.Windows.Forms.ToolStripMenuItem cmsCloseServer;
        private System.Windows.Forms.PictureBox pbServer;
        private System.Windows.Forms.PictureBox pbStatus;
    }
}