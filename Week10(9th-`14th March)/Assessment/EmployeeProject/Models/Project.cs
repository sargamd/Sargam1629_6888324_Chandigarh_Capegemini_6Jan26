namespace EmployeeProject.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }

        public ICollection<Employee_Project> EmployeeProjects { get; set; }
        
    }
}
