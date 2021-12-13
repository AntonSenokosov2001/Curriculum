using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curriculum.Domain.Entities;
using Curriculum.Domain.Abstract;

namespace Curriculum.Domain.Concrete
{
    public class EFMasterTwoYear : IMasterTwoYear
    {
        private EFDbContext _dbContext;

        public EFMasterTwoYear()
        {
            _dbContext = new EFDbContext();
        }

        public IEnumerable<MasterTwoYear> MasterTwoYears
        {
            get
            {
                return _dbContext.MasterTwoYears;
            }
        }

        public MasterTwoYear DeleteMaster(int masterID)
        {
            MasterTwoYear master = _dbContext.MasterTwoYears.Find(masterID);

            if (master != null)
            {
                _dbContext.MasterTwoYears.Remove(master);
                _dbContext.SaveChanges();
            }

            return master;
        }

        public void SaveMaster(MasterTwoYear master)
        {
            if (master.ID == 0)
            {
                _dbContext.MasterTwoYears.Add(master);
            }
            else
            {
                MasterTwoYear masterTwo = _dbContext.MasterTwoYears.Find(master.ID);

                if (masterTwo != null)
                {
                    masterTwo.Cycle.NumberCycle = master.Cycle.NumberCycle;
                    masterTwo.Department.NumberDepartment = master.Department.NumberDepartment;
                    masterTwo.Semester.NumberSemester = master.Semester.NumberSemester;
                    masterTwo.SubjectMaster.NameSubject = master.SubjectMaster.NameSubject;
                    masterTwo.Classroom = master.Classroom;
                    masterTwo.Credit = master.Credit;
                    masterTwo.DiffOffset = master.DiffOffset;
                    masterTwo.Exam = master.Exam;
                    masterTwo.Independet = master.Independet;
                    masterTwo.KP = master.KP;
                    masterTwo.KR = master.KR;
                    masterTwo.Lab1 = master.Lab1;
                    masterTwo.Lab2 = master.Lab2;
                    masterTwo.Laboratirny = master.Laboratirny;
                    masterTwo.Lectures = master.Lectures;
                    masterTwo.Lectures1 = master.Lectures1;
                    masterTwo.Lectures2 = master.Lectures2;
                    masterTwo.Pract1 = master.Pract1;
                    masterTwo.Pract2 = master.Pract2;
                    masterTwo.Practical = master.Practical;
                    masterTwo.RK = master.RK;
                    masterTwo.RR = master.RR;
                    masterTwo.RTR = master.RTR;
                }
            }

            _dbContext.SaveChanges();
        }
    }
}
