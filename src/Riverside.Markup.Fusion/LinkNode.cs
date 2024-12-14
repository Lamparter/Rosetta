using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Riverside.Markup.Fusion
{
    public class LinkNode : MarkdownNode
    {
        public string Content { get; }
        public LinkNode(string content) => Content = content;

        public override string ToHtml(MarkdownStandard standard)
        {
            var match = Regex.Match(Content, Patterns.LinkPattern);
            if (match.Success)
            {
                var text = match.Groups[1].Value;
                var url = match.Groups[2].Value;
                return $"<a href=\"{url}\">{text}</a>";
            }
            return "";
        }
    }
}
