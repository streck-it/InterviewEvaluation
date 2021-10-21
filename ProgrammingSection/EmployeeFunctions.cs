using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewEvaluation
{
    /// <summary>
    /// Below is a series of functions to retrieve and modify a collection of employee data.  These functions are meant to not require any outside dependencies like a database.
    /// For that reason, a collection of Employees will be created in the constructor of the EmployeeFunctions class to simulate a table of Employees.
    ///
    /// Please review the code below and come prepared to talk about any changes you would make to improve readability, accuracy, consistency, and organization of the code.
    /// It is important to note there is no correct answer here. This is just an exercise to evaluate your ability to read code.  
    /// As well as to see how you communicate with other members of the team about the code.
    /// </summary>
    public class EmployeeFunctions
    {
        private List<Employee> Employees = null;

        public EmployeeFunctions()
        {
            //This exercise is meant to be self contained.
            //This collection of employee data is meant to replicate data you may query from a database, repository, or other source.
            Employees = new List<Employee>()
            {
                new Employee(1, "John","Doe", "IT", "Programmer", 10000),
                new Employee(2, "John", "Dont", "Finance", "CFO", 10000),
                new Employee(3, "Jane", "Doe", "Sales", "Domestic Sales Rep", 10000),
                new Employee(4, "Jane", "Dont", "Maintenance", "Custodian", 10000)
            };
        }

        /// <summary>
        /// Return a collection of <see cref="Employee"/> within an inclusive salary range.
        /// </summary>
        /// <param name="minSalary">The minimum salary allowed to be returned. This field is required.</param>.
        /// <param name="maxSalary">The maximum salary allowed to be returned. This field is required.</param>
        /// <returns>A <see cref="List{Employee}"/> of employees that are within the inclusive range of <paramref name="minSalary"/> and <paramref name="maxSalary"/></returns>
        public List<Employee> GetEmployeesBySalaryRange(decimal minSalary, decimal maxSalary)
        {
            var filteredEmployees = new List<Employee>();

            foreach (var employee in Employees)
            {
                if (employee.Salary > minSalary || employee.Salary < maxSalary)
                {
                    filteredEmployees.Add(employee);
                }
            }

            return filteredEmployees;
        }

        /// <summary>
        /// Get an <see cref="Employee"/> by the id.
        /// </summary>
        /// <param name="key">A <see cref="int"/> representing the id of he employee to get. This field is required.</param>
        /// <returns>A positive <see cref="Employee"/> matching the <paramref name="key"/>. A null result indicates the id was not found.</returns>
        public Employee GetById(int key)
        {
            if (key.ToString().StartsWith("-"))
                throw new ArgumentOutOfRangeException("key", "key must be a positive number");

            Employee employee = null;

            foreach (var item in Employees)
            {
                if (item.Id == key)
                {
                    employee = item;
                }
            }

            return employee;
        }

        /// <summary>
        /// Get a list of all possible employee departments from the <see cref="Employee"/> collection.
        /// </summary>
        /// <returns>A <see cref="List{string}"/> of departments.</returns>
        public List<string> GetEmployeeDepartments()
        {
            var department_list = new List<string>();

            foreach (var employee in Employees)
                department_list.Add(employee.Department);

            return department_list;
        }

        /// <summary>
        /// Create an <see cref="Employee"/> and add it to the <see cref="Employees"/> collection
        /// </summary>
        /// <param name="firstName">The first name of the new employee. This field is required.</param>
        /// <param name="lastName">The last name of the new employee. This field is required.</param>
        /// <param name="department">The name of the department of the new employee. This field is required.</param>
        /// <param name="jobTitle">The job title of the new employee. This field is required.</param>
        /// <param name="salary">The salary of the new employee. This field is required.</param>
        /// <returns></returns>
        public int CreateEmployee(string firstName, string lastName, string department, string jobTitle, decimal salary)
        {
            var employee = new Employee()
            {
                Id = Employees.Max(x => x.Id) + 1,
                FirstName = firstName,
                LastName = lastName,
                Department = department,
                Job_Title = jobTitle,
                Salary = salary
            };

            Employees.Add(employee);

            return employee.Id;
        }

        /// <summary>
        /// Update the <see cref="Employee"/> department
        /// </summary>
        /// <param name="id">The Id of the <see cref="Employee"/> to update. This field is required.</param>
        /// <param name="department">The name of the departments to update the <see cref="Employee"/> with.</param>
        public void UpdateEmployeeDepartment(int id, string department)
        {
            if (string.IsNullOrWhiteSpace(department))
            {
                throw new ArgumentOutOfRangeException("department", "department cannot be empty");
            }

            foreach (var employee in Employees)
            {
                if (employee.Id == id)
                {
                    employee.Department = department;
                }
            }
        }

        /// <summary>
        /// Remove an <see cref="Employee"/> based on their id
        /// </summary>
        /// <param name="id">The id of the <see cref="Employee"/> to remove. This field is required.</param>
        public void Delete(int id)
        {
            Employees = Employees.Where(e => e.Id != id).ToList();
        }
    }
}
