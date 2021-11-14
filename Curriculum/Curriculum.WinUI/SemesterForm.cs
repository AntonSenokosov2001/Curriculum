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
    public partial class SemesterForm : Form
    {
        EFDbContext dbContext = new EFDbContext();
        public SemesterForm()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            foreach(Semester semester in dbContext.Semesters)
            {
                dataGridView1.Rows.Add(semester.ID, semester.NumberSemester);
            }
        }
    }
}
