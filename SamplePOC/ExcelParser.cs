using Excel;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Fizzler.Systems.HtmlAgilityPack;

namespace SamplePOC
{
    public class ExcelParser
    {
        public int rowNumber { get; set; }
        public string colName { get; set; }
        public string colValue { get; set; }

        public void CreateHtml(string files, string htmls)
        {
            StringBuilder sb = GetHtmlHeader();
            sb = Parser(files, htmls, sb);
            SaveHtml(sb);
        }
        private StringBuilder GetHtmlHeader()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<Html>");
            sb.Append("<body>");
            sb.Append("<img src='logo.png' align='middle' style='width:15%'>");
            return sb;
        }
        public void SaveHtml(StringBuilder sb)
        {
            string fileName = string.Format(@"{0}\{1}.html", Directory.GetCurrentDirectory(), "Reports");
            FileStream f = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            using (StreamWriter s = new StreamWriter(f))
                s.WriteLine(sb.ToString());
            if (File.Exists("Reports"))
            {
                Console.WriteLine("Report Generated");
            }
        }
        public DataTable ExcelToDataTable(string fileName)
        {
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream); //.xls
            excelReader.IsFirstRowAsColumnNames = true;
            DataSet result = excelReader.AsDataSet();
            DataTableCollection table = result.Tables;
            DataTable resultTable = table["TestParameter"];
            return resultTable;
        }

        List<ExcelParser> dataCol = new List<ExcelParser>();
        public void PopulateDataIncollection(string fileName)
        {

            DataTable table = ExcelToDataTable(fileName);

            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    ExcelParser p1 = new ExcelParser()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };
                    dataCol.Add(p1);
                }
            }
        }

        public string ReadData(int rowNumber, string columnName)
        {

            try
            {
                string data = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).Select(y => y.colValue).SingleOrDefault();
                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<string> ReadDataList(string columnName)
        {

            try
            {
                var data = dataCol.Where(x => x.colName == columnName).Select(y => y.colValue).ToList();
                return data;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public int CountRows(string columnName)
        {
            var count = dataCol.Where(x => x.colName == columnName).Count();
            return count;
        }

        public StringBuilder Parser(string fileDir, string htmlDir, StringBuilder sb)
        {
            List<string> sample = new List<string>();
            PopulateDataIncollection(Directory.GetCurrentDirectory() + @"\TestData\FilesData.xls");
            int fileCount = CountRows("FileName");
            int htmlCount = CountRows("HtmlName");
            sb.Append("<table border='1' style='width:100%'>");
            sb.Append("<tr bgcolor='skyblue'>");
            sb.Append("<th align ='center'>Locator Type</th>");
            sb.Append("<th align ='center'>Locators</th>");
            sb.Append("<th align ='center'>Html Page</th>");
            sb.Append("<th align ='center'>Result</th>");
            sb.Append("</tr>");
            sb.Append("<tr>");
            XmlDocument xml = new XmlDocument();
            int htmlVal = 0;
            for (int file = 1; file <= fileCount; file++)
            {
                xml.Load(string.Format("{0}\\{1}", fileDir, ReadData(file, "FileName")));
                XmlNodeList xnList = xml.SelectNodes("/ObjectRepository/FeatureSet[@name='LoginPage']");
                HtmlDocument document = new HtmlDocument();
                document.Load(string.Format("{0}\\{1}", htmlDir, ReadDataList("HtmlName")[htmlVal]));
                var htmlName = ReadDataList("HtmlName")[htmlVal];
                //var node = xml.ChildNodes;
                XmlNodeList elemList = xml.GetElementsByTagName("id");
                XmlNodeList elemList1 = xml.GetElementsByTagName("class");
                XmlNodeList elemList2 = xml.GetElementsByTagName("name");
                XmlNodeList elemList3 = xml.GetElementsByTagName("xpath");
                XmlNodeList elemList4 = xml.GetElementsByTagName("css");
                for (int i = 0; i < elemList1.Count; i++)
                {
                    string xClass = elemList1[i].InnerXml;

                    HtmlNode val = document.DocumentNode.SelectSingleNode(string.Format(".//*[@class='{0}']", xClass));
                    if (val != null)
                    {
                        sb.Append("<td align ='center'>Class</td>");
                        sb.Append("<td align ='center'>" + xClass + "</td>");
                        sb.Append("<td align ='center'>" + htmlName.Substring(0, htmlName.Length - 5) + "</td>");
                        sb.Append("<td align ='center' bgcolor ='Green'>True</td>");
                        sb.Append("</tr>");
                        DataFile(string.Format("\nClass '{0}' found in {1} HTML page\n", xClass, htmlName));
                    }
                    else
                    {
                        sb.Append("<td align ='center'>Class</td>");
                        sb.Append("<td align ='center'>" + xClass + "</td>");
                        sb.Append("<td align ='center'>" + htmlName.Substring(0, htmlName.Length - 5) + "</td>");
                        sb.Append("<td align ='center' bgcolor ='red'>False</td>");
                        sb.Append("</tr>");
                        DataFile(string.Format("\nClass '{0}' not found in {1} HTML page\n", xClass, htmlName.Substring(0, htmlName.Length - 3)));
                    }
                }
                for (int id = 0; id < elemList.Count; id++)
                {
                    string xId = elemList[id].InnerXml;
                    HtmlNode val1 = document.DocumentNode.SelectSingleNode(string.Format(".//*[@id='{0}']", xId));
                    if (val1 != null)
                    {
                        sb.Append("<td align ='center'>Id</td>");
                        sb.Append("<td align ='center'>" + xId + "</td>");
                        sb.Append("<td align ='center'>" + htmlName.Substring(0, htmlName.Length - 5) + "</td>");
                        sb.Append("<td align ='center' bgcolor ='Green'>True</td>");
                        sb.Append("</tr>");
                        DataFile(string.Format("\nId '{0}' found in  {1} HTML page\n", xId, htmlName));
                    }
                    else
                    {
                        sb.Append("<td align ='center'>Id</td>");
                        sb.Append("<td align ='center'>" + xId + "</td>");
                        sb.Append("<td align ='center'>" + htmlName.Substring(0, htmlName.Length - 5) + "</td>");
                        sb.Append("<td align ='center' bgcolor ='red'>False</td>");
                        sb.Append("</tr>");
                        DataFile(string.Format("\nId '{0}' not found in  {1} HTML page\n", xId, htmlName));
                    }
                }
                for (int xpath = 0; xpath < elemList3.Count; xpath++)
                {
                    string xXpath = elemList3[xpath].InnerXml;
                    HtmlNode val1 = document.DocumentNode.SelectSingleNode(xXpath);
                    if (val1 != null)
                    {
                        sb.Append("<td align ='center'>Xpath</td>");
                        sb.Append("<td align ='center'>" + xXpath + "</td>");
                        sb.Append("<td align ='center'>" + htmlName.Substring(0, htmlName.Length - 5) + "</td>");
                        sb.Append("<td align ='center' bgcolor ='Green'>True</td>");
                        sb.Append("</tr>");
                        DataFile(string.Format("\nXpath '{0}' found in  {1} HTML page\n", xXpath, htmlName));
                    }
                    else
                    {
                        sb.Append("<td align ='center'>Xpath</td>");
                        sb.Append("<td align ='center'>" + xXpath + "</td>");
                        sb.Append("<td align ='center'>" + htmlName.Substring(0, htmlName.Length - 5) + "</td>");
                        sb.Append("<td align ='center' bgcolor ='red'>False</td>");
                        sb.Append("</tr>");
                        DataFile(string.Format("\nXpath '{0}' not found in  {1} HTML page\n", xXpath, htmlName));
                    }
                }
                for (int name = 0; name < elemList2.Count; name++)
                {
                    string xName = elemList2[name].InnerXml;
                    HtmlNode h3Node = document.DocumentNode.SelectSingleNode(string.Format("//*[@name='{0}']", xName));
                    if (h3Node != null)
                    {
                        sb.Append("<td align ='center'>Name</td>");
                        sb.Append("<td align ='center'>" + xName + "</td>");
                        sb.Append("<td align ='center'>" + htmlName.Substring(0, htmlName.Length - 5) + "</td>");
                        sb.Append("<td align ='center' bgcolor ='Green'>True</td>");
                        sb.Append("</tr>");
                        DataFile(string.Format("\nname '{0}' found in  {1} HTML page\n", xName, htmlName));
                    }
                    else
                    {
                        sb.Append("<td align ='center'>Name</td>");
                        sb.Append("<td align ='center'>" + xName + "</td>");
                        sb.Append("<td align ='center'>" + htmlName.Substring(0, htmlName.Length - 5) + "</td>");
                        sb.Append("<td align ='center' bgcolor ='red'>False</td>");
                        sb.Append("</tr>");
                        DataFile(string.Format("\nname '{0}' not found in  {1} HTML page\n", xName, htmlName));
                    }
                }
                for (int css = 0; css < elemList4.Count; css++)
                {
                    string xCss = elemList4[css].InnerXml;

                    var h3Node = document.DocumentNode.QuerySelectorAll(xCss);//(xCss,8);
                    if (h3Node != null)
                    {
                        sb.Append("<td align ='center'>Css</td>");
                        sb.Append("<td align ='center'>" + xCss + "</td>");
                        sb.Append("<td align ='center'>" + htmlName.Substring(0, htmlName.Length - 5) + "</td>");
                        sb.Append("<td align ='center' bgcolor ='Green'>True</td>");
                        sb.Append("</tr>");
                        DataFile(string.Format("\ncss'{0}' found in  {1} HTML page\n", xCss, htmlName));
                    }
                    else
                    {
                        sb.Append("<td align ='center'>Css</td>");
                        sb.Append("<td align ='center'>" + xCss + "</td>");
                        sb.Append("<td align ='center'>" + htmlName.Substring(0, htmlName.Length - 5) + "</td>");
                        sb.Append("<td align ='center' bgcolor ='red'>False</td>");
                        sb.Append("</tr>");
                        DataFile(string.Format("\ncss '{0}' not found in  {1} HTML page\n", xCss, htmlName));
                    }

                }
                //}

                //}
                htmlVal++;
            }
            sb.Append("</tr>");
            sb.Append("</table>");
            sb.Append("</body>");
            sb.Append("</html>");
            return sb;
        }
        public void DataFile(string text)
        {
            StreamWriter file2 = new StreamWriter(Directory.GetCurrentDirectory() + @"\Report.txt", true);
            file2.WriteLine(text);
            file2.Close();
        }
        public void DataFile1(string text)
        {
            StreamWriter file2 = new StreamWriter(Directory.GetCurrentDirectory() + @"\Report.txt");
            file2.WriteLine(text);
            file2.Close();
        }
    }
}
