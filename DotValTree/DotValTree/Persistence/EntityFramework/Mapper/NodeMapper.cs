using DotValTree.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree.Persistence.EntityFramework
{
    public static class NodeMapper
    {
        public static void Map(this AbstractNode dbNode, AbstractNode node)
        {
            dbNode.NodeId = node.NodeId;
            dbNode.ParentId = node.ParentId;
        }

        public static void Map(this ValueNode dbNode, ValueNode node)
        {
            Map(dbNode, node);
            dbNode.Evaluation = node.Evaluation;
            dbNode.ValidationType = node.ValidationType;
            dbNode.ValidationValue = dbNode.ValidationValue;
        }
    }
}
