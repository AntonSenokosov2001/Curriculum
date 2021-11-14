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
    public partial class SubjectMasterForm : Form
    {
        EFDbContext dbContext = new EFDbContext();

        public SubjectMasterForm()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            foreach(SubjectMaster subjectMaster in dbContext.SubjectMasters)
            {
                dataGridView1.Rows.Add(subjectMaster.ID, subjectMaster.NameSubject);
            }
        }
    }
}
