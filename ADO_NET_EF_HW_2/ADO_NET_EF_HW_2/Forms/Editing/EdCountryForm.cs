using System.Windows.Forms;

namespace WindowsFormsApp_EF_HW_2.Forms.Editing
{
    public partial class EdCountryForm : Form
    {
        public EdCountryForm()
        {
            InitializeComponent();
        }

        public EdCountryForm(string countryName)
        {
            InitializeComponent();
            textBox1.Text = countryName;
        }
    }
}