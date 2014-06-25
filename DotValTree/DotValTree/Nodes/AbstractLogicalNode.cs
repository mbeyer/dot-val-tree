using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DotValTree.Nodes
{
    
    public abstract class AbstractLogicalNode : AbstractNode
    {
        public List<AbstractNode> ChildNodes;

        public AbstractLogicalNode()
        {
            ChildNodes = new List<AbstractNode>();
        }

        public void AddNode(AbstractNode node)
        {
            ChildNodes.Add(node);
        }

        public void RemoveNode(AbstractNode node)
        {
            ChildNodes.Remove(node);
        }
    }
}
