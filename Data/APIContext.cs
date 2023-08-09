using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class APIContext:DbContext
    {
        public APIContext(DbContextOptions<APIContext>options):base(options)
        {
        }
        public DbSet<Department> departments { get; set; }
        public DbSet<Employee> employees { get; set; }
    }
}
