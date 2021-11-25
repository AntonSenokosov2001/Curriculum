using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curriculum.Domain.Entities;
using Curriculum.Domain.Abstract;

namespace Curriculum.Domain.Concrete
{
    public class EFSubjectBachelor : ISubjectBachelor
    {
        private readonly EFDbContext _dbContext;

        public EFSubjectBachelor()
        {
            _dbContext = new EFDbContext();
        }

        public IEnumerable<SubjectBachelor> SubjectBachelors
        {
            get
            {
                return _dbContext.SubjectBachelors;
            }
        }

        public SubjectBachelor DeleteSubjectBachelor(int subjectBachelorId)
        {
            SubjectBachelor subjectBachelor = _dbContext.SubjectBachelors.Find(subjectBachelorId);

            if (subjectBachelor != null)
            {
                _dbContext.SubjectBachelors.Remove(subjectBachelor);
                _dbContext.SaveChanges();
            }

            return subjectBachelor;
        }

        public void SaveSubjectBachelor(SubjectBachelor subjectBachelor)
        {
            if (subjectBachelor.ID == 0)
            {
                _dbContext.SubjectBachelors.Add(subjectBachelor);
            }
            else
            {
                SubjectBachelor subject = _dbContext.SubjectBachelors.Find(subjectBachelor.ID);
                if (subject != null)
                {
                    subject.NameSubject = subjectBachelor.NameSubject;
                }
            }

            _dbContext.SaveChanges();
        }
    }
}
