using DotValTree.Nodes;
using DotValTree.Persistence.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree.Persistence
{
    public class ETNodeStorageProvider : IAbstractNodeStorageProvider
    {
        public AbstractNode GetNode(int id)
        {
            using (var context = new NodeDataContext())
            {
                var dbAbstractnode = (from c in context.AbstractNodes
                                      where c.NodeId == id
                                      select c).FirstOrDefault();

                return dbAbstractnode;
            }
        }

        public AbstractNode SaveNode(AbstractNode node)
        {
            using (var context = new NodeDataContext())
            {
                AbstractNode dbAbstractNode;

                if (node is AndNode)
                {
                    dbAbstractNode = GetNode(node.NodeId) ?? new AndNode();
                    dbAbstractNode.Map(node);
                }
                else if (node is OrNode)
                {
                    dbAbstractNode = GetNode(node.NodeId) ?? new OrNode();
                    dbAbstractNode.Map(node);
                }
                else
                {
                    dbAbstractNode = (ValueNode) GetNode(node.NodeId) ?? new ValueNode();
                    ((ValueNode)dbAbstractNode).Map((ValueNode)node);
                }

                if (dbAbstractNode.NodeId == 0)
                    context.AbstractNodes.Add(dbAbstractNode);

                context.SaveChanges();

                return dbAbstractNode;
            }
        }

        public void DeleteNode(int id)
        {
            throw new NotImplementedException();
        }

    }
}
