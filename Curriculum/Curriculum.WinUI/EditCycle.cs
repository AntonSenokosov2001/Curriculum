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
    public partial class EditCycle : Form
    {
        private int Id;
        private readonly EFCycle _eFCycle;
        public EditCycle(int id, string num)
        {
            InitializeComponent();
            Id = id;
            _eFCycle = new EFCycle();
            NumCycle.Text = num.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var cycle = new Cycle { ID = Id, NumberCycle = NumCycle.Text };

            _eFCycle.SaveCycle(cycle);
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
    }
}
