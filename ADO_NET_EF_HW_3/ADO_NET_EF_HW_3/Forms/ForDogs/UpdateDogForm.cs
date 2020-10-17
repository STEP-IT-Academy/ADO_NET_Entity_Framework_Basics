using System;
using System.Windows.Forms;
using WindowsFormsApp_EF_HW_3.Models;

namespace WindowsFormsApp_EF_HW_3.Forms.ForDogs
{
    public partial class UpdateDogForm : Form
    {
        private readonly int dogId;

        public UpdateDogForm() => InitializeComponent();

        public UpdateDogForm(Dog dog)
        {
            InitializeComponent();
            textBox1.Text = dog.Name;
            textBox2.Text = dog.Age.ToString();
            dogId = dog.Id;
        }

        protected internal Dog GetDog()
        {
            if(textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                return new Dog { Id = dogId, Name = textBox1.Text, Age = Convert.ToInt32(textBox2.Text) };
            }
            else
            {
                return null;
            }
        }

        protected internal void ClearTextboxes()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}