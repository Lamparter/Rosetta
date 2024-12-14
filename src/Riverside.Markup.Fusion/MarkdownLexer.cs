using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Riverside.Markup.Fusion
{
    /// <summary>  
    /// Tokenizes Markdown content into a list of Markdown tokens.  
    /// </summary>  
    public class MarkdownLexer
    {
        /// <summary>  
        /// Tokenizes the specified Markdown content.  
        /// </summary>  
        /// <param name="markdown">The Markdown content to tokenize.</param>  
        /// <returns>A list of Markdown tokens.</returns>  
        public static List<MarkdownToken> Lex(string markdown) // I wanted to call this "MarkdownTokeniser" but a certain group of people wouldn't like it... :D Though for some reason Lexer isn't recognised as a word by the spell checker either...
        {
            var tokens = new List<MarkdownToken>();
            var lines = markdown.Split('\n');

            foreach (var line in lines)
            {
                var remainingLine = line.Trim();
                while (!string.IsNullOrEmpty(remainingLine))
                {
                    if (Regex.IsMatch(remainingLine, Patterns.HeadingPattern))
                    {
                        var match = Regex.Match(remainingLine, Patterns.HeadingPattern);
                        tokens.Add(new MarkdownToken(MarkdownTokenType.Heading, match.Value));
                        remainingLine = remainingLine.Substring(match.Length).Trim();
                    }
                    else if (Regex.IsMatch(remainingLine, Patterns.ImagePattern))
                    {
                        var match = Regex.Match(remainingLine, Patterns.ImagePattern);
                        tokens.Add(new MarkdownToken(MarkdownTokenType.Image, match.Value));
                        remainingLine = remainingLine.Substring(match.Length).Trim();
                    }
                    else if (Regex.IsMatch(remainingLine, Patterns.LinkPattern))
                    {
                        var match = Regex.Match(remainingLine, Patterns.LinkPattern);
                        tokens.Add(new MarkdownToken(MarkdownTokenType.Link, match.Value));
                        remainingLine = remainingLine.Substring(match.Length).Trim();
                    }
                    else if (Regex.IsMatch(remainingLine, Patterns.BoldPattern))
                    {
                        var match = Regex.Match(remainingLine, Patterns.BoldPattern);
                        tokens.Add(new MarkdownToken(MarkdownTokenType.Bold, match.Value));
                        remainingLine = remainingLine.Substring(match.Length).Trim();
                    }
                    else if (Regex.IsMatch(remainingLine, Patterns.ItalicPattern))
                    {
                        var match = Regex.Match(remainingLine, Patterns.ItalicPattern);
                        tokens.Add(new MarkdownToken(MarkdownTokenType.Italic, match.Value));
                        remainingLine = remainingLine.Substring(match.Length).Trim();
                    }
                    else if (Regex.IsMatch(remainingLine, Patterns.ListItemPattern))
                    {
                        var match = Regex.Match(remainingLine, Patterns.ListItemPattern);
                        tokens.Add(new MarkdownToken(MarkdownTokenType.ListItem, match.Value));
                        remainingLine = remainingLine.Substring(match.Length).Trim();
                    }
                    else if (Regex.IsMatch(remainingLine, Patterns.CodeBlockPattern))
                    {
                        var match = Regex.Match(remainingLine, Patterns.CodeBlockPattern);
                        tokens.Add(new MarkdownToken(MarkdownTokenType.CodeBlock, match.Value));
                        remainingLine = remainingLine.Substring(match.Length).Trim();
                    }
                    else if (Regex.IsMatch(remainingLine, Patterns.InlineCodePattern))
                    {
                        var match = Regex.Match(remainingLine, Patterns.InlineCodePattern);
                        tokens.Add(new MarkdownToken(MarkdownTokenType.InlineCode, match.Value));
                        remainingLine = remainingLine.Substring(match.Length).Trim();
                    }
                    else if (Regex.IsMatch(remainingLine, Patterns.BlockquotePattern))
                    {
                        var match = Regex.Match(remainingLine, Patterns.BlockquotePattern);
                        tokens.Add(new MarkdownToken(MarkdownTokenType.Blockquote, match.Value));
                        remainingLine = remainingLine.Substring(match.Length).Trim();
                    }
                    else if (Regex.IsMatch(remainingLine, Patterns.HorizontalRulePattern))
                    {
                        var match = Regex.Match(remainingLine, Patterns.HorizontalRulePattern);
                        tokens.Add(new MarkdownToken(MarkdownTokenType.HorizontalRule, match.Value));
                        remainingLine = remainingLine.Substring(match.Length).Trim();
                    }
                    else if (Regex.IsMatch(remainingLine, Patterns.TablePattern))
                    {
                        var match = Regex.Match(remainingLine, Patterns.TablePattern);
                        tokens.Add(new MarkdownToken(MarkdownTokenType.Table, match.Value));
                        remainingLine = remainingLine.Substring(match.Length).Trim();
                    }
                    else if (Regex.IsMatch(remainingLine, Patterns.TaskListPattern))
                    {
                        var match = Regex.Match(remainingLine, Patterns.TaskListPattern);
                        tokens.Add(new MarkdownToken(MarkdownTokenType.ListItem, match.Value));
                        remainingLine = remainingLine.Substring(match.Length).Trim();
                    }
                    else if (Regex.IsMatch(remainingLine, Patterns.StrikethroughPattern))
                    {
                        var match = Regex.Match(remainingLine, Patterns.StrikethroughPattern);
                        tokens.Add(new MarkdownToken(MarkdownTokenType.Text, match.Value));
                        remainingLine = remainingLine.Substring(match.Length).Trim();
                    }
                    else
                    {
                        tokens.Add(new MarkdownToken(MarkdownTokenType.Text, remainingLine));
                        remainingLine = string.Empty;
                    }
                }
            }
            return tokens;
        }
    }
}
