using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Namery.Models;

    public class NameryContext : DbContext
    {
        public NameryContext (DbContextOptions<NameryContext> options)
            : base(options)
        {
        }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PersonTag>().HasKey(pt => new { pt.PersonId, pt.TagId });
    }


    public DbSet<Namery.Models.Person> Person { get; set; }

        public DbSet<Namery.Models.Tag> Tag { get; set; }

        public DbSet<PersonTag> PersonTags { get; set; }
    }
