using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Represents a heading node in Markdown.
    /// </summary>
    /// <param name="content">The content of the heading node.</param>
    public class HeadingNode(string content) : MarkdownNode
    {
        /// <summary>
        /// Gets the content of the heading node.
        /// </summary>
        public string Content { get; } = content;

        /// <summary>
        /// Converts the heading node to its HTML representation.
        /// </summary>
        /// <param name="standard">The Markdown standard to use.</param>
        /// <returns>The HTML representation of the heading node.</returns>
        public override string ToHtml(MarkdownStandard standard)
        {
            var level = Content.TakeWhile(c => c == '#').Count();
            var text = Content.TrimStart('#').Trim();
            return $"<h{level}>{text}</h{level}>";
        }
    }
}
