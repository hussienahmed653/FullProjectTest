namespace FullProjectTest.Domain.Models
{
    public class Categories
    {
        public int CategoriesId { get; set; }
        public string CategoriesName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
