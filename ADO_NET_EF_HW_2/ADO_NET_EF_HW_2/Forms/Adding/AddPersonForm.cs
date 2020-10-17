using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp_EF_HW_2.Forms
{
    public partial class AddPersonForm : Form
    {
        public AddPersonForm()
        {
            InitializeComponent();
        }

        public AddPersonForm(List<string> countries)
        {
            InitializeComponent();
            comboBox1.DataSource = countries;
        }
    }
}