using Assigntment4WebApp.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace Assigntment5WebApp.Data
{
    public class Assignment5DbContext : DbContext
    {
        public Assignment5DbContext(DbContextOptions<Assignment5DbContext> options) : base(options) { }

        public DbSet<OrderEntity> Orders { get; set; }
    }
}