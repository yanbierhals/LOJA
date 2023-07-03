namespace LOJA.Models
{
    public class Order
    {
        public int? OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalDue { get; set; }
        public string? OrderStatus { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? PaidDate { get; set; }
    }
}