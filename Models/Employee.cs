using System.Text.Json.Serialization;

namespace API.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string phone { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
