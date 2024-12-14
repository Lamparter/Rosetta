using System;
using System.Collections.Generic;
using System.Text;

namespace Riverside.Markup.Fusion
{
    public abstract class MarkdownNode
    {
        public abstract string ToHtml(MarkdownStandard standard);
    }
}
