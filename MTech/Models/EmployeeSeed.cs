using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MTech.Data;
using System;
using System.Linq;

namespace MTech.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MTechContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MTechContext>>()))
            {
                // Look for any movies.
                if (context.Employee.Any())
                {
                    return;   // DB has been seeded
                }
                context.Employee.AddRange(
                    new Employee
                    {
                        Name = "John",
                        LastName = "Doe",
                        RFC = "ABC123456AB1",
                        BornDate = DateTime.Parse("1989-2-12"),
                        EmployeeStatus = 1
                    },
                    new Employee
                    {
                        Name = "Jane",
                        LastName = "Doe",
                        RFC = "ABCD123456AB2",
                        BornDate = DateTime.Parse("1999-2-12"),
                        EmployeeStatus = 1
                    }
                );
                context.SaveChanges();
            }
        }
    }
}