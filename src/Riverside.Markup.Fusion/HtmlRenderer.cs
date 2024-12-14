using System;
using System.Collections.Generic;
using System.Text;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Renders a collection of Markdown nodes to HTML.
    /// </summary>
    public class HtmlRenderer
    {
        /// <summary>
        /// Renders the specified collection of Markdown nodes to HTML.
        /// </summary>
        /// <param name="nodes">The collection of Markdown nodes to render.</param>
        /// <param name="standard">The Markdown standard to use.</param>
        /// <returns>The HTML representation of the Markdown nodes.</returns>
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
