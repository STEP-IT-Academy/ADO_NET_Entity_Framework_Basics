using System;
using System.Windows.Forms;

namespace WindowsFormsApp_EF_HW_3.Forms.Common
{
    public partial class GetAnimalForm : Form
    {
        public GetAnimalForm()
        {
            InitializeComponent();
        }

        protected internal int GetId()
        {
            if(textBox1.Text.Length > 0)
            {
                return Convert.ToInt32(textBox1.Text);
            }
            else
            {
                return -1;
            }
        }

        protected internal void ClearTextbox() => textBox1.Clear();
    }
}