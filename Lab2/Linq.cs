using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Linq : IStrategy
    {
        List<Person> searchResult = new List<Person>();
        XDocument doc = new XDocument();

        public Linq(string path)
        {
            doc = XDocument.Load(path);
        }

        public List<Person> Algorithm(Person person, string path)
        {
            searchResult.Clear();
            List<XElement> match = (from val in doc.Descendants("Person")
                                    where
                                    (
                                    (person.Faculty == null || 
                                        person.Faculty == val.Parent.Parent.Attribute("NAME").Value) &&
                                    (person.Department == null || 
                                        person.Department == val.Parent.Attribute("NAME").Value) &&
                                    (person.FirstName == null || 
                                        person.FirstName == val.Attribute("FIRSTNAME").Value) &&
                                    (person.LastName == null || person.LastName == val.Attribute("LASTNAME").Value) &&
                                    (person.Patronym == null || person.Patronym == val.Attribute("PATRONYM").Value) &&
                                    (person.Position == null || person.Position == val.Attribute("POSITION").Value) &&
                                    (person.Salary == null || person.Salary == val.Attribute("SALARY").Value) &&
                                    (person.Term == null || person.Term == val.Attribute("TERM").Value))
                                    select val).ToList();
            foreach (XElement elem in match)
            {
                string[] data = new string[8];
                var nodes = Person.GetNodes();
                foreach (var n in nodes)
                {
                    switch (n.Level)
                    {
                        case 0:
                            data[n.Order] = elem.Parent.Parent.Attribute(n.Param).Value;
                            break;
                        case 1:
                            data[n.Order] = elem.Parent.Attribute(n.Param).Value;
                            break;
                        case 2:
                            data[n.Order] = elem.Attribute(n.Param).Value;
                            break;
                        default:
                            break;
                    }
                }
                Person p = new Person(data);
                searchResult.Add(p);
            }
            return searchResult;
        }
    }
}
