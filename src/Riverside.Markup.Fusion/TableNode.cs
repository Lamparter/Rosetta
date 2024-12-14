using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Riverside.Markup.Fusion
{
    public class TableNode : MarkdownNode
    {
        public string Content { get; }
        public TableNode(string content) => Content = content;

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
