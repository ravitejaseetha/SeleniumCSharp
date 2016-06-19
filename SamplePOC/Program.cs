using SamplePoc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePOC
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] XmlPaths = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\GuiMap\");
            string[] HtmlPaths = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\Html\");
            HtmlParser.CreateHtml(XmlPaths, HtmlPaths);
        }
    }
}
