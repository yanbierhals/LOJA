using System.ComponentModel.DataAnnotations;

namespace LOJA.Models
{
    public class Product
    {
        [Key]
        public int? ProductId { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Cost { get; set; }
        public double Count { get; set; }
        public int SupplierId { get; set; }
    }
}