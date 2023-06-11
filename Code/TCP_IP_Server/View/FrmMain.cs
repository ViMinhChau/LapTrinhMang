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
using TCP_IP_Server.ViewController;
using SimpleTcp;

namespace TCP_IP_Server.View
{
    public partial class FrmMain : MaterialForm
    {
        SimpleTcpServer server;
        string _server;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _server = ServerConfig.ConfigurationServer();          
            ControlForms();
            ControlButtons(false);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            StartServer();
        }
       
        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            UserDisconnect(e);
        }
       
        private void Events_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            NewUserConnected(e);
        }       

        private void Events_DataReceived(object sender, DataReceivedFromClientEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                ReceiveMessages(e);
            });
        }
       
        private void CloseServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseServer();
        }      

        private void TxtText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendMessenger();
            }
        }

        private void BtnSend_Click_1(object sender, EventArgs e)
        {
            SendMessenger();
        }

        private void StartServer()
        {
            try
            {
                ConfigurationServer();
                server.Start();
                cmsCloseServer.Enabled = true;
                rtbMessages.Text += $"Server Connected!{Environment.NewLine}";
                pbStatus.Image = TCP_IP_Server.Properties.Resources.icons8_100_;
                ControlButtons(true);
                txtText.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                rtbMessages.Text += $"Server startup failed :({Environment.NewLine}";
            }
        }

        private void ReceiveMessages(DataReceivedFromClientEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                string ReceiveMessages = $"{Encoding.UTF8.GetString(e.Data)}";
                rtbMessages.Text += ReceiveMessages;
                UserUpdate(ReceiveMessages, e.IpPort);
                SendMessageAllUsers(ReceiveMessages, e.IpPort);
            });
        }

        private void UserDisconnect(ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                int index = User.FindString(e.IpPort);
                rtbMessages.Text += $"{User.Items[index]} disconnected.{Environment.NewLine}";
                User.Items.RemoveAt(index);
            });
        }

        private void NewUserConnected(ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                rtbMessages.Text += $"{e.IpPort} connected.{Environment.NewLine}";
                User.Items.Add(e.IpPort);
            });
        }

        private void ControlForms()
        {
            DarkMode.ChangetoDarkMode(this);
            txtServer.Text = _server;
            rtbMessages.ReadOnly = true;
            rtbMessages.SelectionProtected = true;
            rtbMessages.BackColor = this.BackColor;
            rtbMessages.ForeColor = Color.White;
            User.BackColor = this.BackColor;
            User.ForeColor = Color.White;
            txtServer.BackColor = this.BackColor;
            btnSend.Enabled = false;
            pbServer.BackColor = Color.FromArgb(424242);
            pbStatus.BackColor = Color.FromArgb(424242);
            pbStatus.Image = TCP_IP_Server.Properties.Resources.icons8_0_percent;
        }

        private void ControlButtons(bool status)
        {
            if (status == true) { btnStart.Enabled = false; }
            else { btnStart.Enabled = true; }
            btnSend.Enabled = status;
        }

        public void SendMessenger()
        {
            if (VerifyServer())
            {
                string messenger = $"Server: {txtText.Text}{Environment.NewLine}";
                string[] _user = User.SelectedItem.ToString().Split('(');
                string destiny = _user[0].Trim();
                server.Send(destiny, messenger);
                rtbMessages.Text += messenger;
                txtText.Text = "";
            }
        }

        public void SendMessageAllUsers(string messenger, string ipPort)
        {
            if (server.IsListening)
            {
                foreach (string user in User.Items)
                {
                    string[] _user = user.Split('(');
                    if (!ipPort.Equals(_user[0].Trim()))
                    {
                        server.Send(_user[0].Trim(), messenger);
                    }
                }
            }
        }

        public bool VerifyServer()
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(txtText.Text) && User.SelectedItem != null)
                {
                    return true;
                }
            }
            return false;
        }

        public void ConfigurationServer()
        {
            server = new SimpleTcpServer(txtServer.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }

        private void UserUpdate(string messageReceived, string ipPort)
        {
            string[] user = messageReceived.Split(':');
            int index = User.FindString(ipPort);
            if (!User.Items[index].ToString().Contains("("))
            {
                User.Items[index] = User.Items[index].ToString() + " (" + user[0].Replace(":", ",") + ")";
            }
        }

        private void CloseServer()
        {
            DisconnectClient();
            server.Stop();            
            pbStatus.Image = TCP_IP_Server.Properties.Resources.icons8_0_percent;
            User.Items.Clear();
            rtbMessages.Text += $"Server has stopped!{ Environment.NewLine}";
            btnStart.Enabled = true;
        }

        private void DisconnectClient()
        {
            string[] users = server.GetClients().ToArray();
            foreach(string user in users)
            {
                server.DisconnectClient(user);
            }
        }
    }
}
