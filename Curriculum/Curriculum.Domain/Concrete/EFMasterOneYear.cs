using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curriculum.Domain.Entities;
using Curriculum.Domain.Abstract;

namespace Curriculum.Domain.Concrete
{
    public class EFMasterOneYear : IMasterOneYear
    {
        private EFDbContext _dbContext;

        public EFMasterOneYear()
        {
            _dbContext = new EFDbContext();
        }

        public IEnumerable<MasterOneYear> MasterOneYears
        {
            get
            {
                return _dbContext.MasterOneYears;
            }
        }

        public MasterOneYear DeleteMaster(int masterID)
        {
            MasterOneYear master  = _dbContext.MasterOneYears.Find(masterID);

            if (master != null)
            {
                _dbContext.MasterOneYears.Remove(master);
                _dbContext.SaveChanges();
            }

            return master;
        }

        public void SaveMaster(MasterOneYear master)
        {
            if (master.ID == 0)
            {
                _dbContext.MasterOneYears.Add(master);
            }
            else
            {
                MasterOneYear masterOne = _dbContext.MasterOneYears.Find(master.ID);

                if (masterOne != null)
                {
                    masterOne.Cycle.NumberCycle = master.Cycle.NumberCycle;
                    masterOne.Department.NumberDepartment = master.Department.NumberDepartment;
                    masterOne.Semester.NumberSemester = master.Semester.NumberSemester;
                    masterOne.SubjectMaster.NameSubject = master.SubjectMaster.NameSubject;
                    masterOne.Classroom = master.Classroom;
                    masterOne.Credit = master.Credit;
                    masterOne.DiffOffset = master.DiffOffset;
                    masterOne.Exam = master.Exam;
                    masterOne.Independet = master.Independet;
                    masterOne.KP = master.KP;
                    masterOne.KR = master.KR;
                    masterOne.Lab1 = master.Lab1;
                    masterOne.Lab2 = master.Lab2;
                    masterOne.Laboratirny = master.Laboratirny;
                    masterOne.Lectures = master.Lectures;
                    masterOne.Lectures1 = master.Lectures1;
                    masterOne.Lectures2 = master.Lectures2;
                    masterOne.Pract1 = master.Pract1;
                    masterOne.Pract2 = master.Pract2;
                    masterOne.Practical = master.Practical;
                    masterOne.RK = master.RK;
                    masterOne.RR = master.RR;
                    masterOne.RTR = master.RTR;
                }
            }

            _dbContext.SaveChanges();
        }
    }
}
