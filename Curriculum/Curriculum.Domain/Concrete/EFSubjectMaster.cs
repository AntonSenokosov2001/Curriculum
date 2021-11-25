using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curriculum.Domain.Entities;
using Curriculum.Domain.Abstract;

namespace Curriculum.Domain.Concrete
{
    public class EFSubjectMaster : ISubjectMaster
    {
        private readonly EFDbContext _dbContext;

        public EFSubjectMaster()
        {
            _dbContext = new EFDbContext();
        }

        public IEnumerable<SubjectMaster> SubjectMasters
        {
            get
            {
                return _dbContext.SubjectMasters;
            }
        }

        public SubjectMaster DeleteSubjectMaster(int subjectMasterId)
        {
            SubjectMaster subjectMaster = _dbContext.SubjectMasters.Find(subjectMasterId);

            if (subjectMaster != null)
            {
                _dbContext.SubjectMasters.Remove(subjectMaster);
                _dbContext.SaveChanges();
            }

            return subjectMaster;
        }

        public void SaveSubject(SubjectMaster subjectMaster)
        {
            if (subjectMaster.ID == 0)
            {
                _dbContext.SubjectMasters.Add(subjectMaster);
            }
            else
            {
                SubjectMaster subject = _dbContext.SubjectMasters.Find(subjectMaster.ID);
                if (subject != null)
                {
                    subject.NameSubject = subjectMaster.NameSubject;
                }
            }

            _dbContext.SaveChanges();
        }
    }
}
