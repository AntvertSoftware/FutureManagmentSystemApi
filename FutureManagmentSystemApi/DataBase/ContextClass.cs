using FutureManagmentSystemApi.Models.Bussiness;
using Microsoft.EntityFrameworkCore;

namespace FutureManagmentSystemApi.DataBase
{
    public class ContextClass : DbContext
    {
        public ContextClass(DbContextOptions<ContextClass> options) : base(options)
        {
        }
        public DbSet<Admission> Admission { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
