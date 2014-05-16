using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree
{
    public interface IValue
    {
        bool Validate(object obj);
    }
}
