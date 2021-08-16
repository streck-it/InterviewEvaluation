namespace InterviewEvaluation
{
    /// <summary>
    /// An object representing an individual employee
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// The unique identifier of the Employee. This field is required.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The first name of the employee. This field is required.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The last name of the employee. This field is required.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The department name of the employee. This field is required.
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// The job title of the employee. This field is required.
        /// </summary>
        public string Job_Title { get; set; }
        /// <summary>
        /// The employee's salary. This field is required.
        /// </summary>
        public decimal Salary { get; set; }

        public Employee() { }
    }
}
