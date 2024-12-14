using System.Xml;

namespace Riverside.Markup.InteropServices
{
    /// <summary>
    /// Interface for documents that can be converted to Rosetta format.
    /// </summary>
    public interface ITranslatable
    {
        /// <summary>
        /// Gets the type of document that this instance can convert.
        /// </summary>
        DocumentType Implements { get; }

        /// <summary>
        /// Converts the input string to Rosetta format.
        /// </summary>
        /// <param name="input">The input string to convert.</param>
        /// <returns>The converted object in Rosetta format.</returns>
        XmlDocument ConvertToRosetta(string input);
    }
}
