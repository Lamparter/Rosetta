using System.Xml;

namespace Riverside.Markup.InteropServices
{
    /// <summary>
    /// Interface for documents that can be converted to Rosetta format.
    /// </summary>
    /// <remarks>
    /// The main implementations for this interface are in the Riverside.Markup.InteropServices namespace, however the interface is marked as public to enable consumers to build their own Rosetta pipes.
    /// </remarks>
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
