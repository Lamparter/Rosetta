using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Represents a link node in Markdown.
    /// </summary>
    /// <param name="content">The content of the link node.</param>
    public class LinkNode(string content) : MarkdownNode
    {
        /// <summary>
        /// Gets the content of the link node.
        /// </summary>
        public string Content { get; } = content;

        /// <summary>
        /// Converts the link node to its HTML representation.
        /// </summary>
        /// <param name="standard">The Markdown standard to use.</param>
        /// <returns>The HTML representation of the link node.</returns>
        public override string ToHtml(MarkdownStandard standard)
        {
            var match = Regex.Match(Content, Patterns.LinkPattern);
            if (match.Success)
            {
                var text = match.Groups[1].Value;
                var url = match.Groups[2].Value;
                return $"<a href=\"{url}\">{text}</a>";
            }
            return "";
        }
    }
}
