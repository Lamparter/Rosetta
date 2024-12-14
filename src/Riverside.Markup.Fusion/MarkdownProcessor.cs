using System;
using System.Collections.Generic;
using System.Text;

namespace Riverside.Markup.Fusion
{
    public class MarkdownProcessor
    {
        private readonly MarkdownLexer _lexer = new MarkdownLexer();
        private readonly MarkdownParser _parser = new MarkdownParser();
        private readonly HtmlRenderer _renderer = new HtmlRenderer();
        private readonly MarkdownStandard _standard;

        public MarkdownProcessor(MarkdownStandard standard)
        {
            _standard = standard;
        }

        public string ConvertMarkdownToHtml(string markdown)
        {
            var tokens = _lexer.Lex(markdown);
            var ast = _parser.Parse(tokens);
            return _renderer.Render(ast, _standard);
        }
    }
}
