using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestowyKolos2.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime AcceptedAt { get; set; }

        public DateTime? FulfilledAt { get; set; }
        [Required]
        public int ClientID { get; set; }
        [Required]
        public int EmployeeID { get; set; }

        

        [MaxLength(300)]
        public string? Comments { get; set; }

        [ForeignKey(nameof(ClientID))]
        public virtual Client Client { get; set; } = null!;

        [ForeignKey(nameof(EmployeeID))]

        public virtual Employee Employee { get; set; } = null!;

        public virtual ICollection<OrderPastry> OrdersPastries { get; set; } = null!;

    }
}
