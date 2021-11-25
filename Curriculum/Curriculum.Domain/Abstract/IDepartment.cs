using Curriculum.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.Domain.Abstract
{
    public interface IDepartment
    {
        public IEnumerable<Department> Departments { get; }
        void SaveDepartment(Department department);
        Department DeleteDepartment(int departmentId);
    }
}
