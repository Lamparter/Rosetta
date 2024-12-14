using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Represents a bold node in Markdown.
    /// </summary>
    /// <param name="content">The content of the bold node.</param>
    public class BoldNode(string content) : MarkdownNode
    {
        /// <summary>
        /// Gets the content of the bold node.
        /// </summary>
        public string Content { get; } = content;

        /// <summary>
        /// Converts the bold node to its HTML representation.
        /// </summary>
        /// <param name="standard">The Markdown standard to use.</param>
        /// <returns>The HTML representation of the bold node.</returns>
        public override string ToHtml(MarkdownStandard standard)
        {
            return $"<strong>{Regex.Replace(Content, Patterns.BoldPattern, "$1")}</strong>";
        }
    }
}
