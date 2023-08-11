![pdftextextractor](https://raw.githubusercontent.com/jchristn/PdfTextExtractor/main/assets/logo.ico)

# PdfTextExtractor

## Simple C# library for extracting text and metadata from .pdf files

[![NuGet Version](https://img.shields.io/nuget/v/PdfTextExtractor.svg?style=flat)](https://www.nuget.org/packages/PdfTextExtractor/) [![NuGet](https://img.shields.io/nuget/dt/PdfTextExtractor.svg)](https://www.nuget.org/packages/PdfTextExtractor)    

PdfTextExtractor provides simple methods for extracting text and metadata from .pdf files.

## New in v1.0.x

- Initial release

## Disclaimer

This library is a shell wrapper leveraging an excellent Python library called ```pdfplumber```.  As such there are some constraints:

- The ```pdfplumber``` library is MIT-licensed and source can be found on Github: https://github.com/jsvine/pdfplumber
- You must have Python v3.8, 3.9, 3.10, or 3.11 installed
- Python must be accessible in your path as ```py```
- You must ```pip install pdfplumber``` and associated dependencies

This library has been tested on a limited set of documents.  It is highly likely that documents exist this from which the library, in its current state, cannot extract text.

## Simple Examples

Refer to the ```Test``` project for a full example.

```csharp
using DocumentTextExtractor;

void Main(string[] args)
{
  using (PdfTextExtractor pdf = new PdfTextExtractor("mydocument.docx"))
  {
    string text = docx.ExtractText();
    Dictionary<string, string> metadata = docx.ExtractMetadata();
  }
}
```

## Version History

Please refer to CHANGELOG.md.
