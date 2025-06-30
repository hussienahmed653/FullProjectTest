using System.ComponentModel.DataAnnotations;

namespace FullProjectTest.Domain.Models
{
    public class Shippers
    {
        public int ShipperId { get; set; }
        [MaxLength(40)]
        public string CompanyName { get; set; }
        [MaxLength(24)]
        public string? Phone { get; set; }
        public ICollection<Orders> Orders { get; set; } = new List<Orders>();
    }
}
