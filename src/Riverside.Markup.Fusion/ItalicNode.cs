using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Riverside.Markup.Fusion
{
    public class ItalicNode : MarkdownNode
    {
        public string Content { get; }
        public ItalicNode(string content) => Content = content;

        public override string ToHtml(MarkdownStandard standard)
        {
            return $"<em>{Regex.Replace(Content, Patterns.ItalicPattern, "$1")}</em>";
        }
    }
}
