using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Person
    {
        private string faculty = null;
        private string department = null;
        private string firstName = null;
        private string lastName = null;
        private string patronym = null;
        private string position = null;
        private string salary = null;
        private string term = null;
        public struct Node
        {
            private string name;
            private string nodename;
            private string param;
            private int level;
            private int order;
            internal Node(string name, string nodename, string param, int l, int o)
            {
                this.name = name;
                this.nodename = nodename;
                this.param = param;
                level = l;
                order = o;
            }
            public string Name
            {
                get { return name; }
            }
            public string NodeName
            {
                get { return nodename; }
            }
            public string Param
            {
                get { return param; }
            }
            public int Level
            {
                get { return level; }
            }
            public int Order
            {
                get { return order; }
            }
        }

        public Person(string[] data)
        {
            faculty = data[0];
            department = data[1];
            firstName = data[2];
            lastName = data[3];
            patronym = data[4];
            position = data[5];
            salary = data[6];
            term = data[7];
        }
        public Func<string>[] GetPropertiesArray()
        {
            Func<string>[] properties = {
                () => Faculty,
                () => Department,
                () => FirstName,
                () => LastName,
                () => Patronym,
                () => Position,
                () => Salary,
                () => Term
            };
            return properties;
        }
        public List<string> GetPropertiesList()
        {
            Func<string>[] properties = GetPropertiesArray();
            List<string> list = new List<string>();
            foreach (var property in properties)
                list.Add(property());

            return list;
        }
        static public List<Node> GetNodes()
        {
            List<Node> list = new List<Node>();
            list.Add(new Node("Faculty", "Faculty", "NAME", 0, 0));
            list.Add(new Node("Department", "Department", "NAME", 1, 1));
            list.Add(new Node("First name", "Person", "FIRSTNAME", 2, 2));
            list.Add(new Node("Last name", "Person", "LASTNAME", 2, 3));
            list.Add(new Node("Patronym", "Person", "PATRONYM", 2, 4));
            list.Add(new Node("Position", "Person", "POSITION", 2, 5));
            list.Add(new Node("Salary", "Person", "SALARY", 2, 6));
            list.Add(new Node("Term", "Person", "TERM", 2, 7));
            return list;
        }
        public Dictionary<Func<string>, Node> GetPropertiesXNodes()
        {
            Dictionary<Func<string>, Node> dict = new Dictionary<Func<string>, Node>();
            var properties = GetPropertiesArray();
            var nodes = GetNodes();
            int i = 0;
            foreach (var node in nodes)
                dict.Add(properties[i++], node);

            return dict;
        }

        public bool Compare(Person p)
        {
            bool flag = (p.Faculty == this.faculty) &&
                        (p.Department == this.department) &&
                        (p.FirstName == this.firstName) &&
                        (p.LastName == this.lastName) &&
                        (p.Patronym == this.patronym) &&
                        (p.Position == this.position) &&
                        (p.Salary == this.salary) &&
                        (p.Term == this.term);
            return flag;
        }
        static public bool IsInList(Person p, List<Person> list)
        {
            bool flag = false;
            foreach (var elem in list)
            {
                flag = flag || p.Compare(elem);
                if (flag)
                    break;
            }  
            return flag;
        }
        public String Faculty
        {
            get { return this.faculty; }
        }
        public String Department
        {
            get { return this.department; }
        }
        public String FirstName
        {
            get { return this.firstName; }
        }
        public String LastName
        {
            get { return this.lastName; }
        }
        public String Patronym
        {
            get { return this.patronym; }
        }
        public String Position
        {
            get { return this.position; }
        }
        public String Salary
        {
            get { return this.salary; }
        }
        public String Term
        {
            get { return this.term; }
        }
    }
}
