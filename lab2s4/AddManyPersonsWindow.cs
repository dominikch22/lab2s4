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
    public partial class AddManyPersonsWindow : Form
    {
        public event EventHandler<Person> AddPersonToList;

        public AddManyPersonsWindow()
        {
            InitializeComponent();
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            try
            {
                error.Text = "";
                Person person = new Person(nameInput.Text, surnameInput.Text, birthDateInput.Text, cityInput.Text);

                AddPersonToList?.Invoke(this, person);
            }
            catch(Exception ex) {
                error.Text = ex.Message;
            }
           
        }

        private void CloseWindow() {
            this.Close();
        }

        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }
    }
}
