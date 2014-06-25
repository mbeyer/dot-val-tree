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
        /// Returns a class holding a validation node tree formatted as xml.
        /// </summary>
        /// <param name="id">The unique identifier identifying the instance to be retrieved</param>
        /// <returns></returns>
        XmlValidationTree GetXmlTree(int id);

        /// <summary>
        /// Saves an instance of XmlValidationTree
        /// </summary>
        /// <param name="node">The instance to save</param>
        XmlValidationTree SaveXmlTree(XmlValidationTree tree);

        /// <summary>
        /// Deletes an instance of XmlValidationTree
        /// </summary>
        /// <param name="id">The unique identifier identifying the instance to be deleted</param>
        void DeleteXmlTree(int id);
    }
}
