using System;
using System.Collections.Generic;
using System.Text;

namespace Riverside.Markup.Fusion
{
    public class HtmlRenderer
    {
        public string Render(IEnumerable<MarkdownNode> nodes, MarkdownStandard standard)
        {
            var sb = new StringBuilder();
            foreach (var node in nodes)
            {
                sb.AppendLine(node.ToHtml(standard));
            }
            return sb.ToString();
        }
    }
}
