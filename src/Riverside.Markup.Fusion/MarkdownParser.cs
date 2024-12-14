using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Riverside.Markup.Fusion;

public class MarkdownParser
{
    public List<MarkdownNode> Parse(List<MarkdownToken> tokens)
    {
        var nodes = new List<MarkdownNode>();

        foreach (var token in tokens)
        {
            switch (token.Type)
            {
                case MarkdownTokenType.Heading:
                    nodes.Add(new HeadingNode(token.Content));
                    break;
                case MarkdownTokenType.Bold:
                    nodes.Add(new BoldNode(token.Content));
                    break;
                case MarkdownTokenType.Italic:
                    nodes.Add(new ItalicNode(token.Content));
                    break;
                case MarkdownTokenType.ListItem:
                    if (Regex.IsMatch(token.Content, Patterns.TaskListPattern))
                    {
                        nodes.Add(new TaskListNode(token.Content));
                    }
                    else
                    {
                        nodes.Add(new ListItemNode(token.Content));
                    }
                    break;
                case MarkdownTokenType.CodeBlock:
                    nodes.Add(new CodeBlockNode(token.Content));
                    break;
                case MarkdownTokenType.Table:
                    nodes.Add(new TableNode(token.Content));
                    break;
                case MarkdownTokenType.Link:
                    nodes.Add(new LinkNode(token.Content));
                    break;
                case MarkdownTokenType.Image:
                    nodes.Add(new ImageNode(token.Content));
                    break;
                case MarkdownTokenType.Text:
                    if (Regex.IsMatch(token.Content, Patterns.StrikethroughPattern))
                    {
                        nodes.Add(new StrikethroughNode(token.Content));
                    }
                    else
                    {
                        nodes.Add(new TextNode(token.Content));
                    }
                    break;
            }
        }

        return nodes;
    }
}