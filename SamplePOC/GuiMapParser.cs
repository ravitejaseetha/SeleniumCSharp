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
using SamplePOC;

namespace SamplePoc
{
    public class GuiMapParser
    {
         /// <summary>
        /// The logger
        /// </summary>
        //private static log4net.ILog Logger =
        //   log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod()
        //   .DeclaringType);
        //Identifier constants
        /// <summary>
        /// The identifier
        /// </summary>
        private const string id = "id";
        /// <summary>
        /// The name
        /// </summary>
        private const string name = "name";
        /// <summary>
        /// The xpath
        /// </summary>
        private const string xpath = "xpath";
        /// <summary>
        /// The classname
        /// </summary>
        private const string classname = "class";
        /// <summary>
        /// The tagname
        /// </summary>
        private const string tagname = "tagname";
        /// <summary>
        /// The content
        /// </summary>
        private const string content = "content";
        /// <summary>
        /// The atribute
        /// </summary>
        private const string atribute = "atribute";
        /// <summary>
        /// The XML node path
        /// </summary>
        private const string xmlNodePath = "/ObjectRepository/FeatureSet";
        /// <summary>
        /// The GUI map parser
        /// </summary>
        private static GuiMapParser guiMapParser;

        /// <summary>
        /// Prevents a default instance of the <see cref="GuiMapParser" /> class from being created.
        /// </summary>
        public GuiMapParser()
        {
            //log4net.Config.XmlConfigurator.Configure();
            //log4net.ThreadContext.Properties["myContext"] = "Logging from GuiMapParser Class";
            //Logger.Debug("Inside GuiMapParser Constructor!");
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns></returns>
        public static GuiMapParser GetInstance()
        {
            if (guiMapParser == null)
            {
                
                guiMapParser = new GuiMapParser();
                return guiMapParser;
            }
            return guiMapParser;
        }
        public Dictionary<string, Dictionary<string, GuiMap>> LoadGuiMap(string[] files)
        {
            XmlDocument doc = new XmlDocument();
            GuiMap guimap = null;
            Dictionary<string, GuiMap> guiObjCollection = null;
            Dictionary<string, Dictionary<string, GuiMap>> guiObjCollection1 = null;
            guiObjCollection = new Dictionary<string, GuiMap>();
            guiObjCollection1 = new Dictionary<string,Dictionary<string, GuiMap>>();
                foreach (string filename in files)
                {
                    doc.Load(filename);
                    XmlNodeList rootNode = doc.DocumentElement.SelectNodes(xmlNodePath);
                    foreach (XmlNode featureSetNode in rootNode)
                    {
                        XmlNodeList elementNodes = featureSetNode.ChildNodes;
                        foreach (XmlNode node in elementNodes)
                        {
                            guimap = new GuiMap();
                            string logicalName = node.Attributes["name"].InnerText;
                            string identificationType = node.FirstChild.Name;
                            string elementValue = node.FirstChild.InnerText;
                            guimap.LogicalName = logicalName;
                            switch (identificationType.ToLower())
                            {
                                case id:
                                    guimap.IdentificationType = identificationType;
                                    guimap.Id = elementValue;
                                    //Add the logical name and GUIMap to the Object Collection
                                    if (!guiObjCollection.ContainsKey(guimap.LogicalName))
                                    {
                                        guiObjCollection.Add(guimap.LogicalName, guimap);
                                        
                                    }
                                    continue;
                                case name:
                                    guimap.IdentificationType = identificationType;
                                    guimap.Name = elementValue;
                                    //Add the logical name and GUIMap to the Object Collection
                                    if (!guiObjCollection.ContainsKey(guimap.LogicalName))
                                    {
                                        guiObjCollection.Add(guimap.LogicalName, guimap);
                                    }
                                    continue;
                                case xpath:
                                    guimap.IdentificationType = identificationType;
                                    guimap.Xpath = elementValue;
                                    //Add the logical name and GUIMap to the Object Collection
                                    if (!guiObjCollection.ContainsKey(guimap.LogicalName))
                                    {
                                        guiObjCollection.Add(guimap.LogicalName, guimap);
                                       // guiObjCollection1.Add(filename, guiObjCollection);
                                    }
                                    continue;
                                case classname:
                                    guimap.IdentificationType = identificationType;
                                    guimap.ClassName = elementValue;
                                    //Add the logical name and GUIMap to the Object Collection
                                    if (!guiObjCollection.ContainsKey(guimap.LogicalName))
                                    {
                                        guiObjCollection.Add(guimap.LogicalName, guimap);
                                    }
                                    continue;
                                case tagname:
                                    guimap.IdentificationType = identificationType;
                                    guimap.Tagname = elementValue;
                                    //Add the logical name and GUIMap to the Object Collection
                                    if (!guiObjCollection.ContainsKey(guimap.LogicalName))
                                    {
                                        guiObjCollection.Add(guimap.LogicalName, guimap);
                                    } continue;
                                case content:
                                    guimap.IdentificationType = identificationType;
                                    guimap.Content = elementValue;
                                    //Add the logical name and GUIMap to the Object Collection
                                    if (!guiObjCollection.ContainsKey(guimap.LogicalName))
                                    {
                                        guiObjCollection.Add( guimap.LogicalName, guimap);
                                    }
                                    continue;
                                case atribute:
                                    guimap.IdentificationType = identificationType;
                                    guimap.Atribute = elementValue;
                                    //Add the logical name and GUIMap to the Object Collection
                                    if (!guiObjCollection.ContainsKey(guimap.LogicalName))
                                    {
                                        guiObjCollection.Add( guimap.LogicalName, guimap);
                                    } continue;
                            }
                        }
                    }
                    guiObjCollection1.Add(filename, guiObjCollection);
                    guiObjCollection = null;
                    guiObjCollection = new Dictionary<string, GuiMap>();
                }
                return guiObjCollection1;
        }
    }
}
