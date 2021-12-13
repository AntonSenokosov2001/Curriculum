using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curriculum.Domain.Entities;
using Curriculum.Domain.Abstract;

namespace Curriculum.Domain.Concrete
{
    public class EFBachelorFourYear : IBachelorFourYear
    {
        private readonly EFDbContext _dbContext;

        public EFBachelorFourYear()
        {
            _dbContext = new EFDbContext();
        }

        public IEnumerable<BachelorFourYear> BachelorFourYears
        {
            get
            {
                return _dbContext.BachelorFourYears;
            }
        }

        public BachelorFourYear DeleteBachelor(int bachelorId)
        {
            BachelorFourYear bachelorFour = _dbContext.BachelorFourYears.Find(bachelorId);

            if (bachelorFour != null)
            {
                _dbContext.BachelorFourYears.Remove(bachelorFour);
                _dbContext.SaveChanges();
            }

            return bachelorFour;
        }

        public void SaveBachelor(BachelorFourYear bachelor)
        {
            if (bachelor.ID == 0)
            {
                _dbContext.BachelorFourYears.Add(bachelor);
            }
            else
            {
                BachelorFourYear bachelorFour = _dbContext.BachelorFourYears.Find(bachelor.ID);

                if (bachelorFour != null)
                {
                    bachelorFour.Cycle.NumberCycle = bachelor.Cycle.NumberCycle;
                    bachelorFour.Department.NumberDepartment = bachelor.Department.NumberDepartment;
                    bachelorFour.Semester.NumberSemester = bachelor.Semester.NumberSemester;
                    bachelorFour.SubjectBachelor.NameSubject = bachelor.SubjectBachelor.NameSubject;
                    bachelorFour.Classroom = bachelor.Classroom;
                    bachelorFour.Credit = bachelor.Credit;
                    bachelorFour.DiffOffset = bachelor.DiffOffset;
                    bachelorFour.Exam = bachelor.Exam;
                    bachelorFour.Independet = bachelor.Independet;
                    bachelorFour.KP = bachelor.KP;
                    bachelorFour.KR = bachelor.KR;
                    bachelorFour.Lab1 = bachelor.Lab1;
                    bachelorFour.Lab2 = bachelor.Lab2;
                    bachelorFour.Laboratirny = bachelor.Laboratirny;
                    bachelorFour.Lectures = bachelor.Lectures;
                    bachelorFour.Lectures1 = bachelor.Lectures1;
                    bachelorFour.Lectures2 = bachelor.Lectures2;
                    bachelorFour.Pract1 = bachelor.Pract1;
                    bachelorFour.Pract2 = bachelor.Pract2;
                    bachelorFour.Practical = bachelor.Practical;
                    bachelorFour.RK = bachelor.RK;
                    bachelorFour.RR = bachelor.RR;
                    bachelorFour.RTR = bachelor.RTR;
                }
            }

            _dbContext.SaveChanges();
        }
    }
}
