using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThunderServer_ClientSideTester.TreeViewControll
{
    public class TreeViewer
    {
        public static void Simulate(TreeView tree)
        {
            tree.AddNode("signal server 192.168.1.1:60");
            tree.AddNode("signal server 192.168.1.1:60/update server 192.168.1.1:80");
            tree.AddNode("signal server 192.168.1.1:60/game server 192.168.1.1:100");

            tree.AddNode("signal server 192.168.1.1:60/update server 192.168.1.1:80/client 192.168.1.1:2000");
            tree.AddNode("signal server 192.168.1.1:60/game server 192.168.1.1:100/client 192.168.1.1:3000");


            tree.AddNode("signal server 192.168.1.1:60/update server 192.168.1.1:80/client 192.168.1.1:2005");
            tree.AddNode("signal server 192.168.1.1:60/game server 192.168.1.1:100/client 192.168.1.1:3005");
        }
    }
}
