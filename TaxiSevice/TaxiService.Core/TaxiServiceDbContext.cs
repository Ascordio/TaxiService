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
    }
}