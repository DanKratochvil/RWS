using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RWS
{  

    [Serializable]
    [XmlRoot("document")]
    public class Document
    {   
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "text")]
        public string Text { get; set; }
    }
}
