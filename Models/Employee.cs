namespace DepartmentAzureGitHub.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}
