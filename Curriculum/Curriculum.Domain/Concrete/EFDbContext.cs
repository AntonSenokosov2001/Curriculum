using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curriculum.Domain.Entities;
using System.Data.Entity;

namespace Curriculum.Domain.Concrete
{
    public class EFDbContext: DbContext
    {
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Cycle> Cycles { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<SubjectBachelor> SubjectBachelors { get; set; }
        public DbSet<SubjectMaster> SubjectMasters { get; set; }
        public DbSet<BachelorThreeYear> BachelorThreeYears { get; set; }
        public DbSet<BachelorFourYear> BachelorFourYears { get; set; }
        public DbSet<MasterOneYear> MasterOneYears { get; set; }
        public DbSet<MasterTwoYear> MasterTwoYears { get; set; }
    }
}
