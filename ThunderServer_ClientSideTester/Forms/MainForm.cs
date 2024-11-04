using ThunderServer_ClientSideTester.TreeViewControll;

namespace ThunderServer_ClientSideTester.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ServerStatsForm_Load(object sender, EventArgs e)
        {
            TreeViewer.Simulate(NetStatsTreeView);
        }

        private void NetStatsTreeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ServerStatsForm serverStatsForm = new ServerStatsForm();
            serverStatsForm.Show();
            serverStatsForm.Show();
        }

        private void tCPServerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TcpServerForm serverForm = new TcpServerForm();
            serverForm.Show();
        }

        private void tCPClientFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TcpClientForm clientForm = new TcpClientForm();
            clientForm.Show();
        }
    }
}