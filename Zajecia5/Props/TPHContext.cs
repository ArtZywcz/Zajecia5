﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia5.Props
{
    class TPHContext:DbContext
    {
        public DbSet<Computer> Computers { get; set; }
    }
}
