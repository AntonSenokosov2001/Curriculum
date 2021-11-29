using System;
using System.Drawing;
using System.Windows.Forms;
using Curriculum.Domain.Entities;
using Curriculum.Domain.Concrete;

namespace Curriculum.WinUI
{
    public partial class AddSemester : Form
    {
        private readonly EFSemester _semester;
        public AddSemester()
        {
            InitializeComponent();
            _semester = new EFSemester();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var semest = new Semester { NumberSemester = int.Parse(NumSem.Text) };

            _semester.SaveSemester(semest);
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
