namespace ThunderServer_ClientSideTester.Forms
{
    partial class TcpServerForm
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
            this.Logs = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.sendMessage = new System.Windows.Forms.TextBox();
            this.serverPort = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.connectedClients = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Logs
            // 
            this.Logs.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.Logs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Logs.Location = new System.Drawing.Point(0, 65);
            this.Logs.Multiline = true;
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(382, 385);
            this.Logs.TabIndex = 10;
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(278, 34);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(87, 25);
            this.sendButton.TabIndex = 9;
            this.sendButton.Text = "send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // sendMessage
            // 
            this.sendMessage.Location = new System.Drawing.Point(152, 36);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.PlaceholderText = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(120, 23);
            this.sendMessage.TabIndex = 8;
            // 
            // serverPort
            // 
            this.serverPort.Location = new System.Drawing.Point(25, 7);
            this.serverPort.Name = "serverPort";
            this.serverPort.PlaceholderText = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(154, 23);
            this.serverPort.TabIndex = 7;
            this.serverPort.Text = "80";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(185, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(87, 25);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(278, 3);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(87, 25);
            this.stopButton.TabIndex = 11;
            this.stopButton.Text = "stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // connectedClients
            // 
            this.connectedClients.FormattingEnabled = true;
            this.connectedClients.Location = new System.Drawing.Point(25, 36);
            this.connectedClients.Name = "connectedClients";
            this.connectedClients.Size = new System.Drawing.Size(121, 23);
            this.connectedClients.TabIndex = 12;
            // 
            // TcpServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.connectedClients);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.sendMessage);
            this.Controls.Add(this.serverPort);
            this.Controls.Add(this.startButton);
            this.Name = "TcpServerForm";
            this.Text = "TcpServerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TcpServerForm_FormClosing);
            this.Resize += new System.EventHandler(this.TcpServerForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Logs;
        private Button sendButton;
        private TextBox sendMessage;
        private TextBox serverPort;
        private Button startButton;
        private Button stopButton;
        private ComboBox connectedClients;
    }
}