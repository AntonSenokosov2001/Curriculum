using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curriculum.Domain.Entities;
using Curriculum.Domain.Abstract;

namespace Curriculum.Domain.Concrete
{
    public class EFDepartment : IDepartment
    {
        private readonly EFDbContext _dbContext;

        public EFDepartment()
        {
            _dbContext = new EFDbContext();
        }

        public IEnumerable<Department> Departments
        {
            get
            {
                return _dbContext.Departments;
            }
        }

        public Department DeleteDepartment(int departmentId)
        {
            Department department = _dbContext.Departments.Find(departmentId);

            if (department != null)
            {
                _dbContext.Departments.Remove(department);
                _dbContext.SaveChanges();
            }

            return department;
        }

        public void SaveDepartment(Department department)
        {
            if (department.ID == 0)
            {
                _dbContext.Departments.Add(department);
            }
            else
            {
                Department departments = _dbContext.Departments.Find(department.ID);

                if (departments != null)
                {
                    departments.NameDepartment = department.NameDepartment;
                    departments.NumberDepartment = department.NumberDepartment;
                }
            }

            _dbContext.SaveChanges();
        }
    }
}
