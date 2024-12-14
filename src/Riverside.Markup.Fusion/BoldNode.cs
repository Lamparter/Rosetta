using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Represents a bold node in Markdown.
    /// </summary>
    public class BoldNode : MarkdownNode
    {
        /// <summary>
        /// Gets the content of the bold node.
        /// </summary>
        public string Content { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoldNode"/> class with the specified content.
        /// </summary>
        /// <param name="content">The content of the bold node.</param>
        public BoldNode(string content) => Content = content;

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
