using System.ComponentModel.DataAnnotations;

namespace FullProjectTest.Domain.Models
{
    public class Region
    {
        public int RegionId { get; set; }
        [MaxLength(50)]
        public string RegionDescription { get; set; }
        public ICollection<Territories> Territories { get; set; }
    }
}
