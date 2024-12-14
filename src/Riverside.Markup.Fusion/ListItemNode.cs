using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Represents a list item node in Markdown.
    /// </summary>
    /// <param name="content">The content of the list item node.</param>
    public class ListItemNode(string content) : MarkdownNode
    {
        /// <summary>
        /// Gets the content of the list item node.
        /// </summary>
        public string Content { get; } = content;

        /// <summary>
        /// Converts the list item node to its HTML representation.
        /// </summary>
        /// <param name="standard">The Markdown standard to use.</param>
        /// <returns>The HTML representation of the list item node.</returns>
        public override string ToHtml(MarkdownStandard standard)
        {
            return $"<li>{Regex.Replace(Content, Patterns.ListItemPattern, "$2")}</li>";
        }
    }
}
