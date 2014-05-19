using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree.Nodes
{
    public class OrNode : AbstractLogicalNode, INode
    {

        public override bool Validate(object obj)
        {
            bool isValid = false;
            foreach (var element in ChildNodes)
            {
                if (element.Validate(obj))
                    isValid = true;
            }

            return isValid;
        }
    }
}
