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
    public partial class DepartmentForm : Form
    {
        EFDbContext dbContext = new EFDbContext();
        public DepartmentForm()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {   
            foreach (Department department in dbContext.Departments)
            {
                dataGridView1.Rows.Add(department.ID, department.NumberDepartment, department.NameDepartment);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
