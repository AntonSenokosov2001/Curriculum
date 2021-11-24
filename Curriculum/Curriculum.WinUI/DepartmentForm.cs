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

        private void button6_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DirectoryForm directoryForm = new DirectoryForm();
            directoryForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddDepartment departmentForm = new AddDepartment();
            departmentForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditDepartment departmentForm = new EditDepartment(603,"Інженерія програмного забезпечення"); //Сюдой впихнуть номер и название выделенной строки с DataGrid'а
            departmentForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
