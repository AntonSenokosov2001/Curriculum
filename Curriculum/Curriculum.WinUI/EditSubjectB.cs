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
    public partial class EditSubjectB : Form
    {
        private readonly EFSemester _semester;
        private int _Id;
        public EditSubjectB(int id, int numSemester)
        {
            InitializeComponent();
            _semester = new EFSemester();
            _Id = id;
            NewSubjectName.Text = numSemester.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
