using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Represents a table node in Markdown.
    /// </summary>
    /// <param name="content">The content of the table node.</param>
    public class TableNode(string content) : MarkdownNode
    {
        /// <summary>
        /// Gets the content of the table node.
        /// </summary>
        public string Content { get; } = content;

        /// <summary>
        /// Converts the table node to its HTML representation.
        /// </summary>
        /// <param name="standard">The Markdown standard to use.</param>
        /// <returns>The HTML representation of the table node.</returns>
        public override string ToHtml(MarkdownStandard standard)
        {
            var htmlBuilder = new StringBuilder("<table><tbody>");
            var rows = Content.Split('\n').Where(line => line.StartsWith("|"));
            foreach (var row in rows)
            {
                htmlBuilder.Append("<tr>");
                var columns = row.Trim('|').Split('|');
                foreach (var column in columns)
                {
                    htmlBuilder.AppendFormat("<td>{0}</td>", column.Trim());
                }
                htmlBuilder.Append("</tr>");
            }
            htmlBuilder.Append("</tbody></table>");
            return htmlBuilder.ToString();
        }
    }
}
