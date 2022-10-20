using System;
using System.Collections.Generic;
using System.Linq;
using TextEngine.Constant;

namespace TextEngine.Parsing
{
    internal sealed class MyFile : IDeliminated
    {
        public string Delimiter { get; set; }
        public string FilePath { get; set; }
        public string Extension { get; set; }
    }
}
