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
        private readonly EFSubjectBachelor _subjectBachelor;
        private int _Id;
        public EditSubjectB(int id, string numSemester)
        {
            InitializeComponent();
            _subjectBachelor = new EFSubjectBachelor();
            _Id = id;
            NewSubjectName.Text = numSemester;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var subject = new SubjectBachelor { ID = _Id, NameSubject = NewSubjectName.Text };

            _subjectBachelor.SaveSubjectBachelor(subject);
        }
    }
}
