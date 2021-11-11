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
        DbSet<Semester> Semesters { get; set; }
        DbSet<Cycle> Cycles { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<SubjectBachelor> SubjectBachelors { get; set; }
        DbSet<SubjectMaster> SubjectMasters { get; set; }
        DbSet<BachelorThreeYear> BachelorThreeYears { get; set; }
        DbSet<BachelorFourYear> BachelorFourYears { get; set; }
        DbSet<MasterOneYear> MasterOneYears { get; set; }
        DbSet<MasterTwoYear> MasterTwoYears { get; set; }
    }
}
