using Microsoft.EntityFrameworkCore;
using myAPI.Models;

namespace myAPI.Infrastructure
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var sqlServerVersion = new MySqlServerVersion(new Version(8, 0, 35));

            string connectionString = "Server=localhost;Port=3306;Database=employee_sample;Uid=root;Pwd=14589632";

            optionsBuilder.UseMySql(connectionString, sqlServerVersion);
        }
    }
}
