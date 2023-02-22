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

        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<CarClass> CarClasses { get; set; }
        public DbSet<CarInfo> CarInfo { get; set; }
        public DbSet<CarColor> CarColors { get; set; }
        public DbSet<ClientResponse> ClientResponse { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Order> Order { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Seed();
            base.OnModelCreating(builder);
        }
    }
}