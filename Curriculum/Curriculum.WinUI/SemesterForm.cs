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
    }
}
