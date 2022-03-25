using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_BazaDanych
{
    public partial class Form1 : Form
    {
        /*
        CREATE TABLE [dbo].[Person]
        (
            [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
            [Name] NVARCHAR(50) NOT NULL, 
            [BDate] DATE NOT NULL
        )
        */
        /*
        DatabaseDataContext dt = new DatabaseDataContext();

        Person newP = new Person();
        newP.Name = "Ola";
        newP.BDate = DateTime.Today;

        dt.Persons.InsertOnSubmit(newP);
        dt.SubmitChanges();

        foreach(Person p in  dt.Persons)
        {
            if (MessageBox.Show(p.Name, "Czy usunąć?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dt.Persons.DeleteOnSubmit(p);
            }
            else
            {
                if (MessageBox.Show(p.Name, "Czy UPPER?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    p.Name = p.Name.ToUpper();
                }
            }
        }
        dt.SubmitChanges();
        */

        DatabaseDataContext dt;
        public Form1()
        {
            InitializeComponent();
            dt = new DatabaseDataContext();
            dateTimePickerBDate.MaxDate = DateTime.Today;

            LoadPersons_ClearForm();
        }

        private void LoadPersons_ClearForm()
        {
            listBoxPersons.Items.Clear();

            List<Person> l = dt.Persons.Where(x => x.Name.Contains(textBoxFilterName.Text)).ToList();

            if (radioButtonNameASC.Checked)
            {
                l = l.OrderBy(x => x.Name).ToList();
            }
            else if (radioButtonNameDESC.Checked)
            {
                l = l.OrderByDescending(x => x.Name).ToList();
            }
            else if (radioButtonBDateASC.Checked)
            {
                l = l.OrderBy(x => x.BDate).ToList();
            }
            else if (radioButtonBDateDESC.Checked)
            {
                l = l.OrderByDescending(x => x.BDate).ToList();
            }

            listBoxPersons.Items.AddRange(l.ToArray());

            /*foreach (Person p in dt.Persons)
            {
                listBoxPersons.Items.Add(p);
            }*/

            textBoxName.Text = "";
            textBoxName.BackColor = Color.White;
            dateTimePickerBDate.Value = DateTime.Today;

            listBoxPersons.Enabled = true;
            buttonAdd.Enabled = true;
            buttonDelete.Enabled = false;
            buttonSave.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Person newPerson = new Person(textBoxName.Text, dateTimePickerBDate.Value);

                dt.Persons.InsertOnSubmit(newPerson);
                dt.SubmitChanges();

                LoadPersons_ClearForm();
            }
        }

        private bool ValidateForm()
        {
            if (textBoxName.Text.Length < 3)
            {
                textBoxName.BackColor = Color.FromArgb(255, 255, 150, 150);
                return false;
            }
            return true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxPersons.SelectedItem is Person)
            {
                dt.Persons.DeleteOnSubmit(listBoxPersons.SelectedItem as Person);
                dt.SubmitChanges();
                LoadPersons_ClearForm();
            }
        }

        private void listBoxPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPersons.SelectedItem is Person)
            {
                Person p = listBoxPersons.SelectedItem as Person;

                textBoxName.Text = p.Name;
                dateTimePickerBDate.Value = p.BDate;

                listBoxPersons.Enabled = false;
                buttonAdd.Enabled = false;
                buttonDelete.Enabled = true;
                buttonSave.Enabled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (listBoxPersons.SelectedItem is Person)
            {
                Person p = listBoxPersons.SelectedItem as Person;

                p.Name = textBoxName.Text;
                p.BDate = dateTimePickerBDate.Value;

                dt.SubmitChanges();
                LoadPersons_ClearForm();
            }
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            LoadPersons_ClearForm();
        }

        private void textBoxFilterName_TextChanged(object sender, EventArgs e)
        {
            LoadPersons_ClearForm();
        }
    }
}