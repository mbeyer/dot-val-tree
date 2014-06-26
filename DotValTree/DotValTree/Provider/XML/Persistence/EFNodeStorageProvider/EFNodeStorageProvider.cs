using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree.Provider.XML
{
    /// <summary>
    /// Persist entities using the Entity Framework
    /// </summary>
    public class EFNodeStorageProvider : IXmlStorageProvider
    {
        public XmlValidationTree GetXmlTree(int id)
        {
            using (var context = new TreeDataContext())
            {
                var tree = (from c in context.ValidationTree
                            where c.ValidationId == id
                            select c).FirstOrDefault();

                return tree;
            }
        }

        public XmlValidationTree SaveXmlTree(XmlValidationTree tree)
        {
            using(var context = new TreeDataContext())
            {
                var dbTree = GetXmlTree(tree.ValidationId) ?? new XmlValidationTree();
                if (dbTree != null)
                    context.ValidationTree.Attach(dbTree);

                dbTree.Map(tree);

                if (dbTree.ValidationId == 0)
                    context.ValidationTree.Add(dbTree);
                

                context.SaveChanges();

                return dbTree;
            }
        }

        public void DeleteXmlTree(int id)
        {
            using (var context = new TreeDataContext())
            {
                var dbTree = GetXmlTree(id);
                if(dbTree == null)
                    return;

                context.ValidationTree.Attach(dbTree);

                if (dbTree != null)
                    context.ValidationTree.Remove(dbTree);

                context.SaveChanges();
            }
        }
    }
}
