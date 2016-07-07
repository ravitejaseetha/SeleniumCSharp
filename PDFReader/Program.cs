using PDFOperation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFReader
{
    class Program
    {

        public static PDFExtract PDFRead
        {
            get
            {
                return new PDFExtract();
            }
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Starting Extraction..........");
            Utils.FileSystemUtil fileUtil = new Utils.FileSystemUtil();
            IList<Models.PdfFile> files = fileUtil.GetAllFiles;

            foreach(Models.PdfFile file in files)
            {
                int numberOfPages = PDFRead.GetNumberOfPages(file.SourcePath);
                for(int i =1; i<= numberOfPages;i++)
                {
                    string pagePath = string.Format(@"{0}\Page{1}",file.TargetPath,i);
                    Utils.FileSystemUtil.CreateDirectory(pagePath);
                    string targetpdf = string.Format(@"{0}\Page{1}.pdf",pagePath,i);
                    ExtractPages(file.SourcePath, targetpdf, i, i);
                    ExtractText(targetpdf);
                    ExtractXml(targetpdf);
                    if(Utils.FileSystemUtil.DeleteSplitAfterExtraction)
                    {
                        DeleteFile(targetpdf);
                    }
                    EndOfExtraction(file.TargetPath);
                    LogIndexFile(Path.GetDirectoryName(file.SourcePath), string.Format("Extracted [{0}/{1}] files: pdf name {2}", files.IndexOf(file) + 1, files.Count(), Path.GetFileName(file.SourcePath)));

                }
            }

        }


        private static void ExtractXml(string targetPdf)
        {
            PDFRead.ExtractXml(targetPdf, Utils.FileSystemUtil.MergePlaintextInTable);
        }

        private static void EndOfExtraction(string path)
        {
            string directory = Path.GetDirectoryName(path);
        }
        private static void DeleteFile(string path)
        {
            File.Delete(path);
        }

        private static void LogIndexFile(string path, string text)
        {
            StreamWriter indexFile;
            if (!File.Exists(string.Format(@"{0}\Index.log", path)))
            {
                indexFile = File.CreateText(string.Format(@"{0}\Index.log", path));
            }
            else
            {
                indexFile = File.AppendText(string.Format(@"{0}\Index.log", path));
            }
            indexFile.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            indexFile.Close();
        }

        private static void ExtractPages(string sourcePath, string targetPath, int startPageNumber, int endPageNumber)
		{
			//ContainerAccess container = new ContainerAccess();
			//AuScGen.PDFOperation.PDFReader pdfReader = container.GetPlugin<AuScGen.PDFOperation.PDFReader>();
			PDFRead.ExtractPages(sourcePath, targetPath, startPageNumber, endPageNumber);

		}

        private static List<string> PDFReader(string path)
        {
            //ContainerAccess container = new ContainerAccess();
            //AuScGen.PDFOperation.PDFReader pdfReader = container.GetPlugin<AuScGen.PDFOperation.PDFReader>();
            string pdfContent = PDFRead.ExtractTextFromPdf(path);
            List<string> values = pdfContent.Split(new string[] { "\n" }, StringSplitOptions.None).ToList();

            return values;
        }

        private static void ExtractText(string path)
        {
            string directory = Path.GetDirectoryName(path);
            string filename = Path.GetFileNameWithoutExtension(path);
            StreamWriter textfile = File.CreateText(string.Format(@"{0}\{1}.txt", directory, filename));
            List<string> textList = PDFReader(path);
            foreach (string text in textList)
            {
                textfile.WriteLine(text);
            }
            textfile.Close();
        }
    }
}
