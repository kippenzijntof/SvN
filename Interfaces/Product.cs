using System;

namespace Interfaces
{
    public class Product
    {
        //public Guid Id { get; set; }
        //public string Name { get; set; }
        //public string Description { get; set; }
        //public decimal Price { get; set; }
        //public string Category { get; set; }

        //public Guid Id { get; }
        //public string Name { get; }
        //public string Description { get; }
        //public decimal Price { get; }
        //public string Category { get; }

        //public Product(Guid id, string name, string description, decimal price, string category)
        //{
        //    Id = id;
        //    Name = name;
        //    Description = description;
        //    Price = price;
        //    Category = category;
        //}

        public Guid Id { get; }
        public string Name { get; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public Product(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        private Product()
        { }
    }
}
