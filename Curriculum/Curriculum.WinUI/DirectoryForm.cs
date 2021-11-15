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
    public partial class DirectoryForm : Form
    {
        public DirectoryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepartmentForm departmentForm = new DepartmentForm();
            departmentForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SemesterForm semesterForm = new SemesterForm();
            semesterForm.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SubjectMasterForm subjectMasterForm = new SubjectMasterForm();
            subjectMasterForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubjectBachelorForm subjectBachelorForm = new SubjectBachelorForm();
            subjectBachelorForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CycleForm cycleForm = new CycleForm();
            cycleForm.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
