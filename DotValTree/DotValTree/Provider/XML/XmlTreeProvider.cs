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
    public class XmlNodeProvider : IValidatorProvider
    {
        IXmlStorageProvider _provider;

        public XmlNodeProvider(IXmlStorageProvider storageProvider)
        {
            _provider = storageProvider;
        }

        public Validator GetValidator(int id)
        {
            XmlSerializer serializer;
            var xmlTree = _provider.GetXmlTree(id);
            if (xmlTree == null)
                return null;

            serializer = new XmlSerializer(typeof(Node));

            var stringReader = new StringReader(xmlTree.Tree);
            var returnNode = (Node)serializer.Deserialize(stringReader);

            var validator = new Validator() { Id = xmlTree.ValidationId, Description = xmlTree.Description, RootNode = returnNode };

            return validator;
        }

        public Validator SaveValidator(Validator validator)
        {
            var x = new XmlSerializer(typeof(Node));
            var stringWriter = new StringWriter();

            x.Serialize(stringWriter, validator.RootNode);
            var stringBuffer = stringWriter.ToString();

            var xmlTree = new XmlValidationTree();
            xmlTree.Tree = stringBuffer;
            xmlTree.Description = validator.Description;
            xmlTree.ValidationId = validator.Id;

            xmlTree = _provider.SaveXmlTree(xmlTree);

            validator.Id = xmlTree.ValidationId;

            return validator;
        }

        public void DeleteValidator(int id)
        {
            _provider.DeleteXmlTree(id);
        }
    }
}
