using System;
using System.Collections.Generic;
using System.Text;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Represents an abstract base class for Markdown nodes.
    /// </summary>
    public abstract class MarkdownNode
    {
        /// <summary>
        /// Converts the Markdown node to its HTML representation.
        /// </summary>
        /// <param name="standard">The Markdown standard to use.</param>
        /// <returns>The HTML representation of the Markdown node.</returns>
        public abstract string ToHtml(MarkdownStandard standard);
    }
}
