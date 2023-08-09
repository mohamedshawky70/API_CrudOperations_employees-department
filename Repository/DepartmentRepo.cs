using API.Data;
using API.Models;
using System.Transactions;

namespace API.Repository
{
    public class DepartmentRepo
    {
        private readonly APIContext Context;

        public DepartmentRepo(APIContext Context)
        {
            this.Context = Context;
        }
        public List<Department> GetAll()
        {

            return Context.departments.ToList();
            
        }
        public Department GetById(int id)
        {
            return Context.departments.FirstOrDefault(d => d.ID == id);

        }
        public Department GetByName(string Name)
        {
            return Context.departments.FirstOrDefault(d => d.Name == Name);
        }
        public void Add(Department department)
        {
            
            Context.Add(department);
            Context.SaveChanges();
        }
        public void Update(Department NewDepartment)
        {
            int id = NewDepartment.ID;
            Department department = Context.departments.FirstOrDefault(d => d.ID == id);
            department.Name = NewDepartment.Name;
            department.Manger = NewDepartment.Manger;
            Context.SaveChanges();
        }
        public void Delete(int id)
        {
            Context.departments.Remove(Context.departments.FirstOrDefault(d => d.ID == id));
            Context.SaveChanges();
        }


    }
}
