﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.Domain.Entities
{
    public class UserAutorization
    {
        public int ID { get; set; }
        public int Login { get; set; }
        public int Password { get; set; }
    }
}