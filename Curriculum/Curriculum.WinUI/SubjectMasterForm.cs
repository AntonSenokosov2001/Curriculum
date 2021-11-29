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
        private readonly EFDbContext _dbContext;
        private readonly EFSubjectMaster _subjectMaster;

        public SubjectMasterForm()
        {
            InitializeComponent();
            _dbContext = new EFDbContext();
            _subjectMaster = new EFSubjectMaster();
            LoadData();
        }

        public void LoadData()
        {
            foreach(SubjectMaster subjectMaster in _dbContext.SubjectMasters)
            {
                dataGridView1.Rows.Add(subjectMaster.ID, subjectMaster.NameSubject);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var directoryForm = new DirectoryForm();
            directoryForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var AsubjectForm = new AddSubjectM();
            AsubjectForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.CurrentCell.RowIndex;
            var idSubject = (int)dataGridView1.Rows[index].Cells["ID"].Value;
            var nameSubject = dataGridView1.Rows[index].Cells["NameSubject"].Value.ToString();

            var EsubjectForm = new EditSubjectM(idSubject, nameSubject);
            EsubjectForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.CurrentCell.RowIndex;
            var idCycle = (int)dataGridView1.Rows[index].Cells["ID"].Value;
            dataGridView1.Rows.RemoveAt(index);

            _subjectMaster.DeleteSubjectMaster(idCycle);
        }
    }
}
