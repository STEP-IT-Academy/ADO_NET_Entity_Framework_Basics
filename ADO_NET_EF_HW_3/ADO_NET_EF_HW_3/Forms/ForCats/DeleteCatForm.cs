using System.Windows.Forms;
using WindowsFormsApp_EF_HW_3.Models;

namespace WindowsFormsApp_EF_HW_3.Forms.ForCats
{
    public partial class DeleteCatForm : Form
    {
        public DeleteCatForm()
        {
            InitializeComponent();
        }

        protected internal Cat GetCat()
        {
            if (textBox1.Text.Length > 0)
            {
                return new Cat { Name = textBox1.Text };
            }
            else
            {
                return null;
            }
        }

        protected internal void ClearTextbox() => textBox1.Clear();
    }
}