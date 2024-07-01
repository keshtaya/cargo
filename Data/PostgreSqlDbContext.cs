using ECommerceApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CargoCarApi.Data
{
    public class PostgreSqlDbContext : DbContext

    {
        public PostgreSqlDbContext(
            DbContextOptions<PostgreSqlDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

    }
}
