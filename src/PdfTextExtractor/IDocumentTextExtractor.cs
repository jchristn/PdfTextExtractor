﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentTextExtractor
{
    /// <summary>
    /// Document text extractor abstract class.
    /// </summary>
    public abstract class IDocumentParser
    {
        /// <summary>
        /// Extract metadata from document.
        /// </summary>
        /// <returns>Dictionary containing metadata.</returns>
        public abstract Dictionary<string, string> ExtractMetadata();

        /// <summary>
        /// Extract text from document.
        /// </summary>
        /// <returns>Text contents.</returns>
        public abstract string ExtractText();
    }
}
