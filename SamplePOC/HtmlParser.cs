using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using System.Xml;
using Fizzler.Systems.HtmlAgilityPack;
using System.Xml.XPath;

namespace SamplePoc
{
    public class HtmlParser
    {
        public static void CreateHtml(string[] files, string[] htmls)
        {
            StringBuilder sb = GetHtmlHeader();
            sb = Parser(files, htmls, sb);
            //StringBuilder sn = new StringBuilder();
            //sn.Append("<Html><body background='./../Images/newblue2.png'><table border='1' bgcolor='skyblue' style='width:100%'><tr><th align ='center'>Web Element</th><th align ='center'>Result</th></tr></table></body></html>");

            SaveHtml(sb);
        }

        private static StringBuilder GetHtmlHeader()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<Html>");
            // sb.Append("<Head><script src=\"./../js/Chart.js\"></script></Head>");
            sb.Append("<body>");
            //sb.Append("<img src='logo.png' align='middle' width='1052' height='183'>");
            sb.Append("<center><img src='logo.png' alt='what image shows' height='100' width='300'></center>");
            return sb;
        }

        public static void SaveHtml(StringBuilder sb)
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

        public static StringBuilder Parser(string[] files, string[] htmls, StringBuilder sb)
        {
            sb.Append("<table border='1' style='width:100%'>");
            sb.Append("<tr bgcolor='skyblue'>");
            sb.Append("<th align ='center'>Locators</th>");
            sb.Append("<th align ='center'>Html Page</th>");
            sb.Append("<th align ='center'>Result</th>");
            sb.Append("</tr>");
            sb.Append("<tr>");
            XmlDocument xml = new XmlDocument();
            int inc = 0;
            foreach (var file in files)
            {
                var filenName = Path.GetFileNameWithoutExtension(file);
               // foreach (var html in htmls)
                //{
                    var htmlName = Path.GetFileNameWithoutExtension(htmls[inc]);
                   // if (filenName == htmlName)
                    //{
                        xml.Load(file); //myXmlString is the xml file in string //copying xml to string: string myXmlString = xmldoc.OuterXml.ToString();
                        XmlNodeList xnList = xml.SelectNodes("/FeatureSet[@name='LoginPage']");
                        HtmlDocument document = new HtmlDocument();
                        document.Load(htmls[inc]);
                        //var web = new HtmlDocument();
                        //web.Load("some-url");
                        //var c = web.DocumentNode.QuerySelectorAll("div");
                       
                        XmlNodeList elemList = xml.GetElementsByTagName("id");
                        XmlNodeList elemList1 = xml.GetElementsByTagName("class");
                        XmlNodeList elemList2 = xml.GetElementsByTagName("name");
                        XmlNodeList elemList3 = xml.GetElementsByTagName("xpath");
                        XmlNodeList elemList4 = xml.GetElementsByTagName("css");
                        for (int i = 0; i < elemList1.Count; i++)
                        {
                            string x = elemList1[i].InnerXml;

                            HtmlNode val = document.DocumentNode.SelectSingleNode(string.Format(".//*[@class='{0}']", x));
                            if (val != null)
                            {
                                sb.Append("<td align ='center'>" + x + "</td>");

                                sb.Append("<td align ='center'>" + htmlName + "</td>");
                                sb.Append("<td align ='center' bgcolor ='Green'>True</td>");
                                sb.Append("</tr>");
                                DataFile(string.Format("\nClass '{0}' found in {1} HTML page\n", x, htmlName));
                                // Console.WriteLine("\nClass '{0}' found in {1} HTML page\n", x, htmlName);
                            }
                            else
                            {
                                sb.Append("<td align ='center'>" + x + "</td>");
                                sb.Append("<td align ='center'>" + htmlName + "</td>");
                                sb.Append("<td align ='center' bgcolor ='red'>False</td>");
                                sb.Append("</tr>");
                                DataFile(string.Format("\nClass '{0}' not found in {1} HTML page\n", x, htmlName));
                                //Console.WriteLine("\nClass '{0}' not found in {1} HTML page\n",x,htmlName);
                            }
                        }
                        for (int id = 0; id < elemList.Count; id++)
                        {
                            string xId = elemList[id].InnerXml;
                            HtmlNode val1 = document.DocumentNode.SelectSingleNode(string.Format(".//*[@id='{0}']", xId));
                            if (val1 != null)
                            {
                                sb.Append("<td align ='center'>" + xId + "</td>");
                                sb.Append("<td align ='center'>" + htmlName + "</td>");
                                sb.Append("<td align ='center' bgcolor ='Green'>True</td>");
                                sb.Append("</tr>");
                                DataFile(string.Format("\nId '{0}' found in  {1} HTML page\n", xId, htmlName));
                                //Console.WriteLine("\nId '{0}' found in  {1} HTML page\n", xId, htmlName);
                            }
                            else
                            {
                                sb.Append("<td align ='center'>" + xId + "</td>");
                                sb.Append("<td align ='center'>" + htmlName + "</td>");
                                sb.Append("<td align ='center' bgcolor ='red'>False</td>");
                                sb.Append("</tr>");
                                DataFile(string.Format("\nId '{0}' not found in  {1} HTML page\n", xId, htmlName));
                                // Console.WriteLine("\nId '{0}' not found in  {1} HTML page\n", xId, htmlName);
                            }
                        }

                        for (int xpath = 0; xpath < elemList3.Count; xpath++)
                        {
                            string xXpath = elemList3[xpath].InnerXml;
                            XPathNavigator navigator = document.CreateNavigator();

                            var nodes = navigator.Select(xXpath);
                            var val1 = document.DocumentNode.SelectSingleNode(xXpath);
                            if (val1 != null)
                            {
                                sb.Append("<td align ='center'>" + xXpath + "</td>");
                                sb.Append("<td align ='center'>" + htmlName + "</td>");
                                sb.Append("<td align ='center' bgcolor ='Green'>True</td>");
                                sb.Append("</tr>");
                                DataFile(string.Format("\nXpath '{0}' found in  {1} HTML page\n", xXpath, htmlName));
                                //Console.WriteLine("\nXpath '{0}' found in  {1} HTML page\n", xXpath, htmlName);
                            }
                            else
                            {
                                sb.Append("<td align ='center'>" + xXpath + "</td>");
                                sb.Append("<td align ='center'>" + htmlName + "</td>");
                                sb.Append("<td align ='center' bgcolor ='red'>False</td>");
                                sb.Append("</tr>");
                                DataFile(string.Format("\nXpath '{0}' not found in  {1} HTML page\n", xXpath, htmlName));
                                // Console.WriteLine("\nXpath '{0}' not found in  {1} HTML page\n", xXpath, htmlName);
                            }
                        }

                        for (int name = 0; name < elemList2.Count; name++)
                        {
                            string xName = elemList2[name].InnerXml;
                            HtmlNode h3Node = document.DocumentNode.SelectSingleNode(string.Format("//*[@name='{0}']", xName));
                            if (h3Node != null)
                            {
                                sb.Append("<td align ='center'>" + xName + "</td>");
                                sb.Append("<td align ='center'>" + htmlName + "</td>");
                                sb.Append("<td align ='center' bgcolor ='Green'>True</td>");
                                sb.Append("</tr>");
                                DataFile(string.Format("\nname '{0}' found in  {1} HTML page\n", xName, htmlName));
                                //Console.WriteLine("\nname '{0}' found in  {1} HTML page\n", xName, htmlName);
                            }
                            else
                            {
                                sb.Append("<td align ='center'>" + xName + "</td>");
                                sb.Append("<td align ='center'>" + htmlName + "</td>");
                                sb.Append("<td align ='center' bgcolor ='red'>False</td>");
                                sb.Append("</tr>");
                                DataFile(string.Format("\nname '{0}' not found in  {1} HTML page\n", xName, htmlName));
                                //Console.WriteLine("\nname '{0}' not found in  {1} HTML page\n", xName, htmlName);
                            }

                        }

                        for (int css = 0; css < elemList4.Count; css++)
                        {
                            string xCss = elemList4[css].InnerXml;

                            var h3Node = document.DocumentNode.QuerySelector(xCss);//(xCss,8);
                            
                            if (h3Node != null)
                            {
                                sb.Append("<td align ='center'>" + xCss + "</td>");
                                sb.Append("<td align ='center'>" + htmlName + "</td>");
                                sb.Append("<td align ='center' bgcolor ='Green'>True</td>");
                                sb.Append("</tr>");
                                DataFile(string.Format("\ncss'{0}' found in  {1} HTML page\n", xCss, htmlName));
                                //Console.WriteLine("\ncss'{0}' found in  {1} HTML page\n", xCss, htmlName);
                            }
                            else
                            {
                                sb.Append("<td align ='center'>" + xCss + "</td>");
                                sb.Append("<td align ='center'>" + htmlName + "</td>");
                                sb.Append("<td align ='center' bgcolor ='red'>False</td>");
                                sb.Append("</tr>");
                                DataFile(string.Format("\ncss '{0}' not found in  {1} HTML page\n", xCss, htmlName));
                                //Console.WriteLine("\ncss '{0}' not found in  {1} HTML page\n", xCss, htmlName);
                            }

                        }
                        inc++;
                  //  }

                //}

            }
            sb.Append("</tr>");
            sb.Append("</table>");
            sb.Append("</body>");
            sb.Append("</html>");
            //Console.ReadKey();
            return sb;
        }

        public static void DataFile(string text)
        {

            StreamWriter file2 = new StreamWriter(Directory.GetCurrentDirectory() + @"\Report.txt", true);
            file2.WriteLine(text);
            file2.Close();

        }

        public static void DataFile1(string text)
        {

            StreamWriter file2 = new StreamWriter(Directory.GetCurrentDirectory() + @"\Report.txt");
            file2.WriteLine(text);
            file2.Close();

        }
    }
}
