using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Represents a code block node in Markdown.
    /// </summary>
    public class CodeBlockNode : MarkdownNode
    {
        /// <summary>
        /// Gets the content of the code block node.
        /// </summary>
        public string Content { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBlockNode"/> class with the specified content.
        /// </summary>
        /// <param name="content">The content of the code block node.</param>
        public CodeBlockNode(string content) => Content = content;

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
