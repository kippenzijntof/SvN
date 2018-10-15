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
        public IQueryable<Product> Products => Context.Products.Select(x => new Product
        {
            Id = x.Id,
            Name = x.Name,
            Description = x.Description,
            Price = x.Price,
            Category = x.Category
        });
    }
}
