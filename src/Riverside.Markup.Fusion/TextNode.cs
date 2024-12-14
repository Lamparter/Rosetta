using System;
using System.Collections.Generic;
using System.Text;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Represents a text node in Markdown.
    /// </summary>
    public class TextNode : MarkdownNode
    {
        /// <summary>
        /// Gets the content of the text node.
        /// </summary>
        public string Content { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextNode"/> class with the specified content.
        /// </summary>
        /// <param name="content">The content of the text node.</param>
        public TextNode(string content) => Content = content;

        /// <summary>
        /// Converts the text node to its HTML representation.
        /// </summary>
        /// <param name="standard">The Markdown standard to use.</param>
        /// <returns>The HTML representation of the text node.</returns>
        public override string ToHtml(MarkdownStandard standard)
        {
            return Content;
        }
    }
}
