using System;
using System.Collections.Generic;
using System.Text;

namespace Riverside.Markup.InteropServices
{
    /// <summary>
    /// This enumeration defines the different types of documents that can be translated into Rosetta.
    /// </summary>
    public enum DocumentType
    {
        /// <summary>
        /// HyperText Markup Language document.
        /// </summary>
        HyperText,

        /// <summary>
        /// Microsoft Word document.
        /// </summary>
        Word,

        /// <summary>
        /// Portable Document Format.
        /// </summary>
        PortableDocument,

        /// <summary>
        /// Rich Text Format document.
        /// </summary>
        RichText,

        /// <summary>
        /// Markdown document.
        /// </summary>
        Markdown,

        /// <summary>
        /// ReStructuredText document.
        /// </summary>
        ReStructuredText,
    }
}
