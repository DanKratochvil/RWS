using RWS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RWS.Implementations
{
    public class ConvertXmlService : IConvertService
    {
        public Document? DeserializeDocument(Stream s)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Document));
            return (Document?) serializer.Deserialize(s);
        }

        public void SerializeDocument(Stream s, Document document)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Document));
            serializer.Serialize(s, document);
        }
    }
}
