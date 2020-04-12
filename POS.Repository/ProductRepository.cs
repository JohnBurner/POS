using POS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repository
{
    class ProductRepository
    {
        private POSEntities _db;

        public ProductRepository()
        {
            _db = new POSEntities();
        }
        public void AddProduct(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
        }
        public Product GetProduct(int productId)
        {
            return _db.Products.FirstOrDefault(c => c.ProductId == productId);
        }
        public List<Product> GetProducts()
        {
            return _db.Products.ToList();
        }
        public void RemoveProduct(int productId)
        {
            var product = _db.Products.FirstOrDefault(c => c.ProductId == productId);
            if (product != null)
            {
                _db.Products.Remove(product);
                _db.SaveChanges();
            }

        }
        public Product UpdateProduct(Product product)
        {

            return null;
        }
    }
}
