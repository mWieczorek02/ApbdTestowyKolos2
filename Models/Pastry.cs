using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TestowyKolos2.Models
{
    public class Pastry
    {
        [Key] public int ID { get; set; }
        [Required, MaxLength(150)] public string Name { get; set; } = null!;
        [Required, Precision(10, 2)] public decimal Price { get; set; }
        [Required, MaxLength(40)] public string Type { get; set; } = null!;
        public virtual ICollection<OrderPastry> OrdersPastries { get; set; } = null!;

    }
}
