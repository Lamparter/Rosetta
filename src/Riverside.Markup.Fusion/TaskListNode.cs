using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Represents a task list node in Markdown.
    /// </summary>
    /// <param name="content">The content of the task list node.</param>
    public class TaskListNode(string content) : MarkdownNode
    {
        /// <summary>
        /// Gets the content of the task list node.
        /// </summary>
        public string Content { get; } = content;

        /// <summary>
        /// Converts the task list node to its HTML representation.
        /// </summary>
        /// <param name="standard">The Markdown standard to use.</param>
        /// <returns>The HTML representation of the task list node.</returns>
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
