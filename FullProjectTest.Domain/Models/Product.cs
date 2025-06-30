using System.ComponentModel.DataAnnotations;

namespace FullProjectTest.Domain.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; } = string.Empty;
        public int SupplierID { get; set; }
        public Suppliers Supplier { get; set; }
        public int CategoryID { get; set; }
        public Categories Category { get; set; }
        [MaxLength(20)]
        public string? QuantityPerUnit { get; set; } = string.Empty;
        public decimal? UnitPrice { get; set; }
        public byte? UnitsInStock { get; set; }
        public byte? UnitsOnOrder { get; set; }
        public byte? ReorderLevel { get; set; }
        public double Discontinued { get; set; }
        public ICollection<OrderDetailes> OrderDetailes { get; set; } = new List<OrderDetailes>();
    }
}
