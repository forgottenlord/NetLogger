using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThunderServer_ClientSideTester.Net.TCP;
using ThunderServer_ClientSideTester.Net.TCP.Client;
using ThunderServer_ClientSideTester.Net.TCP.Server;

namespace ThunderServer_ClientSideTester.Forms
{
    public partial class TcpServerForm : Form
    {
        private TcpServer server = null;
        public TcpServerForm()
        {
            InitializeComponent();
            server = new TcpServer();
            server.OnLog += WriteLog;
            server.OnReseive += WriteMessage;
            server.OnConnectedClient += AddClient;
            server.OnDisconnectedClient += RemoveClient;
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(serverPort.Text)) return;

            server.Start(int.Parse(serverPort.Text));

            startButton.Enabled = false;
            stopButton.Enabled = true;
            sendButton.Enabled = true;
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            server.Stop();
            startButton.Enabled = true;
            stopButton.Enabled = false;
            sendButton.Enabled = false;
        }

        private void TcpServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //server.Stop();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            server.Send((string)connectedClients.SelectedItem, sendMessage.Text);
        }


        private void TcpServerForm_Resize(object sender, EventArgs e)
        {
            Size size = Logs.Size;
            size.Height = this.Height - 120;
            Logs.Size = size;
        }

        private void WriteLog(string msg)
        {
            if (InvokeRequired)
                this.Invoke(new Action(() =>
                {
                    Logs.Text += msg + Environment.NewLine;
                }));
        }
        private void WriteMessage(ConnectedClient sender, byte[] msg)
        {
            if (InvokeRequired)
                this.Invoke(new Action(() =>
                {
                    Logs.Text += "send to " + sender.id + " "+ Encoding.UTF8.GetString(msg)+" " + Environment.NewLine;
                }));
        }

        private void AddClient(ConnectedClient newClient)
        {
            if (InvokeRequired)
                this.Invoke(new Action(() =>
                {
                    connectedClients.Items.Add(newClient.id);
                    if (connectedClients.Items.Count == 1)
                        connectedClients.SelectedIndex = 0;
                }));
        }
        private void RemoveClient(ConnectedClient newClient)
        {
            if (InvokeRequired)
                this.Invoke(new Action(() =>
                {
                    connectedClients.Items.Remove(newClient.id);
                    if (connectedClients.Items.Count == 1)
                        connectedClients.SelectedIndex = 0;
                }));
        }
    }
}
