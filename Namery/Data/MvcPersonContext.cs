using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Namery.Models;

    public class MvcPersonContext : DbContext
    {
        public MvcPersonContext (DbContextOptions<MvcPersonContext> options)
            : base(options)
        {
        }

        public DbSet<Namery.Models.Person> Person { get; set; }
    }
