using System;
using System.Xml;
using Riverside.Markup.InteropServices.Pipes;

namespace Riverside.Markup.InteropServices
{
    /// <summary>
    /// Translates various document types to Rosetta format.
    /// </summary>
    public class DocumentTranslator
    {
        private readonly HyperText htmlPipe = new();
        private readonly RichText rtfPipe = new();
        private readonly ReStructuredText rstPipe = new();

        /// <summary>
        /// Converts the input string to Rosetta format based on the specified document type.
        /// </summary>
        /// <param name="input">The input string to convert.</param>
        /// <param name="documentType">The type of document to convert.</param>
        /// <returns>The converted document in Rosetta format as an XmlDocument.</returns>
        /// <exception cref="NotSupportedException">Thrown when the specified document type is not supported.</exception>
        public XmlDocument ConvertToRosetta(string input, DocumentType documentType)
        {
            switch (documentType)
            {
                case DocumentType.HyperText:
                    return htmlPipe.ConvertToRosetta(input);
                case DocumentType.RichText:
                    return rtfPipe.ConvertToRosetta(input);
                case DocumentType.ReStructuredText:
                    return rstPipe.ConvertToRosetta(input);
                default:
                    throw new NotSupportedException($"Document type {documentType} is not supported.");
            }
        }
    }
}
