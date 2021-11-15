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
    public partial class MasterOne : Form
    {
        EFDbContext dbContext = new EFDbContext();
        public MasterOne()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            foreach(Cycle cycle in dbContext.Cycles)
            {
                Column1.Items.Add(cycle.NumberCycle);
            }

            foreach(Semester semester in dbContext.Semesters)
            {
                Column2.Items.Add(semester.NumberSemester);
            }

            foreach(SubjectMaster subjectMaster in dbContext.SubjectMasters)
            {
                Column3.Items.Add(subjectMaster.NameSubject);
            }

            foreach(Department department in dbContext.Departments)
            {
                Column4.Items.Add(department.NumberDepartment);
            }
        }
    }
}
