using System;
using System.Collections.Generic;
using System.Text;

namespace Riverside.Markup.Fusion
{
    public class TextNode : MarkdownNode
    {
        public string Content { get; }
        public TextNode(string content) => Content = content;

        public override string ToHtml(MarkdownStandard standard)
        {
            return Content;
        }
    }
}
