using ExpressionEvaluator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree.Nodes
{
    public class ValueNode : INode
    {
        public object ValidationValue { get; set; }
        public string Evaluation { get; set; }

        public bool Validate(object obj)
        {
            var registry = new TypeRegistry();
            registry.RegisterSymbol("a", obj);
            registry.RegisterSymbol("b", ValidationValue);

            var expr = new CompiledExpression(Evaluation) { TypeRegistry = registry };
            return (Boolean) expr.Eval();
        }
    }
}
