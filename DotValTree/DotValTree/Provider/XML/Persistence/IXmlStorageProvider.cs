using DotValTree.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree.Provider.XML
{
    public interface IXmlStorageProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        XmlValidationTree GetXmlTree(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        XmlValidationTree SaveXmlTree(XmlValidationTree node);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        void DeleteXmlTree(int id);
    }
}
