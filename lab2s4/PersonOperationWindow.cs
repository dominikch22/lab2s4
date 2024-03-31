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
    public partial class PersonOperationWindow : Form
    {
        public event EventHandler<Person> PersonOperation;
        public Person Person;
        public PersonOperationWindow(Person person)
        {
            InitializeComponent();

            Person = (Person)person.Clone();

            nameInput.Text = person.Name;
            surnameInput.Text = person.Surname;
            birthDateInput.Text = $"{person.BirthDate.Day}-{person.BirthDate.Month}-{person.BirthDate.Year}";
            cityInput.Text = person.City;

            this.Text = "Edytowanie osoby";
            AddPersonButton.Text = "Edytuj";
        }
        public PersonOperationWindow() {
            InitializeComponent();

            this.Text = "Dodawanie osoby";
            AddPersonButton.Text = "Dodaj";

            Person = new Person();


        }
      
        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            try
            {
                error.Text = "";
                Person.Name = nameInput.Text;
                Person.Surname = surnameInput.Text;
                Person.BirthDate = DateTime.Parse(birthDateInput.Text);
                Person.City = cityInput.Text;

                FinishWindow();

            }
            catch (Exception ex)
            {
                error.Text = ex.Message;
            }

        }

        private void FinishWindow()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelWindow() {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            CancelWindow();
        }
    }

}
