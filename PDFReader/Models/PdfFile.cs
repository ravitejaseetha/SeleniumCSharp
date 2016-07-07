using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFReader.Models
{
    class PdfFile
    {
        public string SourcePath { get; set; }

        public string TargetPath { get; set; }

        public PdfFile(string source, string target)
        {
            SourcePath = source;
            TargetPath = target;
        }
    }
}
