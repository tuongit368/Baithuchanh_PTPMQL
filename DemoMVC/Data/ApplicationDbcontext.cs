using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Sqlite;
using DemoMVC.Models;
// using NewApp.Models;

namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

        public DbSet<Person> Person { get; set;}

        public DbSet<DemoMVC.Models.Student> Student { get; set; } = default!;
    }
}