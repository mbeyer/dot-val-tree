using DotValTree.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree
{
    public class Validator : IValidation
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public AbstractLogicalNode RootNode { get; set; }

        public bool Validate(object obj)
        {
            return RootNode.Validate(obj);
        }
    }
}
