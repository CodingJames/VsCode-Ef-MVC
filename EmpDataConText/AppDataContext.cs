using EF03.Models;
using Microsoft.EntityFrameworkCore;

namespace EF03.EmpDataConText
{
    public class AppDataContext:DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options):base(options){

        }
        // DbSet<Model_Name> Table_Name_On_DB {get;set;}
        public DbSet<Employee> Employees { get; set; }
    }
}