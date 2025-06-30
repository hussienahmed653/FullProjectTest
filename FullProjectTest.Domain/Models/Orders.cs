using System.ComponentModel.DataAnnotations;

namespace FullProjectTest.Domain.Models
{
    public class Orders
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public Customers Customer { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public Shippers Shipper { get; set; }
        public decimal? Freight { get; set; }
        [MaxLength(40)]
        public string? ShipName { get; set; }
        [MaxLength(60)]
        public string? ShipAddress { get; set; }
        [MaxLength(15)]
        public string? ShipCity { get; set; }
        [MaxLength(15)]
        public string? ShipRegion { get; set; }
        [MaxLength(10)]
        public string? ShipPostalCode { get; set; }
        [MaxLength(15)]
        public string? ShipCountry { get; set; }
        public ICollection<OrderDetailes> OrderDetails { get; set; } = new List<OrderDetailes>();
    }
}
