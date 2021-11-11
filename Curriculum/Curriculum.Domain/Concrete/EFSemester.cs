using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curriculum.Domain.Entities;
using Curriculum.Domain.Abstract;

namespace Curriculum.Domain.Concrete
{
    public class EFSemester : ISemester
    {
        EFDbContext dbContext = new EFDbContext();
        public IEnumerable<Semester> Semesters
        {
            get
            {
                return dbContext.Semesters;
            }
        }
    }
}
