using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXmlDocument.Models
{
    [XmlRoot(ElementName = "paxml")]
    public class SalaryInformation
    {
        [XmlAttribute(AttributeName = "noNamespaceSchemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string noNamespaceSchemaLocation = "http://www.paxml.se/2.0/paxml.xsd";

        [XmlElement(ElementName = "header")]
        public Header Header { get; set; } = new Header();
    }
}
