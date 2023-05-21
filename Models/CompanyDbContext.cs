using Microsoft.EntityFrameworkCore;

namespace GoldLiveCoreApp.Models
{
    public class CompanyContext
        : DbContext
    {
        public CompanyContext(DbContextOptions options)
            : base(options)
        {

        }

        //public DbSet<Employee> Employees { get; set; }
    }
}
