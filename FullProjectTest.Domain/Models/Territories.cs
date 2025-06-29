using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullProjectTest.Domain.Models
{
    public class Territories
    {
        public int TerritoriesId { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
