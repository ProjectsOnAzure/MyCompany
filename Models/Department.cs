namespace DepartmentAzureGitHub.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepName { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
