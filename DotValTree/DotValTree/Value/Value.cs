using ExpressionEvaluator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree
{
    public class Value
    {
        public object ValidationValue { get; set; }
        public string Evaluation { get; set; }

        public bool Validate(object obj)
        {
            var registry = new TypeRegistry();
            registry.RegisterSymbol("a", obj);
            registry.RegisterSymbol("b", ValidationValue);
            var expression = new CompiledExpression(Evaluation) { TypeRegistry = registry };

            return (Boolean)expression.Eval();
        }
    }
}
