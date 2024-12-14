using System;
using System.Collections.Generic;
using System.Text;

namespace Riverside.Markup.Fusion
{
    public class MarkdownToken
    {
        public MarkdownTokenType Type { get; }
        public string Content { get; }
        public MarkdownToken(MarkdownTokenType type, string content)
        {
            Type = type;
            Content = content;
        }
    }
}
