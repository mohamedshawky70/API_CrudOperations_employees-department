using API.Data;
using API.DTO;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class EmployeeRepo
    {
        private readonly APIContext context;

        public EmployeeRepo(APIContext Context)
        {
            context = Context;
        }
    
        public AllEmpAllDeptDTO GetAll()
        {
            List<Employee> employees= context.employees.Include(e => e.Department).ToList();
            AllEmpAllDeptDTO d = new AllEmpAllDeptDTO();
            foreach (var item in employees)
            {
                d.EmpName.Add(item.Name);
                d.EmpPhone.Add(item.phone);
                d.Empdepartment.Add(item.Department.Name);
            }
            return d;
        }

        public EmpDeptDTO GetById(int id)
        {
            Employee employee= context.employees.Include(e => e.Department).FirstOrDefault(e => e.Id == id);
            EmpDeptDTO dto = new EmpDeptDTO();
            dto.EmpName = employee.Name;
            dto.Id = employee.Id;
            dto.EmpPhone = employee.phone;
            dto.EmpDepartment = employee.Department.Name;
            return dto;
        }
    }
}
