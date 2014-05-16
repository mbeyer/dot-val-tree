using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree
{
    public interface ILeaf
    {
        bool Validate(object obj);
    }
}
