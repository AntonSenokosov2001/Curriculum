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
    public partial class CycleForm : Form
    {
        EFDbContext dbContext = new EFDbContext();
        public CycleForm()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            foreach(Cycle cycle in dbContext.Cycles)
            {
                dataGridView1.Rows.Add(cycle.ID, cycle.NumberCycle);
            }
        }
    }
}
