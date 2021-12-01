using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;
using System.Windows.Forms;


namespace Lab2
{
    public partial class Form1 : Form
    {
        struct Boxes
        {
            public readonly CheckBox checkbox;
            public readonly ComboBox combobox;
            public Boxes(CheckBox check, ComboBox combo)
            {
                checkbox = check;
                combobox = combo;
            }
        }
        private string xmlPath = @"Database.xml";
        private string xslPath = @"Styles.xsl";

        private List<Person> searchResult = new List<Person>();
        private Dictionary<int, Boxes> checkboxes = new Dictionary<int, Boxes>();
        private Dictionary<RadioButton, IStrategy> searchOptions = new Dictionary<RadioButton, IStrategy>();
        public Form1()
        {
            InitializeComponent();
            initRadioButtons();
            initCheckBoxDict();
            initComboBoxes();
        }
        private void initRadioButtons()
        {
            searchOptions.Add(radioButtonDOM, new Dom(xmlPath));
            searchOptions.Add(radioButtonSAX, new Sax(xmlPath));
            searchOptions.Add(radioButtonLINQ, new Linq(xmlPath));
        }
        private void initCheckBoxDict()
        {
            checkboxes.Add(0, new Boxes(checkBoxFaculty, comboBoxFaculty));
            checkboxes.Add(1, new Boxes(checkBoxDepartment, comboBoxDepartment));
            checkboxes.Add(2, new Boxes(checkBoxFirstName, comboBoxFirstName));
            checkboxes.Add(3, new Boxes(checkBoxLastName, comboBoxLastName));
            checkboxes.Add(4, new Boxes(checkBoxPatronym, comboBoxPatronym));
            checkboxes.Add(5, new Boxes(checkBoxPosition, comboBoxPosition));
            checkboxes.Add(6, new Boxes(checkBoxSalary, comboBoxSalary));
            checkboxes.Add(7, new Boxes(checkBoxTerm, comboBoxTerm));
        }
        private void initComboBoxes()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            XmlNodeList list0 = doc.SelectNodes("//Faculty");
            foreach (XmlNode elem0 in list0)
            {
                XmlNodeList list1 = elem0.ChildNodes;
                foreach (XmlNode elem1 in list1)
                {
                    XmlNodeList list2 = elem1.ChildNodes;
                    foreach (XmlNode elem2 in list2)
                    {
                        Person person = Dom.Info(elem2);
                        
                        if (!comboBoxFaculty.Items.Contains(person.Faculty))
                            comboBoxFaculty.Items.Add(person.Faculty);
                        if (!comboBoxDepartment.Items.Contains(person.Department))
                            comboBoxDepartment.Items.Add(person.Department);
                        if (!comboBoxFirstName.Items.Contains(person.FirstName))
                            comboBoxFirstName.Items.Add(person.FirstName);
                        if (!comboBoxLastName.Items.Contains(person.LastName))
                            comboBoxLastName.Items.Add(person.LastName);
                        if (!comboBoxPatronym.Items.Contains(person.Patronym))
                            comboBoxPatronym.Items.Add(person.Patronym);
                        if (!comboBoxPosition.Items.Contains(person.Position))
                            comboBoxPosition.Items.Add(person.Position);
                        if (!comboBoxSalary.Items.Contains(person.Salary))
                            comboBoxSalary.Items.Add(person.Salary);
                        if (!comboBoxTerm.Items.Contains(person.Term))
                            comboBoxTerm.Items.Add(person.Term);
                    }
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Person person = getPerson();
            foreach (var button in searchOptions.Keys)
            {
                if (button.Checked)
                {
                    searchResult = searchOptions[button].Algorithm(person, xmlPath);
                    printResult(searchResult);
                }
            }
        }
        private Person getPerson()
        {
            string[] data = new string[8];
            foreach (var key in checkboxes.Keys)
                if (checkboxes[key].checkbox.Checked)
                {
                    data[key] = Convert.ToString(checkboxes[key].combobox.Text);
                    if (data[key] == "")
                        data[key] = null;
                }        
            Person person = new Person(data);
            return person;
        }
        private void printResult(List<Person> list)
        {
            int i = 1;
            foreach (Person person in list)
            {
                richTextBox1.AppendText(i++ + ".\n");
                var propAndNodes = person.GetPropertiesXNodes();
                foreach (var property in propAndNodes.Keys)
                {
                    var name = propAndNodes[property].Name;
                    richTextBox1.AppendText(name + ": " + property() + "\n");
                }
                richTextBox1.AppendText("======================================\n");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearTextBox();
            clearChoices();
        }
        private void clearTextBox()
        {
            richTextBox1.Clear();
        }
        private void clearChoices()
        {
            clearCheckBoxes();
            clearComboBoxes();
        }
        private void clearCheckBoxes()
        {
            foreach (var box in checkboxes.Values)
            {
                box.checkbox.Checked = false;
            }

        }
        private void clearComboBoxes()
        {
            foreach (var box in checkboxes.Values)
            {
                box.combobox.Text = null;
            }
        }

        private void buttonTransform_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(xslPath);
            string result = @"DatabaseInHtml.html";

            xslt.Transform(xmlPath, result);
        }
    }
}