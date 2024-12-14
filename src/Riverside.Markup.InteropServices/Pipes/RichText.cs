using System.Xml;
using System.Text.RegularExpressions;

namespace Riverside.Markup.InteropServices.Pipes
{
    internal class RichText : ITranslatable
    {
        public DocumentType Implements => DocumentType.RichText;

        public XmlDocument ConvertToRosetta(string input)
        {
            XmlDocument doc = new();
            string rosettaContent = ConvertRtfToRosetta(input);
            doc.LoadXml(rosettaContent);
            return doc;
        }

        private static string ConvertRtfToRosetta(string rtf)
        {
            // Basic RTF to Rosetta conversion logic
            // This is a simplified example and may need to be expanded for full RTF support
            string rosetta = "<Document xmlns=\"http://iviri.us/schemas/2024/rosetta\"><Paragraph>";

            // Convert bold text
            rtf = Regex.Replace(rtf, @"\\b (.+?)\\b0", "<f:Bold>$1</f:Bold>");

            // Convert italic text
            rtf = Regex.Replace(rtf, @"\\i (.+?)\\i0", "<f:Italic>$1</f:Italic>");

            // Convert plain text
            rtf = Regex.Replace(rtf, @"\\pard(.+?)\\par", "<Text>$1</Text>");

            rosetta += rtf;
            rosetta += "</Paragraph></Document>";

            return rosetta;
        }
    }
}

