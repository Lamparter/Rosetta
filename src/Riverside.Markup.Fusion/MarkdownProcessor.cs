using System;
using System.Collections.Generic;
using System.Text;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Processes Markdown content and converts it to HTML.
    /// </summary>
    /// <param name="standard">The Markdown standard to use.</param>
    public class MarkdownProcessor(MarkdownStandard standard)
    {
        private readonly MarkdownLexer _lexer = new();
        private readonly MarkdownParser _parser = new();
        private readonly HtmlRenderer _renderer = new();
        private readonly MarkdownStandard _standard = standard;

        /// <summary>
        /// Converts the specified Markdown content to HTML.
        /// </summary>
        /// <param name="markdown">The Markdown content to convert.</param>
        /// <returns>The HTML representation of the Markdown content.</returns>
        public string ConvertMarkdownToHtml(string markdown)
        {
            var tokens = _lexer.Lex(markdown);
            var ast = _parser.Parse(tokens);
            return _renderer.Render(ast, _standard);
        }
    }
}
