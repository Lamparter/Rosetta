using System;
using System.Collections.Generic;
using System.Text;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Contains regex patterns for parsing Markdown content.
    /// </summary>
    /// <remarks>
    /// These patterns are used to match various elements in Markdown content.
    /// The patterns were generated using the CommonMark spec as a reference.
    /// </remarks>
    public class Patterns
    {
        // I *may* have used AI to generate these regex patterns...

        /// <summary>
        /// Regex pattern for matching headings.
        /// </summary>
        public const string HeadingPattern = @"^(#{1,6}) (.+)$";
        
        /// <summary>
        /// Regex pattern for matching bold text.
        /// </summary>
        public const string BoldPattern = @"\*\*(.+?)\*\*";
        
        /// <summary>
        /// Regex pattern for matching italic text.
        /// </summary>
        public const string ItalicPattern = @"_(.+?)_";
        
        /// <summary>
        /// Regex pattern for matching links.
        /// </summary>
        public const string LinkPattern = @"\[(.+?)\]\((.+?)\)";
        
        /// <summary>
        /// Regex pattern for matching images.
        /// </summary>
        public const string ImagePattern = @"!\[(.+?)\]\((.+?)\)";
        
        /// <summary>
        /// Regex pattern for matching list items.
        /// </summary>
        public const string ListItemPattern = @"^(\*|-) (.+)$";
        
        /// <summary>
        /// Regex pattern for matching code blocks.
        /// </summary>
        public const string CodeBlockPattern = @"```([^`]*)```";

        /// <summary>
        /// Regex pattern for matching inline code.
        /// </summary>
        public const string InlineCodePattern = @"`([^`]+)`";

        /// <summary>
        /// Regex pattern for matching blockquotes.
        /// </summary>
        public const string BlockquotePattern = @"^> (.+)$";

        /// <summary>
        /// Regex pattern for matching horizontal rules.
        /// </summary>
        public const string HorizontalRulePattern = @"^---$";

        /// <summary>
        /// Regex pattern for matching tables.
        /// </summary>
        public const string TablePattern = @"^(\|.+\|)$";

        /// <summary>
        /// Regex pattern for matching task list items.
        /// </summary>
        public const string TaskListPattern = @"^- \[([ x])\] (.+)$";

        /// <summary>
        /// Regex pattern for matching strikethrough text.
        /// </summary>
        public const string StrikethroughPattern = @"~~(.+?)~~";
    }
}
