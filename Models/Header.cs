using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateXmlDocument.Models
{
    public enum Format
    {
        LÖNIN,
        SalaryOut,
        Register
    }

    [XmlRoot(ElementName = "header")]
    public class Header
    {
        [XmlElement(ElementName = "version")]
        public string Version { get; set; } = "2.0";

        [XmlElement(ElementName = "format")]
        public Format Format { get; set; }

        [XmlElement(DataType = "dateTime", ElementName = "datum")]
        public DateTime Date {  get; set; }

        [XmlElement(ElementName = "nyexport")]
        public ReExport? ReExport { get; set; }
        public string? CompanyId { get; set; }
        public string? CompanyOrgNo { get; set; }

        [XmlElement(ElementName = "foretagnamn")]
        public string? CompanyName { get; set; }
        public string? ExtraAddress { get; set; }
        public string? PostAddress { get; set; }
        public string? PostNo { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Email { get; set; }
        public string? Homepage { get; set; }
        public string? ContactPerson { get; set; }
        public string? PersonnelManager { get; set; }
        public string? AuthorizingManager { get; set; } // attestansvarig, osäker på översättingen.
        public string? PhoneNo { get; set; }

        [XmlElement(ElementName = "telefax")]
        public string? Telefax { get; set; }
        public string? SoftwareName { get; set; } // SV: programnamn, är det software som åsyftas?
        public string? SoftwareLicense { get; set; } // sv: programlicens, -"-
        public string? Info { get; set; }
    }
}
