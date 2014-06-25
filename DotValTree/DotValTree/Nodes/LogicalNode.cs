using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DotValTree.Nodes
{
    /// <summary>
    /// Logical nodes are nodes that dictate a certain behavior for their Validate method.
    /// Logical nodes hold child nodes which can either be other logical nodes or value nodes.
    /// See derived classes for examples.
    /// </summary>
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
