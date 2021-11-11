﻿using Curriculum.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.Domain.Abstract
{
    public interface ISubject
    {
        public IEnumerable<Subject> Subjects { get; }
    }
}
