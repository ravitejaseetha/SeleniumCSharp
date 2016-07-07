using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PDFReader.Utils
{
    class FileSystemUtil
    {
        public static string SourceLocation
        {
            get
            {
                return ConfigurationManager.AppSettings["SourceFolder"];
            }
        }
        public static bool MergePlaintextInTable
        {
            get
            {
                return bool.Parse(ConfigurationManager.AppSettings["MergePlainTextInTable"]);
            }
        }

        public static bool DeleteSplitAfterExtraction
        {
            get
            {
                return bool.Parse(ConfigurationManager.AppSettings["DeleteSplitAfterExtraction"]);
            }
        }

        public static string TargetLocation
        {
            get
            {
                string output = ConfigurationManager.AppSettings["DestinationFolder"];
                CreateDirectory(output);
                return output;
            }
        }

        public IList<Models.PdfFile> GetAllFiles
        {
            get
            {
                List<Models.PdfFile> pdffiles = new List<Models.PdfFile>();
                DirectoryInfo di = new DirectoryInfo(SourceLocation);
                List<FileInfo> files = di.GetFiles("*.pdf").ToList();
                foreach (FileInfo file in files)
                {

                    CreateDirectory(string.Format(@"{0}\{1}", TargetLocation, file.Name.Split('.')[0]));

                    pdffiles.Add(new Models.PdfFile(string.Format(@"{0}\{1}", SourceLocation, file.Name), string.Format(@"{0}\{1}", TargetLocation, file.Name.Split('.')[0])));
                }

                return pdffiles;
            }
        }

        public static void CreateDirectory(string path)
        {
            if(!Directory.Exists(path))
            {
                DirectorySecurity securityRules = new DirectorySecurity();
                DirectoryInfo dir = Directory.CreateDirectory(path);
                dir.SetAccessControl(securityRules);
            }
        }
    }
}
