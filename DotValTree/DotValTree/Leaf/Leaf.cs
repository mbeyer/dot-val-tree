using ExpressionEvaluator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotValTree
{
    public class Leaf
    {
        public object Value { get; set; }
        public string Evaluation { get; set; }

        public bool Validate(object obj)
        {
            var registry = new TypeRegistry();
            registry.RegisterSymbol("a",obj);
            registry.RegisterSymbol("b", Value);
            var expression = new CompiledExpression(Evaluation)  {TypeRegistry = registry};

            return (Boolean) expression.Eval();
        }
    }
}
