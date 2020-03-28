using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    public DbSet<Value> Values {get; set;}
    public DbSet<service_pending> service_Pendings {get; set;}
    }
}