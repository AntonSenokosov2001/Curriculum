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
    public partial class SubjectMasterForm : Form
    {
        EFDbContext dbContext = new EFDbContext();

        public SubjectMasterForm()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            foreach(SubjectMaster subjectMaster in dbContext.SubjectMasters)
            {
                dataGridView1.Rows.Add(subjectMaster.ID, subjectMaster.NameSubject);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            AddSubjectM AsubjectForm = new AddSubjectM();
            AsubjectForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditSubjectM EsubjectForm = new EditSubjectM();
            EsubjectForm.ShowDialog();
        }
    }
}
