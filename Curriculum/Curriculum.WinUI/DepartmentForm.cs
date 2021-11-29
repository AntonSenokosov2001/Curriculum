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
        private readonly EFDbContext _dbContext;
        private readonly EFDepartment _eFDepartment;

        public DepartmentForm()
        {
            InitializeComponent();
            _dbContext = new EFDbContext();
            _eFDepartment = new EFDepartment();
            LoadData();
        }

        public void LoadData()
        {   
            foreach (Department department in _dbContext.Departments)
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
            var index = dataGridView1.CurrentCell.RowIndex;
            var idDepartment = (int)dataGridView1.Rows[index].Cells["DepartmentID"].Value;
            var nameDepartment = dataGridView1.Rows[index].Cells["DepartmentName"].Value.ToString();
            var numberDepartment = (int)dataGridView1.Rows[index].Cells["DepartmentNumber"].Value;

            var departmentForm = new EditDepartment(idDepartment, numberDepartment, nameDepartment);
            departmentForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.CurrentCell.RowIndex;
            var idDepartment = (int)dataGridView1.Rows[index].Cells["DepartmentID"].Value;
            dataGridView1.Rows.RemoveAt(index);

            _eFDepartment.DeleteDepartment(idDepartment);
        }
    }
}
