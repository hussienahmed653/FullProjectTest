﻿namespace FullProjectTest.Domain.Models
{
    public class Customers
    {
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public ICollection<CustomerDemographics> customerDemographics { get; set; } = new List<CustomerDemographics>();
        public ICollection<Orders> Orders { get; set; } = new List<Orders>();
    }
}
