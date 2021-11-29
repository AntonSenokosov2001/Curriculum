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
using Curriculum.Domain.Abstract;

namespace Curriculum.WinUI
{
    public partial class CycleForm : Form
    {
        private readonly EFDbContext _dbContext;
        private readonly EFCycle _eFCycle;

        public CycleForm()
        {
            InitializeComponent();
            _dbContext = new EFDbContext();
            _eFCycle = new EFCycle();
            LoadData();
        }

        public void LoadData()
        {
            foreach(Cycle cycle in _dbContext.Cycles)
            {
                dataGridView1.Rows.Add(cycle.ID, cycle.NumberCycle);
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
            var AcycleForm = new AddCycle();
            AcycleForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.CurrentCell.RowIndex;
            var idCycle = (int)dataGridView1.Rows[index].Cells["ID"].Value;
            var numCycle = dataGridView1.Rows[index].Cells["NumberCycle"].Value.ToString();
            var EcycleForm = new EditCycle(idCycle, numCycle);
            EcycleForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.CurrentCell.RowIndex;
            var idCycle = (int)dataGridView1.Rows[index].Cells["ID"].Value;
            dataGridView1.Rows.RemoveAt(index);

            _eFCycle.DeleteCycle(idCycle);
        }
    }
}
