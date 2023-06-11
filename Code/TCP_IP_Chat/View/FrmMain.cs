using MaterialSkin;
using MaterialSkin.Controls;
using SimpleTcp;
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
    public partial class FrmMain : MaterialForm
    {
        SimpleTcpClient client;
        string nickname = "";
        public FrmMain()
        {
            InitializeComponent();
            OpenLogin();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ControlForms();
        }

        private void Events_DataReceived(object sender, DataReceivedFromServerEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                rtbMessages.Text += $"{Encoding.UTF8.GetString(e.Data)}";
            });
        }

        private void Events_Disconnected(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                rtbMessages.Text += $"Disconnected from Server!{ Environment.NewLine}";
            });
        }

        private void Events_Connected(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                rtbMessages.Text += $"Connected to Server!{ Environment.NewLine}";
            });
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            SendMessenger();
        }

        private void BtnMenu_MouseEnter(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.Gray;
        }

        private void BtnMenu_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.FromArgb(424242);
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            cmsOptions.Show(System.Windows.Forms.Cursor.Position);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisconnectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            client.Disconnect();
            pbConection.Image = TCP_IP_Chat.Properties.Resources.icons8_disconnected;
        }

        private void SwitchConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLogin();
        }

        private void ClearConversationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMessages.Text = "";
        }

        private void CmsOptions_Opening(object sender, CancelEventArgs e)
        {
            if (client != null)
            {
                if (client.IsConnected)
                {
                    ControleDisconnect(true);
                }
                else
                {
                    ControleDisconnect(false);
                }
            }
            else
            {
                ControleDisconnect(false);
            }
        }

        private void TxtText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendMessenger();
            }
        }

        private void ControlForms()
        {
            DarkMode.ChangetoDarkMode(this);
            rtbMessages.ReadOnly = true;
            rtbMessages.SelectionProtected = true;
            rtbMessages.BackColor = this.BackColor;
            btnMenu.BackColor = Color.FromArgb(424242);
            txtText.BackColor = this.BackColor;
            pbConection.BackColor = this.BackColor;
            txtText.Focus();
        }

        private void ConfigurationServer(string server)
        {
            client = new SimpleTcpClient(server);
            client.Events.Connected += Events_Connected;
            client.Events.Disconnected += Events_Disconnected;
            client.Events.DataReceived += Events_DataReceived;
        }

        private void ControlButtons(bool status)
        {
            btnSend.Enabled = status;
        }

        private void OpenLogin()
        {
            FrmLogin frmLogin = new FrmLogin(nickname);            
            frmLogin.ShowDialog();
            if (frmLogin.DialogResult == DialogResult.OK)
            {
                if (client != null)
                {
                    client.Disconnect();
                    Task.Delay(2000);
                };
                nickname = frmLogin.nickname;
                Connect(nickname, frmLogin.server);
                UpdateLabels(nickname, frmLogin.server);
            }
        }

        private void UpdateLabels(string nickname, string server)
        {
            this.Invoke((MethodInvoker)delegate
            {
                lblServer.Text = "Server: " + server;
            });
        }

        private void Connect(string nickname, string server)
        {
            try
            {
                ConfigurationServer(server);
                client.Connect();
                ControlButtons(true);
                pbConection.Image = TCP_IP_Chat.Properties.Resources.icons8_connected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Attention", MessageBoxButtons.OK);
                pbConection.Image = TCP_IP_Chat.Properties.Resources.icons8_disconnected;
            }
        }

        private void SendMessenger()
        {
            if (VerifyConnection())
            {
                string messages = nickname + ": " + txtText.Text + "\n";
                client.Send(messages);
                rtbMessages.Text += messages;
                txtText.Text = "";
            }
        }

        public bool VerifyConnection()
        {
            try
            {
                if (client != null)
                {
                    if (client.IsConnected)
                    {
                        if (!string.IsNullOrEmpty(txtText.Text))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You are not connected to any server!", "Attention!", MessageBoxButtons.OK);
                return false;
            }
        }

        private void ControleDisconnect(bool status)
        {
            cmsDisconnect.Enabled = status;
        }
    }
}
