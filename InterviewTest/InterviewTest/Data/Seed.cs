using InterviewTest.Data;
using InterviewTest.Models;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using System.Net;

namespace RunGroopWebApp.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Employees.Any())
                {
                    context.Employees.AddRange(new List<Employee>()
                    {
                        new Employee()
                        {
                            Name = "Xiao Ming",
                            Age = 21,
                            Department = new Department()
                            {
                                Designation = "Team Lead"
                            }
                         },
                        new Employee()
                        {
                            Name = "Xiao Wang",
                            Age = 22,
                            Department = new Department()
                            {
                                Designation = "Developer"
                            }
                         },
                        new Employee()
                        {
                            Name = "Xiao Mei",
                            Age = 23,
                            Department = new Department()
                            {
                                Designation = "Developer"
                            }
                         },
                        new Employee()
                        {
                            Name = "Xiao Li",
                            Age = 24,
                            Department = new Department()
                            {
                                Designation = "Senior Developer"
                            }
                         },
                        new Employee()
                        {
                            Name = "Xiao Qiang",
                            Age = 25,
                            Department = new Department()
                            {
                                Designation = "Senior Developer"
                            }
                         },

                    });
                    context.SaveChanges();
                }

            }
        }
    }
}