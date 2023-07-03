namespace LOJA.Models
{
    public class OrderProduct
    {
        public int? OrderProductId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public double Quantity { get; set; }
    }
}