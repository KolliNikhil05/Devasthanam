using Microsoft.EntityFrameworkCore;
using Test.API.Data.Models;

namespace Test.API.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) 
        {
            

        }
        public DbSet<Student> Students { get; set; }
    }
}