using System;
using System.Windows.Forms;
using WindowsFormsApp_EF_HW_3.Models;

namespace WindowsFormsApp_EF_HW_3.Forms.ForCats
{
    public partial class CreateCatForm : Form
    {
        public CreateCatForm()
        {
            InitializeComponent();
        }

        protected internal Cat GetCat()
        {
            if(textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                return new Cat { Name = textBox1.Text, Weight = Convert.ToDouble(textBox2.Text) };
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