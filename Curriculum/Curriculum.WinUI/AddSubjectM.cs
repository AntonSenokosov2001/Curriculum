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
    public partial class AddSubjectM : Form
    {
        private readonly EFSubjectMaster _subjectMaster;

        public AddSubjectM()
        {
            InitializeComponent();
            _subjectMaster = new EFSubjectMaster();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var subject = new SubjectMaster { NameSubject = SubjectName.Text };

            _subjectMaster.SaveSubject(subject);
        }
    }
}
