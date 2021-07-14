using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace _18form
{
    public partial class Form1 : Form
    {
        public string text = "";
        public class Magaz
        {
            public string Name { get; set; }
            public string Age { get; set; }
            public string Cost { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
            MagazsConstructor();
        }
        void ClearInput()
        {
            RenameName.Text = string.Empty;
            RenameAge.Text = string.Empty;
            RenameCost.Text = string.Empty;
            InputAge.Text = string.Empty;
            InputName.Text = string.Empty;
            InputCost.Text = string.Empty;
        }
        void MagazsConstructor()
        {
            XDocument xdoc = XDocument.Load("Magaz.xml");
            XElement root = xdoc.Element("magazs");
            List<Magaz> magazs = new List<Magaz>();

            foreach (XElement xe in root.Elements("magaz").ToList())
            {
                Magaz magaz = new Magaz();

                magaz.Name = xe.Attribute("name").Value;
                magaz.Age = xe.Element("age").Value;
                magaz.Cost = xe.Element("cost").Value;

                magazs.Add(magaz);

                List.Items.Clear();
                foreach (Magaz s in magazs)
                    List.Items.Add($"{s.Name} {s.Age} {s.Cost}");
            }
        }
        void RemoveMagaz(string line)
        {
            string[] name = line.Split(" ");
            XDocument xdoc = XDocument.Load("Magaz.xml");
            XElement root = xdoc.Element("magazs");

            foreach (XElement xe in root.Elements("magaz").ToList())
            {
                if (xe.Attribute("name").Value == name[0])
                {
                    xe.Remove();
                }
            }
            xdoc.Save("Magaz.xml");
        }
        void AddMagaz(string name, string age, string cost)
        {
            XDocument xdoc = XDocument.Load("Magaz.xml");
            XElement root = xdoc.Element("magazs");

            root.Add(new XElement("magaz",
                        new XAttribute("name", name),
                        new XElement("age", age),
                        new XElement("cost", cost)));

            xdoc.Save("Magaz.xml");
        }
        private void DeleteMagaz_Click(object sender, EventArgs e)
        {
            if (List.SelectedIndex >= 0)
            {
                RemoveMagaz(List.SelectedItem.ToString());
                List.Items.RemoveAt(List.SelectedIndex);
            }
            MagazsConstructor();
            ClearInput();
        }
        private void AddNewMagaz_Click(object sender, EventArgs e)
        {
            if (InputName.Text.Length > 0 && InputAge.Text.Length > 0 && InputCost.Text.Length > 0)
                AddMagaz(InputName.Text, InputAge.Text, InputCost.Text);
            else
                MessageBox.Show("Есть путое поле или поля");
            MagazsConstructor();
            ClearInput();
        }
        private void DeleteAllMagaz_Click(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load("Magaz.xml");
            XElement root = xdoc.Element("magazs");

            foreach (XElement xe in root.Elements("magaz").ToList())
                    xe.Remove();
            
            xdoc.Save("Magaz.xml");
            List.Items.Clear();
            MagazsConstructor();
            ClearInput();
        }
        private void MagazList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(List.SelectedItem != null)
            {
                string[] line = List.SelectedItem.ToString().Split(" ");
                text = line[0];
                RenameName.Text = line[0];
                RenameAge.Text = line[1];
                RenameCost.Text = line[2];
            }
        }
        private void RenameMagaz_Click(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load("Magaz.xml");
            XElement root = xdoc.Element("magazs");

            foreach (XElement xe in root.Elements("magaz").ToList())
            {
                if (xe.Attribute("name").Value == text)
                {
                    xe.Attribute("name").Value = RenameName.Text;
                    xe.Element("age").Value = RenameAge.Text;
                    xe.Element("cost").Value = RenameCost.Text;
                }
            }
            xdoc.Save("Magaz.xml");
            MagazsConstructor();
        }
    }
}
