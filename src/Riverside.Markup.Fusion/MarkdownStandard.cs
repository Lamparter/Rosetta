using System;
using System.Collections.Generic;
using System.Text;

namespace Riverside.Markup.Fusion
{
    /// <summary>
    /// Specifies the Markdown standard to use.
    /// </summary>
    public enum MarkdownStandard
    {
        /// <summary>
        /// The CommonMark standard.
        /// </summary>
        /// <remarks>
        /// Plain, simple markdown.
        /// </remarks>
        CommonMark,

        /// <summary>
        /// GitHub Flavored Markdown.
        /// </summary>
        /// <remarks>
        /// The most feature-rich markdown standard, used by GitHub.
        /// </remarks>
        GitHub,

        /// <summary>
        /// Discord-flavored markdown.
        /// </summary>
        /// <remarks>
        /// The markdown standard used by Discord, a popular chat application.
        /// This standard is similar to GitHub-flavored markdown, but with some differences.
        /// </remarks>
        Discord,

        /// <summary>
        /// Slack-flavored markdown.
        /// </summary>
        Slack,

        /// <summary>
        /// WhatsApp-flavored Markdown.
        /// </summary>
        /// <remarks>
        /// This standard is more plain, but has some unique features and strong differences from other standards.
        /// </remarks>
        WhatsApp
    }
}
