using System;
using System.Collections.Generic;
using System.Text;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Specifies the type of a Markdown token.
    /// </summary>
    public enum MarkdownTokenType
    {
        /// <summary>
        /// Represents plain text.
        /// </summary>
        Text,

        /// <summary>
        /// Represents a heading.
        /// </summary>
        Heading,

        /// <summary>
        /// Represents bold text.
        /// </summary>
        Bold,

        /// <summary>
        /// Represents italic text.
        /// </summary>
        Italic,

        /// <summary>
        /// Represents a link.
        /// </summary>
        Link,

        /// <summary>
        /// Represents an image.
        /// </summary>
        Image,

        /// <summary>
        /// Represents a list item.
        /// </summary>
        ListItem,

        /// <summary>
        /// Represents a code block.
        /// </summary>
        CodeBlock,

        /// <summary>
        /// Represents inline code.
        /// </summary>
        InlineCode,

        /// <summary>
        /// Represents a blockquote.
        /// </summary>
        Blockquote,

        /// <summary>
        /// Represents a horizontal rule.
        /// </summary>
        HorizontalRule,

        /// <summary>
        /// Represents a table.
        /// </summary>
        Table
    }
}
