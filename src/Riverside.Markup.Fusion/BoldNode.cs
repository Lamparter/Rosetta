using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Riverside.Markup.Fusion
{
    public class BoldNode : MarkdownNode
    {
        public string Content { get; }
        public BoldNode(string content) => Content = content;

        public override string ToHtml(MarkdownStandard standard)
        {
            return $"<strong>{Regex.Replace(Content, Patterns.BoldPattern, "$1")}</strong>";
        }
    }
}
