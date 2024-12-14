using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Represents a list item node in Markdown.
    /// </summary>
    public class ListItemNode : MarkdownNode
    {
        /// <summary>
        /// Gets the content of the list item node.
        /// </summary>
        public string Content { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemNode"/> class with the specified content.
        /// </summary>
        /// <param name="content">The content of the list item node.</param>
        public ListItemNode(string content) => Content = content;

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
