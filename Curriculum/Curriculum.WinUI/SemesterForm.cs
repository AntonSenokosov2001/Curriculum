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
        private readonly EFDbContext _dbContext;
        private readonly EFSemester _semester;
        public SemesterForm()
        {
            InitializeComponent();
            _dbContext = new EFDbContext();
            _semester = new EFSemester();
            LoadData();
        }

        public void LoadData()
        {
            foreach(Semester semester in _dbContext.Semesters)
            {
                dataGridView1.Rows.Add(semester.ID, semester.NumberSemester);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DirectoryForm directoryForm = new DirectoryForm();
            directoryForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var semesterForm = new AddSemester();
            semesterForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.CurrentCell.RowIndex;
            var idSemester = (int)dataGridView1.Rows[index].Cells["ID"].Value;
            var numSemester = (int)dataGridView1.Rows[index].Cells["NumberSemester"].Value;

            var semesterForm = new EditSemester(idSemester, numSemester);
            semesterForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.CurrentCell.RowIndex;
            var idCycle = (int)dataGridView1.Rows[index].Cells["ID"].Value;
            dataGridView1.Rows.RemoveAt(index);

            _semester.DeleteSemester(idCycle);
        }
    }
}
