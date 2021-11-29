using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Curriculum.Domain.Entities;
using Curriculum.Domain.Concrete;

namespace Curriculum.WinUI
{
    public partial class EditSemester : Form
    {
        private readonly EFSemester _semester;
        private int _Id;

        public EditSemester(int id, int numSemester)
        {
            InitializeComponent();
            _semester = new EFSemester();
            _Id = id;
            NumSem.Text = numSemester.ToString();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var semester = new Semester { ID = _Id, NumberSemester = int.Parse(NumSem.Text) };

            _semester.SaveSemester(semester);
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
