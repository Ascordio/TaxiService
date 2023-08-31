using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiService.Core;

namespace TaxiService.Repos
{
    public class ClientOrder
    {
        private readonly TaxiServiceDbContext _ctx;
        public ClientOrder(TaxiServiceDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<string> GetOrderAsync()
        {
            return " ";
        }
    }
}
