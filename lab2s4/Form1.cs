using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2s4
{
    public partial class Form1 : Form
    {
        private Dictionary<int, Person> Persons;
        private Person SelectedPerson;
        public Form1()
        {
            InitializeComponent();
            Persons = new Dictionary<int, Person>();
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            AddManyPersonsWindow addManyPersonsWindow = new AddManyPersonsWindow();
            addManyPersonsWindow.AddPersonToList += AddPerson;

            addManyPersonsWindow.Show();
        }


        public void AddPerson(object sender, Person person) {
            Persons.Add(person.Id, person);

            ShowPersons();
        }

        public void PersonOperation(object sender, Person person) {
            if (Persons.ContainsKey(person.Id)) { 
                
            }
        }

        public void EditPerson(Person person) {
            Person editedPerson;
            Persons.TryGetValue(person.Id, out editedPerson);

            editedPerson.Name = person.Name;
            editedPerson.Surname = person.Surname;
            editedPerson.BirthDate = person.BirthDate;
            editedPerson.City = person.City;

            ShowPersons();
        }

        public void ShowPersons() {
            personsList.Items.Clear();

            foreach (KeyValuePair<int, Person> e in Persons)
            {
                personsList.Items.Add(e.Value);
            }
        }

        private void AddOnePersonButton_Click(object sender, EventArgs e)
        {
            PersonOperationWindow addPersonWindow = new PersonOperationWindow();
            DialogResult result = addPersonWindow.ShowDialog();

            if (result == DialogResult.OK) {
                Persons.Add(addPersonWindow.Person.Id, addPersonWindow.Person);
                ShowPersons();

            }


        }

        private void editPersonButton_Click(object sender, EventArgs e)
        {
            if (SelectedPerson == null)
                return;
            PersonOperationWindow editPersonWindow = new PersonOperationWindow(SelectedPerson);
            DialogResult result = editPersonWindow.ShowDialog();

            if (result == DialogResult.OK)
            {
                EditPerson(editPersonWindow.Person);
            }


        }

        private void personsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPerson = (Person)personsList.SelectedItem;

        }
    }
}
