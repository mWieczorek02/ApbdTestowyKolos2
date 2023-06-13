using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestowyKolos2.Models
{
    [PrimaryKey(nameof(OrderID), nameof(PastryID))]
    public class OrderPastry
    {
        public int OrderID { get; set; }
        public int PastryID { get; set; }
        [Required] public int Amount { get; set; }
        [MaxLength(300)] public string Comments { get; set; } = null!;
        
        [ForeignKey(nameof(OrderID))]
        public virtual Order Order { get; set; }
        
        [ForeignKey(nameof(PastryID))]
        public virtual Pastry Pastry { get; set; }
    }
}
