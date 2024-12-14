using System;
using System.Collections.Generic;
using System.Text;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// This enumeration defines the different Markdown interpreters that can be used.
    /// </summary>
    public enum MarkdownInterpreter
    {
        /// <summary>
        /// A popular Markdown interpreter.
        /// </summary>
        Markdig,
        /// <summary>
        /// A custom Markdown interpreter written for this project.
        /// </summary>
        /// <remarks>
        /// Has speed optimizations for large documents, but not as feature rich as Markdig.
        /// </remarks>
        Fusion
    }
}
