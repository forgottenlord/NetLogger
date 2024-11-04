using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThunderServer_ClientSideTester.TreeViewControll
{
    public static class TreeNodeExtension
    {
        public static string separator = "/";
        public static TreeNode AddNode(this TreeView tree, string name)
        {
            int index = name.IndexOf(separator);
            if (index != 0)
            {
                string[] split = name.Split(separator);
                TreeNode node = tree.Nodes.GetOrAddNodeByName(split[0]);
                for (int n = 1; n < split.Length; n++)
                {
                    node = node.Nodes.GetOrAddNodeByName(split[n]);
                }
                return node;
            }
            return tree.Nodes.GetOrAddNodeByName(name);
        }

        public static TreeNode GetOrAddNodeByName(this TreeNodeCollection nodes, string name)
        {
            TreeNode branch = nodes.OfType<TreeNode>().FirstOrDefault(n => n.Text.Equals(name));
            if (branch != null)
                return branch;

            TreeNode newNode = new TreeNode(name);
            nodes.Add(newNode);
            return newNode;
        }
    }
}
