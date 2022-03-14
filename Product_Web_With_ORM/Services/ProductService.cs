using Product_Web_With_ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_Web_With_ORM.Services
{
    public class ProductService
    {
        private ProductDbContext dbContext;

        public ProductService(ProductDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Product> GetAll()
        {
            return dbContext.Products.ToList();
        }

        public Product GetById(int id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public void Create(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }

        public void Edit(Product product)
        {
            Product dbProduct = GetById(product.Id);

            dbProduct.Name = product.Name;
            dbProduct.Price = product.Price;
            dbProduct.Stock = product.Stock;
            dbProduct.IsSold = product.IsSold;

            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Product dbProduct = GetById(id);

            dbContext.Products.Remove(dbProduct);
            dbContext.SaveChanges();
        }
    }
}
