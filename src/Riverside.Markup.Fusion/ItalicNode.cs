﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Represents an italic node in Markdown.
    /// </summary>
    public class ItalicNode : MarkdownNode
    {
        /// <summary>
        /// Gets the content of the italic node.
        /// </summary>
        public string Content { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItalicNode"/> class with the specified content.
        /// </summary>
        /// <param name="content">The content of the italic node.</param>
        public ItalicNode(string content) => Content = content;

        /// <summary>
        /// Converts the italic node to its HTML representation.
        /// </summary>
        /// <param name="standard">The Markdown standard to use.</param>
        /// <returns>The HTML representation of the italic node.</returns>
        public override string ToHtml(MarkdownStandard standard)
        {
            return $"<em>{Regex.Replace(Content, Patterns.ItalicPattern, "$1")}</em>";
        }
    }
}
