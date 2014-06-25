using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DotValTree.Nodes
{
    /// <summary>
    /// The most basic class for validation
    /// </summary>
    [XmlInclude(typeof(ValueNode)), XmlInclude(typeof(OrNode)), XmlInclude(typeof(AndNode))]
    public abstract class Node : INode
    {
        public abstract bool Validate(object obj);
    }
}
