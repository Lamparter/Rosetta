> [!CAUTION]
> This project is a work in progress.

# 🪨 Rosetta

#### Decoding the layers of language.

Rosetta is a project that aims to unify the way text is represented in apps.
It creates a common format for all text document types to compile into, with support for a wide variety of features and an extensible framework that allows consumers to build their own custom controls for Rosetta.
Its base is in XML with a custom namespace schema that allows for developing basic documents. It can be expanded using more namespaces, to include support for things like fonts, custom text controls, text formatting, and more!

---

## 🚧 Examples

> Hello **Person**, what is _going_ on with `you`? hi there.

```xml
<!--
    DO NOT MODIFY this file directly unless you are knowledgeable about
    Rosetta and have created a backup copy.  Incorrect changes to this
    file will make it impossible to load the document using an editor.
-->
<Document
    xmlns="http://iviri.us/schemas/2024/rosetta"
    xmlns:type="https://iviri.us/schemas/2024/commonfonts"
    xmlns:f="https://iviri.us/schemas/2024/formatting">

    <Paragraph>
        <Text> <!-- when Font argument is not provided the default is assumed, Aptos -->
            Hello <f:Bold>Person</f:Bold>, what is <f:Italic>going on with <f:Code>you</f:Code>?
        </Text>
        <Text Font="{type:Font Trebuchet}">
            hi there.
        </Text>
    </Paragraph>
</Document>
```

> > a `BlockQuote` element
> ```
> what about a code block?
> ```
> ```cs
> // here's a codeblock with a funny style
> ```
> # a heading!
> ## another heading!!
>
> example
> 
> ^ you'll notice there's a new paragraph change here

```xml
<!--
    DO NOT MODIFY this file directly unless you are knowledgeable about
    Rosetta and have created a backup copy.  Incorrect changes to this
    file will make it impossible to load the document using an editor.
-->
<Document
    xmlns="http://iviri.us/schemas/2024/rosetta"
    xmlns:f="https://iviri.us/schemas/2024/syntax/formatting">
    <Paragraph>
        <BlockQuote>
            a <f:Code>BlockQuote</f:Code> element
        </BlockQuote>
        <FencedCode>
            what about a code block?
        </FencedCode>
        <FencedCode SyntaxHighlight="C#">
            // here's a codeblock with a funny style
        </FencedCode>
    </Paragraph>
    <Paragraph>
        <Heading Iteration="1">
            a heading!
        </Heading>
        <Heading Iteration="2">
            another heading!!
        </Heading>
        <Text>
            example
        </Text>
    </Paragraph>
        <Text>
            ^ you'll notice there's a new paragraph change here
        </Text>
    <Paragraph>
</Document>
```

---

## ✍️ Specification

Rosetta and its syntax is derived from XML and inspired by XAML markup. It follows all the rules of XML.
The root schema and its extensions are documented in this repository. This repository also provides tools for creating and distributing your own Rosetta extensions for building text elements that aren't already included in the BCL.
