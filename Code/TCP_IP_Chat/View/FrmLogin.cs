using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCP_IP_Chat.Controller;
using TCP_IP_Chat.ViewController;

namespace TCP_IP_Chat
{
    public partial class FrmLogin : MaterialForm
    {
        public string nickname;
        public string server;

        public FrmLogin(string nickname)
        {
            InitializeComponent();
            DarkMode.ChangetoDarkMode(this);                        
            this.nickname = nickname;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtServer.Text = ClientConfig.IPHost();
            txtNickName.Text = this.nickname;
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            bool choose = VerifyInformation();
            if (choose == true) 
            {
                this.nickname = txtNickName.Text;
                this.server = txtServer.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            };
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool VerifyInformation()
        {
            foreach(Control control in this.Controls)
            {
                if(control is MaterialSkin.Controls.MaterialSingleLineTextField)
                {
                    if (String.IsNullOrEmpty(control.Text))
                    {
                        MessageBox.Show("Không được để trống!", "Attention",MessageBoxButtons.OK,MessageBoxIcon.Error);                         
                        return false;
                    }
                }
            }
            return true;
        }

        private void TxtNickName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnEnter_Click(null,null);
            }
        }
    }
}
