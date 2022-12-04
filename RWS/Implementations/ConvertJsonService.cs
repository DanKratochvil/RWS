using Newtonsoft.Json;
using RWS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RWS.Implementations
{
    public class ConvertJsonService : IConvertService
    {
        public Document? DeserializeDocument(Stream s)
        {
            using var reader = new StreamReader(s);
            string str = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<Document>(str);
        }

        public void SerializeDocument(Stream s, Document document)
        {            
            string str = JsonConvert.SerializeObject(document);
            using var writer = new StreamWriter(s);
            writer.WriteLine(str);
        }
    }
}
