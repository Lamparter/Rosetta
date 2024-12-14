using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Riverside.Markup.Fusion
{
    public class TaskListNode : MarkdownNode
    {
        public string Content { get; }
        public TaskListNode(string content) => Content = content;

        public override string ToHtml(MarkdownStandard standard)
        {
            var match = Regex.Match(Content, Patterns.TaskListPattern);
            if (match.Success)
            {
                var isChecked = match.Groups[1].Value == "x" ? "checked" : "";
                var text = match.Groups[2].Value;
                var disabled = standard == MarkdownStandard.CommonMark ? " disabled" : "";
                return $"<li><input type='checkbox'{(isChecked == "checked" ? " checked" : "")}{disabled}> {text}</li>";
            }
            return "";
        }
    }
}
