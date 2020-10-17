using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp_EF_HW_2.Forms.Editing
{
    public partial class EdPersonForm : Form
    {
        public EdPersonForm()
        {
            InitializeComponent();
        }

        public EdPersonForm(string name, string surname, string dateOfBirth, string phone, List<string> countries)
        {
            InitializeComponent();
            InitializeFormElems(name, surname, dateOfBirth, phone, countries);
        }

        private void InitializeFormElems(string name, string surname, string dateOfBirth, string phone, List<string> countries)
        {
            try
            {
                textBox1.Text = name;
                textBox2.Text = surname;
                textBox3.Text = dateOfBirth;
                textBox4.Text = phone;
                comboBox1.DataSource = countries;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}