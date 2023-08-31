using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TaxiService.Core;

namespace TaxiService.Repos
{
    public class RegisterAuto
    {
        private readonly TaxiServiceDbContext _ctx;
        public RegisterAuto(TaxiServiceDbContext ctx)
        {
            _ctx = ctx;
        }

        /*public async Task<CarInfo> AutoRegisterAsync(string carNumber, int carClass, int carColor, int driver)
        {
            var newCarInfo = new CarInfo
            {
                CarNumber = carNumber,
                CarClass = carClass,
                CarColor = carColor,
                Driver = driver
            };

            return await newCarInfo;
        }*/
    }
}
