using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Sax : IStrategy
    {
        List<Person> searchResult = new List<Person>();
        XmlTextReader xmlReader;
        public Sax(string path)
        {
            xmlReader = new XmlTextReader(path);
        }
        public List<Person> Algorithm(Person person, string path)
        {
            searchResult.Clear();
            xmlReader = new XmlTextReader(path);
            List<Person> result = new List<Person>();
            string[] data = new string[8];
            while (xmlReader.Read())
            {
                if (xmlReader.Name == "Faculty")
                    while (xmlReader.MoveToNextAttribute())
                        if (xmlReader.Name == "NAME")
                            data[0] = xmlReader.Value;
                if (xmlReader.Name == "Department")
                    while (xmlReader.MoveToNextAttribute())
                        if (xmlReader.Name == "NAME")
                            data[1] = xmlReader.Value;
                if (xmlReader.Name == "Person")
                {
                    if (xmlReader.HasAttributes)
                    {
                        while (xmlReader.MoveToNextAttribute())
                        { 
                            if (xmlReader.Name == "FIRSTNAME")
                                data[2] = xmlReader.Value;
                            if (xmlReader.Name == "LASTNAME")
                                data[3] = xmlReader.Value;
                            if (xmlReader.Name == "PATRONYM")
                                data[4] = xmlReader.Value;
                            if (xmlReader.Name == "POSITION")
                                data[5] = xmlReader.Value;
                            if (xmlReader.Name == "SALARY")
                                data[6] = xmlReader.Value;
                            if (xmlReader.Name == "TERM")
                                data[7] = xmlReader.Value;
                        }
                    }
                    Person p = new Person(data);
                    if (!Person.IsInList(p, result))
                        result.Add(p);
                }
            }

            searchResult = Filtr(result, person);
            return searchResult;
        }
        public List<Person> Filtr(List<Person> people, Person person)
        {
            List<Person> result = new List<Person>();
            if (people != null)
            { 
                foreach (Person p in people)
                {
                    try
                    {
                        bool flag = true;
                        var personPropArray = person.GetPropertiesArray();
                        var pPropArray = p.GetPropertiesArray();
                        for (int i = 0; i < pPropArray.Length; i++)
                        {
                            flag = flag && 
                                (pPropArray[i]() == personPropArray[i]() || personPropArray[i]() == null);
                        }

                        if (flag && !Person.IsInList(p, result))
                            result.Add(p);
                    }
                    catch { }
                }
            }
            return result;
        }
    }
}
