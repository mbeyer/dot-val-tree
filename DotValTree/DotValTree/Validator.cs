using DotValTree.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree
{
    public class Validator
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public AbstractNode RootNode { get; set; }

        public bool Validate(object obj)
        {
            return RootNode.Validate(obj);
        }
    }
}
