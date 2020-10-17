using System;
using System.Windows.Forms;
using WindowsFormsApp_EF_HW_3.Models;

namespace WindowsFormsApp_EF_HW_3.Forms.ForCats
{
    public partial class UpdateCatForm : Form
    {
        private readonly int catId;

        public UpdateCatForm() => InitializeComponent();

        public UpdateCatForm(Cat cat)
        {
            InitializeComponent();
            catId = cat.Id;
            textBox1.Text = cat.Name;
            textBox2.Text = cat.Weight.ToString();
        }

        protected internal Cat GetCat()
        {
            if(textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                return new Cat { Id = catId, Name = textBox1.Text, Weight = Convert.ToDouble(textBox2.Text) };
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