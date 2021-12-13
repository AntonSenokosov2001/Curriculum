using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curriculum.Domain.Entities;
using Curriculum.Domain.Abstract;

namespace Curriculum.Domain.Concrete
{
    public class EFBachelorThreeYear : IBachelorThreeYear
    {
        private EFDbContext _dbContext;

        public EFBachelorThreeYear()
        {
            _dbContext = new EFDbContext();
        }

        public IEnumerable<BachelorThreeYear> BachelorThreeYears
        {
            get
            {
                return _dbContext.BachelorThreeYears;
            }
        }

        public BachelorThreeYear DeleteBachelor(int bachelorId)
        {
            BachelorThreeYear bachelor = _dbContext.BachelorThreeYears.Find(bachelorId);

            if (bachelor != null)
            {
                _dbContext.BachelorThreeYears.Remove(bachelor);
                _dbContext.SaveChanges();
            }

            return bachelor;
        }

        public void SaveBachelor(BachelorThreeYear bachelor)
        {
            if (bachelor.ID == 0)
            {
                _dbContext.BachelorThreeYears.Add(bachelor);
            }
            else
            {
                BachelorThreeYear bachelorThree = _dbContext.BachelorThreeYears.Find(bachelor.ID);

                if (bachelorThree != null)
                {
                    bachelorThree.Cycle.NumberCycle = bachelor.Cycle.NumberCycle;
                    bachelorThree.Department.NumberDepartment = bachelor.Department.NumberDepartment;
                    bachelorThree.Semester.NumberSemester = bachelor.Semester.NumberSemester;
                    bachelorThree.SubjectBachelor.NameSubject = bachelor.SubjectBachelor.NameSubject;
                    bachelorThree.Classroom = bachelor.Classroom;
                    bachelorThree.Credit = bachelor.Credit;
                    bachelorThree.DiffOffset = bachelor.DiffOffset;
                    bachelorThree.Exam = bachelor.Exam;
                    bachelorThree.Independet = bachelor.Independet;
                    bachelorThree.KP = bachelor.KP;
                    bachelorThree.KR = bachelor.KR;
                    bachelorThree.Lab1 = bachelor.Lab1;
                    bachelorThree.Lab2 = bachelor.Lab2;
                    bachelorThree.Laboratirny = bachelor.Laboratirny;
                    bachelorThree.Lectures = bachelor.Lectures;
                    bachelorThree.Lectures1 = bachelor.Lectures1;
                    bachelorThree.Lectures2 = bachelor.Lectures2;
                    bachelorThree.Pract1 = bachelor.Pract1;
                    bachelorThree.Pract2 = bachelor.Pract2;
                    bachelorThree.Practical = bachelor.Practical;
                    bachelorThree.RK = bachelor.RK;
                    bachelorThree.RR = bachelor.RR;
                    bachelorThree.RTR = bachelor.RTR;
                }
            }

            _dbContext.SaveChanges();
        }
    }
}
