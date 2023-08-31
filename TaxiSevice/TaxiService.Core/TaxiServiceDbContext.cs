using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TaxiService.Core
{
    public class TaxiServiceDbContext : IdentityDbContext<User>
    {
        public TaxiServiceDbContext(DbContextOptions<TaxiServiceDbContext> options)
            : base(options)
        {
        }

        public DbSet<CarClass> CarClass { get; set; }
        public DbSet<CarColor> CarColor { get; set; }
        public DbSet<CarInfo> CarInfo { get; set; }
        public DbSet<ClientResponse> ClientResponse { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Seed();
            base.OnModelCreating(builder);
        }
    }
}