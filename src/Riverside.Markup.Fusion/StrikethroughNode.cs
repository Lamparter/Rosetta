using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Riverside.Markup.Fusion
{
    public class StrikethroughNode : MarkdownNode
    {
        public string Content { get; }
        public StrikethroughNode(string content) => Content = content;

        public override string ToHtml(MarkdownStandard standard)
        {
            return $"<del>{Regex.Replace(Content, Patterns.StrikethroughPattern, "$1")}</del>";
        }
    }
}
