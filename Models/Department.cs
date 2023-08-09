using System.Text.Json.Serialization;

namespace API.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Manger { get; set; }
        [JsonIgnore]
        public virtual List<Employee> employees { get; set; }
    }
}
