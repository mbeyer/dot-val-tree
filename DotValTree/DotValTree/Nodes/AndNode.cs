using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DotValTree.Nodes
{
    /// <summary>
    /// This class dictates that all child nodes return true, in order for the Validate method to return true too.
    /// </summary>
    [XmlType("AndNode")]
    public class AndNode : LogicalNode
    {

        public override bool Validate(object obj)
        {
            bool isValid = true;
            foreach(var element in ChildNodes)
            {
                if (!element.Validate(obj))
                    isValid = false;
            }

            return isValid;
        }
    }
}
