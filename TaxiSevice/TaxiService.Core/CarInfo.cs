using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService.Core
{
    public class CarInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? CarNumber { get; set; }
        public CarClass? CarClass { get; set; }
        public CarColor? CarColor { get; set; }
        public User? Driver { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
    }
}
