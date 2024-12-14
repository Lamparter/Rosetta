using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Riverside.Markup.Fusion
{
    public class HeadingNode : MarkdownNode
    {
        public string Content { get; }
        public HeadingNode(string content) => Content = content;

        public override string ToHtml(MarkdownStandard standard)
        {
            var level = Content.TakeWhile(c => c == '#').Count();
            var text = Content.TrimStart('#').Trim();
            return $"<h{level}>{text}</h{level}>";
        }
    }
}
