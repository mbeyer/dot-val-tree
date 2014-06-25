using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DotValTree.Nodes
{
    /// <summary>
    /// This class dictates that only one child nodes needs to return true for the Validate method to return true too.
    /// </summary>
    [XmlType("OrNode")]
    public class OrNode : LogicalNode
    {

        public override bool Validate(object obj)
        {
            foreach (var element in ChildNodes)
            {
                if (element.Validate(obj))
                    return true;
            }
            return false;
        }
    }
}
