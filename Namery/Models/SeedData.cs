using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Namery.Models;
//using MvcPerson.Data;
using System;
using System.Linq;

namespace MvcPerson.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcPersonContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcPersonContext>>()))
            {
                // Look for any people.
                if (context.Person.Any())
                {
                    return;   // DB has been seeded
                }

                context.Person.AddRange(
                    new Person
                    {
                        Id = 1,
                        Name = "Andrew Dina",
                        Notes = "I am you!"
                    },

                    new Person
                    {
                        Id = 1,
                        Name = "Lisa Dina",
                        Notes = "Wife"
                    },

                    new Person
                    {
                        Id = 1,
                        Name = "Andrea Dina",
                        Notes = "Daughter"
                    },

                    new Person
                    {
                        Id = 1,
                        Name = "Timothy Dina",
                        Notes = "Son"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}