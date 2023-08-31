using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaxiService.Core
{
    public class Mark
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? MarkName { get; set; }
        public virtual ICollection<ClientResponse>? ClientResponses { get; set; }
    }
}