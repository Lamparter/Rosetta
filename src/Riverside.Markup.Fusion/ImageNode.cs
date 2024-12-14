using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Represents an image node in Markdown.
    /// </summary>
    /// <param name="content">The content of the image node.</param>
    public class ImageNode(string content) : MarkdownNode
    {
        /// <summary>
        /// Gets the content of the image node.
        /// </summary>
        public string Content { get; } = content;

        /// <summary>
        /// Converts the image node to its HTML representation.
        /// </summary>
        /// <param name="standard">The Markdown standard to use.</param>
        /// <returns>The HTML representation of the image node.</returns>
        public override string ToHtml(MarkdownStandard standard)
        {
            var match = Regex.Match(Content, Patterns.ImagePattern);
            if (match.Success)
            {
                var altText = match.Groups[1].Value;
                var url = match.Groups[2].Value;
                return $"<img src=\"{url}\" alt=\"{altText}\" />";
            }
            return "";
        }
    }
}
