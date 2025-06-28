using System.ComponentModel.DataAnnotations;

namespace FullProjectTest.Domain.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateOnly BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        [MaxLength(10)]
        public string PostalCode { get; set; }
        [MaxLength(15)]
        public string Country { get; set; }
        [MaxLength(24)]
        public string HomePhone { get; set; }
        [MaxLength(4)]
        public string Extension { get; set; }
        public byte[]? Photo { get; set; }
        public string? Notes { get; set; }
        public int ReportsTo { get; set; }
        public Employee? Manager { get; set; }
        public string PhotoPath { get; set; }
        public ICollection<Employee> Subordinates { get; set; } = new List<Employee>();
    }
}
