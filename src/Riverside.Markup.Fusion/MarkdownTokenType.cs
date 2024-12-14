using System;
using System.Collections.Generic;
using System.Text;

namespace Riverside.Markup.Fusion
{
    public enum MarkdownTokenType
    {
        Text,
        Heading,
        Bold,
        Italic,
        Link,
        Image,
        ListItem,
        CodeBlock,
        InlineCode,
        Blockquote,
        HorizontalRule,
        Table
    }
}
