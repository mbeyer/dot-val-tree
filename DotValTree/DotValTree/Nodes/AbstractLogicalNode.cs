using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree.Nodes
{
    public abstract class AbstractLogicalNode
    {
        public ICollection<INode> ChildNodes;

        public AbstractLogicalNode()
        {
            ChildNodes = new List<INode>();
        }

        public void AddNode(INode node)
        {
            ChildNodes.Add(node);
        }

        public void RemoveNode(INode node)
        {
            ChildNodes.Remove(node);
        }

        public abstract bool Validate(object obj);
    }
}
