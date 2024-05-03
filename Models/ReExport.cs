using System.Xml.Serialization;

namespace CreateXmlDocument.Models
{
    [XmlRoot(ElementName = "nyexport")]
    public class ReExport
    {
        [XmlAttribute(DataType = "date", AttributeName = "datum")]
        public DateTime Date { get; set; }

        [XmlAttribute(DataType = "date", AttributeName = "datumfrom")]
        public DateTime DateFrom { get; set; }

        [XmlAttribute(DataType = "date", AttributeName = "datumtom")]
        public DateTime DateTo { get; set; }
    }
}
