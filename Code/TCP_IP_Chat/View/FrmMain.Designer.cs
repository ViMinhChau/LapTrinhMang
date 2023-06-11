namespace TCP_IP_Chat
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
            this.cmsOptions = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.cmsConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsClear = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.btnSend = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblServer = new MaterialSkin.Controls.MaterialLabel();
            this.txtText = new System.Windows.Forms.TextBox();
            this.pbConection = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.cmsOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConection)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsOptions
            // 
            this.cmsOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmsOptions.Depth = 0;
            this.cmsOptions.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsConnect,
            this.cmsClear,
            this.cmsDisconnect,
            this.cmsExit});
            this.cmsOptions.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(180, 132);
            this.cmsOptions.Opening += new System.ComponentModel.CancelEventHandler(this.CmsOptions_Opening);
            // 
            // cmsConnect
            // 
            this.cmsConnect.Image = global::TCP_IP_Chat.Properties.Resources.icons8_server;
            this.cmsConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmsConnect.Name = "cmsConnect";
            this.cmsConnect.Size = new System.Drawing.Size(179, 32);
            this.cmsConnect.Text = "Connect";
            this.cmsConnect.Click += new System.EventHandler(this.SwitchConnectionToolStripMenuItem_Click);
            // 
            // cmsClear
            // 
            this.cmsClear.Image = global::TCP_IP_Chat.Properties.Resources.icons8_broom;
            this.cmsClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmsClear.Name = "cmsClear";
            this.cmsClear.Size = new System.Drawing.Size(179, 32);
            this.cmsClear.Text = "Clear ";
            this.cmsClear.Click += new System.EventHandler(this.ClearConversationToolStripMenuItem_Click);
            // 
            // cmsDisconnect
            // 
            this.cmsDisconnect.Image = global::TCP_IP_Chat.Properties.Resources.icons8_broken_link;
            this.cmsDisconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmsDisconnect.Name = "cmsDisconnect";
            this.cmsDisconnect.Size = new System.Drawing.Size(179, 32);
            this.cmsDisconnect.Text = "Disconnect";
            this.cmsDisconnect.Click += new System.EventHandler(this.DisconnectToolStripMenuItem1_Click);
            // 
            // cmsExit
            // 
            this.cmsExit.Image = global::TCP_IP_Chat.Properties.Resources.icons8_shutdown;
            this.cmsExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmsExit.Name = "cmsExit";
            this.cmsExit.Size = new System.Drawing.Size(179, 32);
            this.cmsExit.Text = "Exit";
            this.cmsExit.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // rtbMessages
            // 
            this.rtbMessages.ForeColor = System.Drawing.Color.White;
            this.rtbMessages.Location = new System.Drawing.Point(18, 165);
            this.rtbMessages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.Size = new System.Drawing.Size(363, 523);
            this.rtbMessages.TabIndex = 4;
            this.rtbMessages.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Depth = 0;
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Location = new System.Drawing.Point(293, 698);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.Primary = true;
            this.btnSend.Size = new System.Drawing.Size(90, 35);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // lblServer
            // 
            this.lblServer.Depth = 0;
            this.lblServer.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblServer.Location = new System.Drawing.Point(12, 118);
            this.lblServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(282, 26);
            this.lblServer.TabIndex = 6;
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.ForeColor = System.Drawing.Color.White;
            this.txtText.Location = new System.Drawing.Point(18, 698);
            this.txtText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(267, 30);
            this.txtText.TabIndex = 10;
            this.txtText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtText_KeyPress);
            // 
            // pbConection
            // 
            this.pbConection.Image = global::TCP_IP_Chat.Properties.Resources.icons8_disconnected;
            this.pbConection.Location = new System.Drawing.Point(321, 102);
            this.pbConection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbConection.Name = "pbConection";
            this.pbConection.Size = new System.Drawing.Size(32, 32);
            this.pbConection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbConection.TabIndex = 7;
            this.pbConection.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = global::TCP_IP_Chat.Properties.Resources.icons8_menu_24px;
            this.btnMenu.Location = new System.Drawing.Point(345, 39);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(48, 42);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            this.btnMenu.MouseEnter += new System.EventHandler(this.BtnMenu_MouseEnter);
            this.btnMenu.MouseLeave += new System.EventHandler(this.BtnMenu_MouseLeave);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(397, 764);
            this.ContextMenuStrip = this.cmsOptions;
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.pbConection);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtbMessages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.cmsOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbConection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnSend;
        private MaterialSkin.Controls.MaterialContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem cmsDisconnect;
        private System.Windows.Forms.ToolStripMenuItem cmsConnect;
        private System.Windows.Forms.ToolStripMenuItem cmsExit;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ToolStripMenuItem cmsClear;
        private MaterialSkin.Controls.MaterialLabel lblServer;
        private System.Windows.Forms.PictureBox pbConection;
        private System.Windows.Forms.TextBox txtText;
    }
}

