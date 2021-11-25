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
        private readonly EFDbContext _dbContext;
        public EditSubjectM()
        {
            InitializeComponent();
            _dbContext = new EFDbContext();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int subjectID = 0;
            SubjectMaster subjectMaster = _dbContext.SubjectMasters.FirstOrDefault(s => s.ID == subjectID);
        }
    }
}
