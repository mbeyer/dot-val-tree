using DotValTree.Nodes;
using DotValTree.Provider;
using DotValTree.Provider.XML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DotValTree.Provider
{
    public class XmlNodeProvider : ITreeProvider
    {
        IXmlStorageProvider _provider;

        public XmlNodeProvider(IXmlStorageProvider storageProvider)
        {
            _provider = storageProvider;
        }

        public AbstractNode GetTree(int id)
        {
            var xmlTree = _provider.GetXmlTree(id);

            var serializer = new XmlSerializer(typeof(AbstractLogicalNode));

            var stringReader = new StringReader(xmlTree.Tree);
            var returnNode = (AbstractNode) serializer.Deserialize(stringReader);

            return returnNode;
        }

        public AbstractNode SaveTree(AbstractNode node)
        {
            var x = new XmlSerializer(node.GetType());

            var stringWriter = new StringWriter();

            x.Serialize(stringWriter, node);
            var stringBuffer = stringWriter.ToString();

            var xmlTree = new XmlValidationTree();
            xmlTree.Tree = stringBuffer;
            _provider.SaveXmlTree(xmlTree);

            return node;
        }

        public void DeleteTree(int id)
        {
            _provider.DeleteXmlTree(id);
        }
    }
}
