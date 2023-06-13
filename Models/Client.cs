using System.ComponentModel.DataAnnotations;

namespace TestowyKolos2.Models
{
    public class Client
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)] public string FirtName { get; set; } = null!;
        [Required, MaxLength(100)] public string LastName { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; } = null!;
    }
}
