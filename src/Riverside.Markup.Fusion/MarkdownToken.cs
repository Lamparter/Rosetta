using System;
using System.Collections.Generic;
using System.Text;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Represents a token in Markdown content.
    /// </summary>
    /// <param name="type">The type of the Markdown token.</param>
    /// <param name="content">The content of the Markdown token.</param>
    public class MarkdownToken(MarkdownTokenType type, string content)
    {
        /// <summary>
        /// Gets the type of the Markdown token.
        /// </summary>
        public MarkdownTokenType Type { get; } = type;

        /// <summary>
        /// Gets the content of the Markdown token.
        /// </summary>
        public string Content { get; } = content;
    }
}
