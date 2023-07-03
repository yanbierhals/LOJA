namespace LOJA.Models
{
    public class Supplier
    {
        public int? SupplierId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CNPJ { get; set; }
        public int BrandId { get; set; }
    }
}