using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Represents a code block node in Markdown.
    /// </summary>
    /// <param name="content">The content of the code block node.</param>
    public class CodeBlockNode(string content) : MarkdownNode
    {
        /// <summary>
        /// Gets the content of the code block node.
        /// </summary>
        public string Content { get; } = content;

        /// <summary>
        /// Converts the code block node to its HTML representation.
        /// </summary>
        /// <param name="standard">The Markdown standard to use.</param>
        /// <returns>The HTML representation of the code block node.</returns>
        public override string ToHtml(MarkdownStandard standard)
        {
            return $"<pre><code>{Regex.Replace(Content, Patterns.CodeBlockPattern, "$1")}</code></pre>";
        }
    }
}
