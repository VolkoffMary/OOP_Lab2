using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Dom :IStrategy
    {
        XmlDocument doc = new XmlDocument();
        public Dom(string path)
        {
            doc.Load(path);
        }
        public List<Person> Algorithm(Person person, string path)
        {
            List<List<Person>> data = new List<List<Person>>();
            try
            {
                var propAndNodes = person.GetPropertiesXNodes();
                foreach (var property in propAndNodes.Keys)
                {
                    var node = propAndNodes[property];
                    if (property() != null)
                        data.Add(SearchByParam(node.NodeName, node.Param, property(), doc, node.Level));
                }
            }
            catch { }
            return Cross(data);
        }
        public static Person Info(XmlNode node)
        { 
            string[] data = new string[8];
            var nodes = Person.GetNodes();
            foreach (var n in nodes)
            { 
                switch (n.Level) 
                {
                    case 0:
                        data[n.Order] = node.ParentNode.ParentNode.Attributes.GetNamedItem(n.Param).Value;
                        break;
                    case 1:
                        data[n.Order] = node.ParentNode.Attributes.GetNamedItem(n.Param).Value;
                        break;
                    case 2:
                        data[n.Order] = node.Attributes.GetNamedItem(n.Param).Value;
                        break;
                    default:
                        break;
                } 
            }
            Person person = new Person(data);
            return person;
        }
        private static List<Person> SearchByParam(string nodename, string val, string param, XmlDocument doc, int level)
        {
            List<Person> people = new List<Person>();
            if (param != String.Empty && param != null)
            {
                XmlNodeList list0 = doc.SelectNodes("//" + nodename + "[@" + val + "=\"" + param + "\"]");
                try
                {
                    switch (level)
                    {
                        case 0:
                            foreach (XmlNode elem0 in list0)
                            {
                                XmlNodeList list1 = elem0.ChildNodes;
                                foreach (XmlNode elem1 in list1)
                                {
                                    XmlNodeList list2 = elem1.ChildNodes;
                                    foreach (XmlNode elem2 in list2)
                                    {
                                        people.Add(Info(elem2));
                                    }
                                }
                            }
                            break;
                        case 1:
                            foreach (XmlNode elem0 in list0)
                            {
                                XmlNodeList list1 = elem0.ChildNodes;
                                foreach (XmlNode elem1 in list1)
                                {
                                    people.Add(Info(elem1));
                                }
                            }
                            break;
                        case 2:
                            foreach (XmlNode elem0 in list0)
                            {
                                    people.Add(Info(elem0));
                            }
                            break;
                        default:
                            break;
                    }
                }
                catch { }
            }
            return people;
        }
        private static List<Person> Cross(List<List<Person>> list)
        {
            List<Person> result = new List<Person>();
            try 
            {
                if (list != null)
                {
                    Person[] people = list[0].ToArray();
                    if (people != null)
                    {
                        foreach (Person person in people)
                        {
                            bool contains = true;
                            foreach (List<Person> elem in list)
                            {
                                if (elem.Count <= 0)
                                    return new List<Person>();
                                foreach (Person p in elem)
                                {
                                    contains = false;
                                    if (person.Compare(p))
                                    {
                                        contains = true;
                                        break;
                                    }
                                }
                                if (!contains)
                                    break;
                            }
                            if (contains)
                                result.Add(person);
                        }
                    }
                }
            }
            catch { }
            return result;
        }
    }
}