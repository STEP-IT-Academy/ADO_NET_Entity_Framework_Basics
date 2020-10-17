using System.Windows.Forms;
using WindowsFormsApp_EF_HW_3.Models;

namespace WindowsFormsApp_EF_HW_3.Forms.ForDogs
{
    public partial class DeleteDogForm : Form
    {
        public DeleteDogForm() => InitializeComponent();

        protected internal Dog GetDog()
        {
            if(textBox1.Text.Length > 0)
            {
                return new Dog { Name = textBox1.Text };
            }
            else
            {
                return null;
            }
        }

        protected internal void ClearTextbox() => textBox1.Clear();
    }
}