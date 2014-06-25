using ExpressionEvaluator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DotValTree.Nodes
{
    [XmlType("ValueNode")]
    public class ValueNode : Node
    {
        public object ValidationValue 
        {
            get { return _validationValue; }
            set 
            {
                _recompileExpression = true;
                _validationValue = value;
            }
        }
        public string Evaluation { get; set; }

        private object _validationValue;

        private CompiledExpression _expr;
        private TypeRegistry _registry;

        private bool _recompileExpression = true;
        private Type _lastType;

        public override bool Validate(object obj)
        {
            if(_lastType != obj.GetType())
                registerSymbols(obj);

            if (_expr == null || _recompileExpression == true)
            {
                registerSymbols(obj);
                recompileExpression();
            }
            return (Boolean) _expr.Eval();
        }

        #region PRIVATE METHODS

        private void recompileExpression()
        {
            _expr = new CompiledExpression(Evaluation) { TypeRegistry = _registry };
            _recompileExpression = false;
        }

        private void registerSymbols(object obj)
        {
            _registry = new TypeRegistry();
            
            _registry.RegisterSymbol("a", obj);
            _registry.RegisterSymbol("b", ValidationValue);

            _lastType = obj.GetType();
        }
        #endregion
    }
}
