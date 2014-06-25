using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DotValTree.Nodes
{
    [XmlInclude(typeof(ValueNode))]
    public abstract class AbstractNode : INode
    {
        // Used for persistence reference to identify a root node
        [XmlIgnore]
        public int NodeId { get; set; }

        public abstract bool Validate(object obj);
    }
}
