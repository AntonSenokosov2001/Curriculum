using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curriculum.Domain.Entities;

namespace Curriculum.Domain.Abstract
{
    public class IBachelorFourYear
    {
        public IEnumerable<BachelorFourYear> BachelorFourYears { get; }
    }
}
