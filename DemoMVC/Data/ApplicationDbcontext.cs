using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;
using NewApp.Models;

namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

        public DbSet<Person> Person { get; set;}

        public DbSet<NewApp.Models.Student> Student { get; set; } = default!;
    }
}