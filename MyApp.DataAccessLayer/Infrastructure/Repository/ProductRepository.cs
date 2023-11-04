using MyApp.DataAccessLayer.Infrastructure.IRepository;
using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.DataAccessLayer.Infrastructure.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Product product)
        {
            var productDB = _context.Products.FirstOrDefault(x => x.Id == product.Id);
            if (productDB != null)
            {
                product.Name = productDB.Name;
                product.Description = productDB.Description;
                product.Category = productDB.Category;
                productDB.Price = productDB.Price;
                if (product.ImageUrl != null)
                {
                    product.ImageUrl = productDB.ImageUrl;
                }
            }
        }
    }
}