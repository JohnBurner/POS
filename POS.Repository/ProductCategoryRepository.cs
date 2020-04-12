using POS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repository
{
    class ProductCategoryRepository
    {
        private POSEntities _db;

        public ProductCategoryRepository()
        {
            _db = new POSEntities();
        }
        public void AddProductCategory(ProductCategory productCategory)
        {
            _db.ProductCategories.Add(productCategory);
            _db.SaveChanges();
        }
        public ProductCategory GetProductCategory(int productCategoryId)
        {
            return _db.ProductCategories.FirstOrDefault(c => c.ProductCategoryId == productCategoryId);
        }
        public List<ProductCategory> GetProductCategorys()
        {
            return _db.ProductCategories.ToList();
        }
        public void RemoveProductCategory(int productCategoryId)
        {
            var productCategory = _db.ProductCategories.FirstOrDefault(c => c.ProductCategoryId == productCategoryId);
            if (productCategory != null)
            {
                _db.ProductCategories.Remove(productCategory);
                _db.SaveChanges();
            }

        }
        public ProductCategory UpdateProductCategory(ProductCategory productCategory)
        {

            return null;
        }
    }
}
