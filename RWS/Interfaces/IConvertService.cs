using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWS.Interfaces
{
    interface IConvertService
    {
        public Document? DeserializeDocument(Stream s);

        public void SerializeDocument(Stream s, Document document);
    }
}
