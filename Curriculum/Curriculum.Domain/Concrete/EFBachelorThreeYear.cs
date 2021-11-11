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
        EFDbContext dbContext = new EFDbContext();
        public IEnumerable<BachelorThreeYear> BachelorThreeYears
        {
            get
            {
                return dbContext.BachelorThreeYears;
            }
        }
    }
}
