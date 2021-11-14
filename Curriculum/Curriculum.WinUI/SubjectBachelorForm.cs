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
        EFDbContext dbContext = new EFDbContext();
        public SubjectBachelorForm()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            foreach(SubjectBachelor subjectBachelor in dbContext.SubjectBachelors)
            {
                dataGridView1.Rows.Add(subjectBachelor.ID, subjectBachelor.NameSubject);
            }
        }
    }
}
