using System;
using System.Xml;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Riverside.Markup
{
    /// <summary>
    /// A Rosetta document.
    /// </summary>
    /// <remarks>
    /// This struct encapsulates an <see cref="XmlDocument"/> to represent a Rosetta document.
    /// </remarks>
    /// <param name="content">The XML content of the Rosetta document.</param>
    public struct Document(XmlDocument content) : ICloneable, IComparable, IEnumerable, IEnumerable<XmlNode>, IComparable<Document?>, IEquatable<Document?>, IFormattable
    {

        /// <summary>
        /// Gets or sets the XML content of the Rosetta document.
        /// </summary>
        public XmlDocument Content { get; set; } = content;

        /// <summary>
        /// Converts the Rosetta document to its string representation.
        /// </summary>
        /// <returns>A string representation of the Rosetta document.</returns>
        public override readonly string ToString()
        {
            return Content?.OuterXml ?? string.Empty;
        }

        /// <summary>
        /// Converts the Rosetta document to its string representation with format and format provider.
        /// </summary>
        /// <param name="format">The format to use.</param>
        /// <param name="formatProvider">The format provider to use.</param>
        /// <returns>A string representation of the Rosetta document.</returns>
        public readonly string ToString(string format, IFormatProvider formatProvider)
        {
            return ToString();
        }

        /// <summary>
        /// Clones the .NET object.
        /// </summary>
        /// <remarks>
        /// This field is required by the <see cref="ICloneable"/> interface to allow for cloning of the <see cref="Document"/> struct.
        /// </remarks>
        public readonly object Clone() => this;

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <remarks>
        /// This field is required by the <see cref="IComparable"/> interface to allow for comparison of the <see cref="Document"/> struct.
        /// </remarks>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <returns>A value that indicates the relative order of the objects being compared.</returns>
        /// <exception cref="ArgumentException">Thrown when the object is not a Document.</exception>"
        public readonly int CompareTo(object obj)
        {
            if (obj is Document other)
            {
                return string.Compare(ToString(), other.ToString(), StringComparison.Ordinal);
            }
            throw new ArgumentException("Object is not a Document");
        }

        /// <summary>
        /// Compares the current instance with another Document.
        /// </summary>
        /// <param name="other">A Document to compare with this instance.</param>
        /// <returns>A value that indicates the relative order of the objects being compared.</returns>
        public readonly int CompareTo(Document? other)
        {
            if (other is null) return 1;
            return string.Compare(ToString(), other.ToString(), StringComparison.Ordinal);
        }

        /// <summary>
        /// Determines whether the specified Document is equal to the current Document.
        /// </summary>
        /// <param name="other">The Document to compare with the current Document.</param>
        /// <returns>true if the specified Document is equal to the current Document; otherwise, false.</returns>
        public readonly bool Equals(Document? other)
        {
            if (other is null) return false;
            return ToString() == other.ToString();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        public readonly IEnumerator<XmlNode> GetEnumerator() => Content?.DocumentElement?.ChildNodes.Cast<XmlNode>().GetEnumerator() ?? Enumerable.Empty<XmlNode>().GetEnumerator();

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="IEnumerator"/> object that can be used to iterate through the collection.</returns>
        readonly IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
