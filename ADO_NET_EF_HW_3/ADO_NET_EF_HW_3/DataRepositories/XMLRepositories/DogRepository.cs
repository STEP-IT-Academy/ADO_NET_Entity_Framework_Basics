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
    class DogRepository : IRepository<Dog>
    {
        private XmlDocument document = new XmlDocument();
        private readonly string fileName;

        public DogRepository() => fileName = @"..\..\AppData\XML\dogs.xml";

        public DogRepository(string fileName) => this.fileName = fileName;

        public void Create(Dog item)
        {
            XDocument doc = XDocument.Load(fileName);
            if (doc.XPathSelectElement($"//dog[name='{item.Name}']") == null)
            {
                int lastId = Convert.ToInt32(doc.Descendants("dog").Last().Attribute("id").Value);
                XElement root = new XElement("dog");
                root.Add(new XAttribute("id", ++lastId));
                root.Add(new XElement("name", item.Name));
                root.Add(new XElement("age", item.Age));
                doc.Element("dogs").Add(root);
                doc.Save(fileName);
            }
            else
            {
                throw new Exception("Попытка добавить существущую собаку");
            }
        }

        public void Delete(Dog item)
        {
            document.Load(fileName);
            XmlNode node = document.SelectSingleNode($"//dog[name='{item.Name}']");

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

        public Dog Get(int id)
        {
            document.Load(fileName);
            XmlNode node = document.SelectSingleNode($"//dog[@id='{id}']");

            if(node != null)
            {
                return new Dog { Id = Convert.ToInt32(node.Attributes["id"].Value), Name = node["name"].InnerText, Age = Convert.ToInt32(node["age"].InnerText) };
            }
            else
            {
                throw new Exception("По указанному индексу собака не была найден");
            }
        }

        public IEnumerable<Dog> GetAll()
        {
            document.Load(fileName);
            List<Dog> dogs = new List<Dog>();

            using (XmlNodeList nodes = document.DocumentElement.GetElementsByTagName("dog"))
            {
                foreach (XmlNode node in nodes)
                {
                    dogs.Add(new Dog { Id = Convert.ToInt32(node.Attributes["id"].Value), Name = node["name"].InnerText, Age = Convert.ToInt32(node["age"].InnerText)});
                }
            }
            return dogs;
        }

        public void Update(Dog item)
        {
            document.Load(fileName);
            XmlNode node = document.SelectSingleNode($"//dog[@id='{item.Id}']");
            node["name"].InnerText = item.Name;
            node["age"].InnerText = item.Age.ToString();
            document.Save(fileName);
        }
    }
}