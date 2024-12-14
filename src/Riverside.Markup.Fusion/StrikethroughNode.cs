using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Represents a strikethrough node in Markdown.
    /// </summary>
    public class StrikethroughNode : MarkdownNode
    {
        /// <summary>
        /// Gets the content of the strikethrough node.
        /// </summary>
        public string Content { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StrikethroughNode"/> class with the specified content.
        /// </summary>
        /// <param name="content">The content of the strikethrough node.</param>
        public StrikethroughNode(string content) => Content = content;

        /// <summary>
        /// Converts the strikethrough node to its HTML representation.
        /// </summary>
        /// <param name="standard">The Markdown standard to use.</param>
        /// <returns>The HTML representation of the strikethrough node.</returns>
        public override string ToHtml(MarkdownStandard standard)
        {
            return $"<del>{Regex.Replace(Content, Patterns.StrikethroughPattern, "$1")}</del>";
        }
    }
}
