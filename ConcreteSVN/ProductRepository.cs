using Interfaces;
using System;
using System.Linq;

namespace ConcreteSVN
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext Context;

        public ProductRepository(ApplicationDbContext context)
        {
            Context = context;
        }
        //public IQueryable<Product> Products => Context.Products.Select(x => new Product()
        //{
        //    Id = x.Id,
        //    Name = x.Name,
        //    Description = x.Description,
        //    Price = x.Price,
        //    Category = x.Category
        //});

        //public IQueryable<Product> Products => Context.Products.Select(x => new Product(x.Id, x.Name, x.Description, x.Price, x.Category));
        public IQueryable<Product> Products => Context.Products.Select(x => new Product(x.Id, x.Name)
        {
            Description = x.Price > 100 ? $"20% DISCOUNT TODAY: {x.Description}" : x.Description,
            Price = x.Price > 100 ? x.Price * (decimal)0.8 : x.Price,
            Category = x.Category
        });
    }
}
