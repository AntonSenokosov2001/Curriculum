using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curriculum.WinUI
{
    public partial class EditCycle : Form
    {
        public EditCycle()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void NumCycle_TextChanged(object sender, EventArgs e)
        {
            bool valid = double.TryParse(NumCycle.Text, out double ignored);

            if (valid || NumCycle.Text == "")
            {
                NumCycle.ForeColor = Color.Black;
                label3.Visible = false;
            }
            else
            {
                NumCycle.ForeColor = Color.Red;
                label3.Visible = true;
            }
        }
    }
}
