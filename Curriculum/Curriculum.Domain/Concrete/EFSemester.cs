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
        private readonly EFDbContext _dbContext;

        public EFSemester()
        {
            _dbContext = new EFDbContext();
        }

        public IEnumerable<Semester> Semesters
        {
            get
            {
                return _dbContext.Semesters;
            }
        }

        public Semester DeleteSemester(int semesterId)
        {
            Semester semester = _dbContext.Semesters.Find(semesterId);

            if (semester != null)
            {
                _dbContext.Semesters.Remove(semester);
                _dbContext.SaveChanges();
            }

            return semester;
        }

        public void SaveSemester(Semester semester)
        {
            if (semester.ID == 0)
            {
                _dbContext.Semesters.Add(semester);
            }
            else
            {
                Semester sem = _dbContext.Semesters.Find(semester.ID);

                if (sem != null)
                {
                    sem.NumberSemester = semester.NumberSemester;
                }
            }

            _dbContext.SaveChanges();
        }
    }
}
