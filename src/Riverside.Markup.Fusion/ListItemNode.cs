using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Riverside.Markup.Fusion
{
    public class ListItemNode : MarkdownNode
    {
        public string Content { get; }
        public ListItemNode(string content) => Content = content;

        public override string ToHtml(MarkdownStandard standard)
        {
            return $"<li>{Regex.Replace(Content, Patterns.ListItemPattern, "$2")}</li>";
        }
    }
}
