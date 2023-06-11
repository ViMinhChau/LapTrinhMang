namespace TCP_IP_Chat
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNickName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnExit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEnter = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtServer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblServer = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 114);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(115, 27);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "NameUser";
            // 
            // txtNickName
            // 
            this.txtNickName.Depth = 0;
            this.txtNickName.Hint = "";
            this.txtNickName.Location = new System.Drawing.Point(18, 148);
            this.txtNickName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNickName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.PasswordChar = '\0';
            this.txtNickName.SelectedText = "";
            this.txtNickName.SelectionLength = 0;
            this.txtNickName.SelectionStart = 0;
            this.txtNickName.Size = new System.Drawing.Size(363, 32);
            this.txtNickName.TabIndex = 1;
            this.txtNickName.UseSystemPasswordChar = false;
            this.txtNickName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNickName_KeyPress);
            // 
            // btnExit
            // 
            this.btnExit.Depth = 0;
            this.btnExit.Location = new System.Drawing.Point(268, 278);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Primary = true;
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Depth = 0;
            this.btnEnter.Location = new System.Drawing.Point(147, 278);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Primary = true;
            this.btnEnter.Size = new System.Drawing.Size(112, 35);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "Nhập";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // txtServer
            // 
            this.txtServer.Depth = 0;
            this.txtServer.Hint = "";
            this.txtServer.Location = new System.Drawing.Point(18, 234);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtServer.Name = "txtServer";
            this.txtServer.PasswordChar = '\0';
            this.txtServer.SelectedText = "";
            this.txtServer.SelectionLength = 0;
            this.txtServer.SelectionStart = 0;
            this.txtServer.Size = new System.Drawing.Size(363, 32);
            this.txtServer.TabIndex = 2;
            this.txtServer.UseSystemPasswordChar = false;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Depth = 0;
            this.lblServer.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblServer.Location = new System.Drawing.Point(12, 200);
            this.lblServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(165, 27);
            this.lblServer.TabIndex = 8;
            this.lblServer.Text = "Server (IP/Port)";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 332);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtNickName);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNickName;
        private MaterialSkin.Controls.MaterialRaisedButton btnExit;
        private MaterialSkin.Controls.MaterialRaisedButton btnEnter;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtServer;
        private MaterialSkin.Controls.MaterialLabel lblServer;
    }
}