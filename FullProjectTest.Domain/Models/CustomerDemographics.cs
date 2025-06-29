namespace FullProjectTest.Domain.Models
{
    public class CustomerDemographics
    {
        public string CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }
        public ICollection<Customers> Customers { get; set; } = new List<Customers>();
    }
}
