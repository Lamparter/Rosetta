using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Riverside.Markup.Fusion
{
    public class CodeBlockNode : MarkdownNode
    {
        public string Content { get; }
        public CodeBlockNode(string content) => Content = content;

        public override string ToHtml(MarkdownStandard standard)
        {
            return $"<pre><code>{Regex.Replace(Content, Patterns.CodeBlockPattern, "$1")}</code></pre>";
        }
    }
}
