namespace ShinySuccotash.Models
{
    using System.Collections.Generic;

    public class Customer : Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
    }

    public class Person
    {
        public DateTime RegistrationDate { get; set; }
    }
}
