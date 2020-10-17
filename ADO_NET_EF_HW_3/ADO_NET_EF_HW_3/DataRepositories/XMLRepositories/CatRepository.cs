using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using WindowsFormsApp_EF_HW_3.Interfaces;
using WindowsFormsApp_EF_HW_3.Models;

namespace WindowsFormsApp_EF_HW_3.DataRepositories.XMLRepositories
{
    class CatRepository : IRepository<Cat>
    {
        private XmlDocument document = new XmlDocument();
        private readonly string fileName;

        public CatRepository() => fileName = @"..\..\AppData\XML\cats.xml";

        public CatRepository(string fileName) => this.fileName = fileName;

        public void Create(Cat item)
        {
            XDocument doc = XDocument.Load(fileName);
            if(doc.XPathSelectElement($"//cat[name='{item.Name}']") == null)
            {
                int lastId = Convert.ToInt32(doc.Descendants("cat").Last().Attribute("id").Value);
                XElement root = new XElement("cat");
                root.Add(new XAttribute("id", ++lastId));
                root.Add(new XElement("name", item.Name));
                root.Add(new XElement("weight", item.Weight));
                doc.Element("cats").Add(root);
                doc.Save(fileName);
            }
            else
            {
                throw new Exception("Попытка добавить существующего кота");
            }
        }

        public void Delete(Cat item)
        {
            document.Load(fileName);
            XmlNode node = document.SelectSingleNode($"//cat[name='{item.Name}']");

            if (node != null)
            {
                XmlNode parent = node.ParentNode;
                parent.RemoveChild(node);
                document.Save(fileName);
            }
            else
            {
                throw new Exception("Не удалось найти собаку по указанной кличке");
            }
        }

        public Cat Get(int id)
        {
            document.Load(fileName);
            XmlNode node = document.SelectSingleNode($"//cat[@id='{id}']");

            if(node != null)
            {
                return new Cat { Id = Convert.ToInt32(node.Attributes["id"].Value), Name = node["name"].InnerText, Weight = Convert.ToDouble(node["weight"].InnerText) };
            }
            else
            {
                throw new Exception("По указанному индексу кот не был найден");
            }
        }

        public IEnumerable<Cat> GetAll()
        {
            document.Load(fileName);
            List<Cat> cats = new List<Cat>();

            using (XmlNodeList nodes = document.DocumentElement.GetElementsByTagName("cat"))
            {
                foreach (XmlNode node in nodes)
                {
                    cats.Add(new Cat { Id = Convert.ToInt32(node.Attributes["id"].Value), Name = node["name"].InnerText, Weight = Convert.ToDouble(node["weight"].InnerText) });
                }
            }
            return cats;
        }

        public void Update(Cat item)
        {
            document.Load(fileName);
            XmlNode node = document.SelectSingleNode($"//cat[@id='{item.Id}']");
            node["name"].InnerText = item.Name;
            node["weight"].InnerText = item.Weight.ToString();
            document.Save(fileName);
        }
    }
}