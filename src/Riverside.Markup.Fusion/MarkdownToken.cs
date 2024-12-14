using System;
using System.Collections.Generic;
using System.Text;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Represents a token in Markdown content.
    /// </summary>
    public class MarkdownToken
    {
        /// <summary>
        /// Gets the type of the Markdown token.
        /// </summary>
        public MarkdownTokenType Type { get; }

        /// <summary>
        /// Gets the content of the Markdown token.
        /// </summary>
        public string Content { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownToken"/> class with the specified type and content.
        /// </summary>
        /// <param name="type">The type of the Markdown token.</param>
        /// <param name="content">The content of the Markdown token.</param>
        public MarkdownToken(MarkdownTokenType type, string content)
        {
            Type = type;
            Content = content;
        }
    }
}
