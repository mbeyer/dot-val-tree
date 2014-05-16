using ExpressionEvaluator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotValTree
{
    public class Leaf
    {
        public ICollection<Value> Values { get; set; }

        public bool Validate(object obj)
        {
            foreach(var element in Values)
            {
                if (element.Validate(obj))
                    return true;
            }
            return false;
        }
    }
}