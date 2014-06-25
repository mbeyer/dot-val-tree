using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree.Provider.XML
{
    public static class XmlValidationTreeMapper
    {
        public static void Map(this XmlValidationTree dbTree, XmlValidationTree tree)
        {
            dbTree.ValidationId = tree.ValidationId;
            dbTree.Tree = tree.Tree;
            dbTree.Description = tree.Description;
        }
    }
}
