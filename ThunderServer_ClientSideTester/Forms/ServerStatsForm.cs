using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThunderServer_ClientSideTester.Interfaces;
using ThunderServer_ClientSideTester.DataModels;

namespace ThunderServer_ClientSideTester.Forms
{
    public partial class ServerStatsForm : Form, IContainer<SignalServerStats>
    {
        public ServerStatsForm()
        {
            InitializeComponent();
        }

        public void SetContent(SignalServerStats stats)
        {

        }
    }
}
