using CreateXmlDocument.Models;
using System.ComponentModel.Design.Serialization;
using System.Reflection;
using System.Reflection.Metadata;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CreateXmlDocument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalaryInformation salaryInfo = new SalaryInformation();
            salaryInfo.Header.Version = "2.0";
            //salaryInfo.Header.Format = Format.SalaryIn;
            //salaryInfo.Header.Date = DateTime.Parse("2024 - 02 - 10T13: 00:00");
            //salaryInfo.Header.CompanyName = "Mjukis";
            //salaryInfo.Header.Telefax = "123123123123";
            //salaryInfo.Header.ReExport = new ReExport();


            var hej = ObjectXMLSerializer<SalaryInformation>.Load("siv.xml");
       
            var xmldoc = SalaryToXmlTwo(hej);
            xmldoc.Save("xmldoc.xml");
        }

        private static XmlDocument SalaryToXmlTwo(SalaryInformation salaryInformation)
        {
            XmlDocument document = new XmlDocument();
            XmlDeclaration xmlDeclaration = document.CreateXmlDeclaration("1.0", "iso-8859-1", null);
            document.AppendChild(xmlDeclaration);

            SetHeaderTest(document, salaryInformation);

            return document;
        }

        private static void SetHeaderTest(XmlDocument document, object obj)
        {
            var serializer = new XmlSerializer(obj.GetType());

            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

            using var writer = new StringWriter();
            serializer.Serialize(writer, obj, namespaces);

            var xml = writer.ToString();
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            var headerNode = xmlDocument.DocumentElement;

            var importedHeaderNode = document.ImportNode(headerNode, true);

            document.AppendChild(importedHeaderNode);
        }
    }
}
