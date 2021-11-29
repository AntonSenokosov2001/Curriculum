using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Curriculum.Domain.Concrete;
using Curriculum.Domain.Entities;

namespace Curriculum.WinUI
{
    public partial class SubjectBachelorForm : Form
    {
        private readonly EFDbContext _dbContext;
        private readonly EFSubjectBachelor _subjectBachelor;
        public SubjectBachelorForm()
        {
            InitializeComponent();
            _dbContext = new EFDbContext();
            _subjectBachelor = new EFSubjectBachelor();
            LoadData();
        }

        public void LoadData()
        {
            foreach(var subjectBachelor in _dbContext.SubjectBachelors)
            {
                dataGridView1.Rows.Add(subjectBachelor.ID, subjectBachelor.NameSubject);
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
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var AsubjectForm = new AddSubjectB();
            AsubjectForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.CurrentCell.RowIndex;
            var idCycle = (int)dataGridView1.Rows[index].Cells["ID"].Value;
            var numCycle = dataGridView1.Rows[index].Cells["NameSubject"].Value.ToString();

            var EsubjectForm = new EditSubjectB(idCycle, numCycle);
            EsubjectForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.CurrentCell.RowIndex;
            var idCycle = (int)dataGridView1.Rows[index].Cells["ID"].Value;
            dataGridView1.Rows.RemoveAt(index);

            _subjectBachelor.DeleteSubjectBachelor(idCycle);
        }
    }
}
