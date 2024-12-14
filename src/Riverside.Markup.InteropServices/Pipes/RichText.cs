using System.Xml;

namespace Riverside.Markup.InteropServices.Pipes
{
    internal class RichText : ITranslatable
    {
        public DocumentType Implements => DocumentType.RichText;

        public XmlDocument ConvertToRosetta(string input)
        {
            XmlDocument doc = new();
            doc.LoadXml("<Document xmlns=\"http://iviri.us/schemas/2024/rosetta\"><Paragraph><Text>Converted HTML content</Text></Paragraph></Document>"); // TODO: Implement actual conversion logic
            return doc;
        }
    }
}
