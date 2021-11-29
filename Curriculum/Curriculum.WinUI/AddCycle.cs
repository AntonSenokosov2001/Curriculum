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
    public partial class AddCycle : Form
    {
        private readonly EFCycle _eFCycle;
        public AddCycle()
        {
            InitializeComponent();
            _eFCycle = new EFCycle();
        }

        private void NumCycle_TextChanged(object sender, EventArgs e)
        {
            bool valid = double.TryParse(NumCycle.Text, out double ignored);

            if (valid || NumCycle.Text == "")
            {
                NumCycle.ForeColor = Color.Black;
                label3.Visible = false;
            }
            else
            {
                NumCycle.ForeColor = Color.Red;
                label3.Visible = true;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string numberCycle = NumCycle.Text;
            var cycle = new Cycle { NumberCycle = numberCycle };

            _eFCycle.SaveCycle(cycle);
        }
    }
}
