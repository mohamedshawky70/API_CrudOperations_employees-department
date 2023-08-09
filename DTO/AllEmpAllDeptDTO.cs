using API.Models;

namespace API.DTO
{
    public class AllEmpAllDeptDTO
    {
        public List<string> EmpName { get; set; } = new List<string>();
        public List<string> EmpPhone { get; set; } = new List<string>();
        public List<string> Empdepartment { get; set; } = new List<string>();   

    }
}
