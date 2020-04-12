using POS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repository
{
    class SaleTransactionRepository
    {
        private POSEntities _db;

        public SaleTransactionRepository()
        {
            _db = new POSEntities();
        }
        public void AddSaleTransaction(SaleTransaction saleTransaction)
        {
            _db.SaleTransactions.Add(saleTransaction);
            _db.SaveChanges();
        }
        public SaleTransaction GetSaleTransaction(int saleTransactionId)
        {
            return _db.SaleTransactions.FirstOrDefault(c => c.SaleTransactionId == saleTransactionId);
        }
        public List<SaleTransaction> GetSaleTransactions()
        {
            return _db.SaleTransactions.ToList();
        }
        public void RemoveSaleTransaction(int saleTransactionId)
        {
            var saleTransaction = _db.SaleTransactions.FirstOrDefault(c => c.SaleTransactionId == saleTransactionId);
            if (saleTransaction != null)
            {
                _db.SaleTransactions.Remove(saleTransaction);
                _db.SaveChanges();
            }

        }
        public SaleTransaction UpdateSaleTransaction(SaleTransaction saleTransaction)
        {

            return null;
        }
    }
}
