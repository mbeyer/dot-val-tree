using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree.Nodes
{
    public class AndNode : AbstractLogicalNode, INode
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
