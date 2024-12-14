using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Riverside.Markup.Fusion
{
    public class ImageNode : MarkdownNode
    {
        public string Content { get; }
        public ImageNode(string content) => Content = content;

        public override string ToHtml(MarkdownStandard standard)
        {
            var match = Regex.Match(Content, Patterns.ImagePattern);
            if (match.Success)
            {
                var altText = match.Groups[1].Value;
                var url = match.Groups[2].Value;
                return $"<img src=\"{url}\" alt=\"{altText}\" />";
            }
            return "";
        }
    }
}
