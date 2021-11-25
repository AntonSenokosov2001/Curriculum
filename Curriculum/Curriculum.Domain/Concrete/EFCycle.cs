using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curriculum.Domain.Entities;
using Curriculum.Domain.Abstract;

namespace Curriculum.Domain.Concrete
{
    public class EFCycle : ICycle
    {
        private readonly EFDbContext _dbContext;

        public EFCycle()
        {
            _dbContext = new EFDbContext();
        }

        public IEnumerable<Cycle> Cycles
        {
            get
            {
                return _dbContext.Cycles;
            }
        }

        public Cycle DeleteCycle(int cycleID)
        {
            Cycle cycle = _dbContext.Cycles.Find(cycleID);

            if (cycle != null)
            {
                _dbContext.Cycles.Remove(cycle);
                _dbContext.SaveChanges();
            }

            return cycle;
        }

        public void SaveCycle(Cycle cycle)
        {
            if (cycle.ID == 0)
            {
                _dbContext.Cycles.Add(cycle);
            }
            else
            {
                Cycle cyclerep = _dbContext.Cycles.Find(cycle.ID);

                if (cyclerep != null)
                {
                    cyclerep.NumberCycle = cycle.NumberCycle;
                }
            }

            _dbContext.SaveChanges();
        }
    }
}
