namespace ThunderServer_ClientSideTester.Forms
{
    partial class TcpClientForm
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
            this.connectButton = new System.Windows.Forms.Button();
            this.serverIP = new System.Windows.Forms.TextBox();
            this.serverPort = new System.Windows.Forms.TextBox();
            this.sendMessage = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.Logs = new System.Windows.Forms.TextBox();
            this.disConnectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(278, 11);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(87, 25);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // serverIP
            // 
            this.serverIP.Location = new System.Drawing.Point(31, 11);
            this.serverIP.Name = "serverIP";
            this.serverIP.PlaceholderText = "serverIP";
            this.serverIP.Size = new System.Drawing.Size(116, 23);
            this.serverIP.TabIndex = 1;
            this.serverIP.Text = "192.168.1.249";
            // 
            // serverPort
            // 
            this.serverPort.Location = new System.Drawing.Point(153, 11);
            this.serverPort.Name = "serverPort";
            this.serverPort.PlaceholderText = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(119, 23);
            this.serverPort.TabIndex = 2;
            this.serverPort.Text = "80";
            // 
            // sendMessage
            // 
            this.sendMessage.Location = new System.Drawing.Point(31, 42);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.PlaceholderText = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(147, 23);
            this.sendMessage.TabIndex = 3;
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(185, 40);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(87, 25);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // Logs
            // 
            this.Logs.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.Logs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Logs.Location = new System.Drawing.Point(0, 77);
            this.Logs.Multiline = true;
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(383, 412);
            this.Logs.TabIndex = 5;
            // 
            // disConnectButton
            // 
            this.disConnectButton.Enabled = false;
            this.disConnectButton.Location = new System.Drawing.Point(278, 40);
            this.disConnectButton.Name = "disConnectButton";
            this.disConnectButton.Size = new System.Drawing.Size(87, 25);
            this.disConnectButton.TabIndex = 6;
            this.disConnectButton.Text = "Disconnect";
            this.disConnectButton.UseVisualStyleBackColor = true;
            this.disConnectButton.Click += new System.EventHandler(this.disConnectButton_Click);
            // 
            // TcpClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 489);
            this.Controls.Add(this.disConnectButton);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.sendMessage);
            this.Controls.Add(this.serverPort);
            this.Controls.Add(this.serverIP);
            this.Controls.Add(this.connectButton);
            this.Name = "TcpClientForm";
            this.Text = "TcpClientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TcpClientForm_FormClosing);
            this.Resize += new System.EventHandler(this.TcpClientForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button connectButton;
        private TextBox serverIP;
        private TextBox serverPort;
        private TextBox sendMessage;
        private Button sendButton;
        private TextBox Logs;
        private Button disConnectButton;
    }
}