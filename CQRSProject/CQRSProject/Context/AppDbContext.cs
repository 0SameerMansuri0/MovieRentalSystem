using CQRSProject.Model;
using Microsoft.EntityFrameworkCore;

namespace CQRSProject.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> context):base(context)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
