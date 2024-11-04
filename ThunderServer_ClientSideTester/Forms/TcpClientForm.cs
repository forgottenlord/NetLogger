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
    public partial class TcpClientForm : Form
    {
        private TcpClient client = null;
        public TcpClientForm()
        {
            InitializeComponent();
            client = new TcpClient();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            client.OnLog += WriteLog;
            client.OnReseive += ReseiveMessage;
            client.Connect(serverIP.Text, int.Parse(serverPort.Text));
        }

        private void TcpClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //client.Stop();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            client.Send(sendMessage.Text);
        }

        private void TcpClientForm_Resize(object sender, EventArgs e)
        {
            Size size = Logs.Size;
            size.Height = this.Height - 120;
            Logs.Size = size;
        }

        private void ReseiveMessage(byte[] data)
        {
            WriteLog(Encoding.UTF8.GetString(data));
        }
        private void WriteLog(string msg)
        {
            if (InvokeRequired)
                this.Invoke(new Action(() =>
                {
                    Logs.Text += msg + Environment.NewLine;
                }));
        }
    }
}
