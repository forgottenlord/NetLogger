using ThunderServer_ClientSideTester.Forms;

namespace ThunderServer_ClientSideTester.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NetStatsTreeView = new System.Windows.Forms.TreeView();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.добавитьNetFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCPServerFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCPClientFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // NetStatsTreeView
            // 
            this.NetStatsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NetStatsTreeView.Location = new System.Drawing.Point(0, 24);
            this.NetStatsTreeView.Name = "NetStatsTreeView";
            this.NetStatsTreeView.Size = new System.Drawing.Size(463, 297);
            this.NetStatsTreeView.TabIndex = 0;
            this.NetStatsTreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NetStatsTreeView_MouseDoubleClick);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьNetFormToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(463, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // добавитьNetFormToolStripMenuItem
            // 
            this.добавитьNetFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tCPServerFormToolStripMenuItem,
            this.tCPClientFormToolStripMenuItem});
            this.добавитьNetFormToolStripMenuItem.Name = "добавитьNetFormToolStripMenuItem";
            this.добавитьNetFormToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.добавитьNetFormToolStripMenuItem.Text = "TCP";
            // 
            // tCPServerFormToolStripMenuItem
            // 
            this.tCPServerFormToolStripMenuItem.Name = "tCPServerFormToolStripMenuItem";
            this.tCPServerFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tCPServerFormToolStripMenuItem.Text = "TCP ServerForm";
            this.tCPServerFormToolStripMenuItem.Click += new System.EventHandler(this.tCPServerFormToolStripMenuItem_Click);
            // 
            // tCPClientFormToolStripMenuItem
            // 
            this.tCPClientFormToolStripMenuItem.Name = "tCPClientFormToolStripMenuItem";
            this.tCPClientFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tCPClientFormToolStripMenuItem.Text = "TCP Client Form";
            this.tCPClientFormToolStripMenuItem.Click += new System.EventHandler(this.tCPClientFormToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 321);
            this.Controls.Add(this.NetStatsTreeView);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "NetStats";
            this.Load += new System.EventHandler(this.ServerStatsForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView NetStatsTreeView;
        private MenuStrip mainMenu;
        private ToolStripMenuItem добавитьNetFormToolStripMenuItem;
        private ToolStripMenuItem tCPServerFormToolStripMenuItem;
        private ToolStripMenuItem tCPClientFormToolStripMenuItem;
    }
}