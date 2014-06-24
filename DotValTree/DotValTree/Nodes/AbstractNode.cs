using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree.Nodes
{
    public abstract class AbstractNode : INode
    {
        public int NodeId { get; set; }
        public int ParentId { get; set; }

        public abstract bool Validate(object obj);
    }
}
