using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DotValTree.Nodes
{
    
    public abstract class LogicalNode : Node
    {
        public List<Node> ChildNodes;

        public LogicalNode()
        {
            ChildNodes = new List<Node>();
        }

        public void AddNode(Node node)
        {
            ChildNodes.Add(node);
        }

        public void RemoveNode(Node node)
        {
            ChildNodes.Remove(node);
        }
    }
}
