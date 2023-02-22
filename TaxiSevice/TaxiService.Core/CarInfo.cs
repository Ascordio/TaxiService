using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService.Core
{
    public class CarInfo
    {
        [Key]
        public int Id { get; set; }
        public string? Number { get; set; }
        public virtual ICollection<CarColor>? ColorId { get; set; }
        public virtual ICollection<BodyType>? BodyTypeId { get; set; }
        public ICollection<CarClass>? CarClassId { get; set; }
        public ICollection<ClientResponse>? ClientResponseId { get; set; }
        public User? Driver { get; set; }
    }
}
