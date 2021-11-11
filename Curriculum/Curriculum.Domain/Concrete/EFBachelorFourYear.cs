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
        EFDbContext dbContext = new EFDbContext();
        public IEnumerable<BachelorFourYear> BachelorFourYears
        {
            get
            {
                return dbContext.BachelorFourYears;
            }
        }
    }
}
