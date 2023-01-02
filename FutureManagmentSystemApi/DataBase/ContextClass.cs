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
    }
}
