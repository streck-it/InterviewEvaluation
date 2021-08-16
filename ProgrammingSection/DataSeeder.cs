using System;
using System.Collections.Generic;

namespace InterviewEvaluation
{
    /// <summary>
    /// This code is not in scope for the code review.
    /// Methods for seeding test data for this example.
    /// This is provided to generate sample data if need be
    /// </summary>
    public static class DataSeeder
    {
        public static List<Employee> SeedData()
        {
            var departments = new string[] { "IT", "Finance", "Marketing", "Sales", "Maintenance", "Manufacturing" };
            var jobTitles = new string[] { "Programmer 1", "Programmer 2", "Programmer 3", "Sales Rep 1", "IT Manager", "Director of IT", "Sales Rep 2", "Sales Rep 3", "Controller", "CFO", "Custodian", "RBC Tech", "WBC Tech", "Sterile Services Tech" };
            var employees = new List<Employee>();
            var random = new Random();

            for (int i = 0; i < 1000; i++)
            {
                employees.Add(new Employee()
                {
                    Id = i,
                    FirstName = Guid.NewGuid().ToString(),
                    LastName = Guid.NewGuid().ToString(),
                    Department = departments[i % (departments.Length - 1)],
                    Job_Title = jobTitles[i % (jobTitles.Length - 1)],
                    Salary = random.Next(30000, 100000)
                });
            }

            return employees;
        }
    }
}

