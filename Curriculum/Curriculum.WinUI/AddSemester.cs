using System;
using System.Drawing;
using System.Windows.Forms;

namespace Curriculum.WinUI
{
    public partial class AddSemester : Form
    {
        public AddSemester()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {

        }

        private void NumSem_TextChanged(object sender, EventArgs e)
        {
            bool valid = int.TryParse(NumSem.Text, out int ignored);

            if (valid || NumSem.Text == "")
            {
                NumSem.ForeColor = Color.Black;
                label3.Visible = false;
            }
            else
            {
                NumSem.ForeColor = Color.Red;
                label3.Visible = true;
            }
        }
    }
}
