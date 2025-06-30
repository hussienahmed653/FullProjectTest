namespace FullProjectTest.Domain.Models
{
    public class OrderDetailes
    {
        public int OrderId { get; set; }
        public Orders Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public decimal UnitPrice { get; set; }
        public byte Quantity { get; set; }
        public float Discount { get; set; }
    }
}
