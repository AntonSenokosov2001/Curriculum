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
    public partial class EditSubjectM : Form
    {
        private readonly EFSubjectMaster _subjectMaster;
        private int _Id;
        public EditSubjectM(int id, string subject)
        {
            InitializeComponent();
            _subjectMaster = new EFSubjectMaster();
            _Id = id;
            NewSubjectName.Text = subject;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var subject = new SubjectMaster { ID = _Id, NameSubject = NewSubjectName.Text };

            _subjectMaster.SaveSubject(subject);
        }
    }
}
