using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLParsing
{
   public class BaseSettings
    {
        protected string GetValue(string path,string key)
        {
            XmlDocument xmlDoc = GetXml(path);
            XmlNodeList eleList = xmlDoc.SelectNodes("/TestSettings/TestSetting");
            foreach(XmlNode ele in eleList)
            {
                if(ele.FirstChild.Name.Equals(key))
                {
                    return ele.FirstChild.InnerText;
                }
            }
            return null;
        }

        protected XmlDocument GetXml(string path)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(path);
            return xml;

        }
    }
}
