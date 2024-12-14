using System;
using System.Collections.Generic;
using System.Text;

namespace Riverside.Markup.Fusion
{
    public class Patterns
    {
        // I *may* have used AI to generate these regex patterns...
        public const string HeadingPattern = @"^(#{1,6}) (.+)$";
        public const string BoldPattern = @"\*\*(.+?)\*\*";
        public const string ItalicPattern = @"_(.+?)_";
        public const string LinkPattern = @"\[(.+?)\]\((.+?)\)";
        public const string ImagePattern = @"!\[(.+?)\]\((.+?)\)";
        public const string ListItemPattern = @"^(\*|-) (.+)$";
        public const string CodeBlockPattern = @"```([^`]*)```";
        public const string InlineCodePattern = @"`([^`]+)`";
        public const string BlockquotePattern = @"^> (.+)$";
        public const string HorizontalRulePattern = @"^---$";
        public const string TablePattern = @"^(\|.+\|)$";
        public const string TaskListPattern = @"^- \[([ x])\] (.+)$";
        public const string StrikethroughPattern = @"~~(.+?)~~";
    }
}
