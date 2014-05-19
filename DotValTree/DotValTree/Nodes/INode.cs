using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree.Nodes
{
    public interface INode
    {
        bool Validate(object obj);
    }
}
