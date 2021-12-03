﻿//------------------------------------------------------------------------------------------------------------------------------------
// Copyright 2021 Dassault Systèmes - CPE EMED
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify,
// merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished
// to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS
// BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//------------------------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace ds.enovia.dslc.model
{
    public class VersionAncestor
    {
        [JsonPropertyName("edgeType")]
        public string edgeType { get; set; }

        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("identifier")]
        public string identifier { get; set; }

        [JsonPropertyName("source")]
        public string source { get; set; }

        [JsonPropertyName("type")]
        public string type { get; set; }

        [JsonPropertyName("relativePath")]
        public string relativePath { get; set; }

    }
}
