using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThunderServer_ClientSideTester.DataModels
{
    public abstract class NetNode
    {
        public Dictionary<string, NetNode> subNodes = new Dictionary<string, NetNode>();
    }
}
