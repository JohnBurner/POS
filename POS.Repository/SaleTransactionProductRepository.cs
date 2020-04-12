using POS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repository
{
    class SaleTransactionProductRepository
    {
        private POSEntities _db;

        public SaleTransactionProductRepository()
        {
            _db = new POSEntities();
        }
        public void AddSaleTransactionProduct(SaleTransactionProduct saleTransactionProduct)
        {
            _db.SaleTransactionProducts.Add(saleTransactionProduct);
            _db.SaveChanges();
        }
        public SaleTransactionProduct GetSaleTransactionProduct(int saleTransactionProductId)
        {
            return _db.SaleTransactionProducts.FirstOrDefault(c => c.SaleTransactionProductId == saleTransactionProductId);
        }
        public List<SaleTransactionProduct> GetSaleTransactionProducts()
        {
            return _db.SaleTransactionProducts.ToList();
        }
        public void RemoveSaleTransactionProduct(int saleTransactionProductId)
        {
            var saleTransactionProduct = _db.SaleTransactionProducts.FirstOrDefault(c => c.SaleTransactionProductId == saleTransactionProductId);
            if (saleTransactionProduct != null)
            {
                _db.SaleTransactionProducts.Remove(saleTransactionProduct);
                _db.SaveChanges();
            }

        }
        public SaleTransactionProduct UpdateSaleTransactionProduct(SaleTransactionProduct saleTransactionProduct)
        {

            return null;
        }
    }
}
