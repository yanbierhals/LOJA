using System.Collections.Generic;
using System.Linq;
using LOJA.Data;
using LOJA.Models;
using LOJA.Interface;

namespace LOJA.Repositories
{
    public class SuppliersRepository : ISuppliersRepository
    {
        private readonly AppDbContext _dbContext;

        public SuppliersRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Supplier> GetSuppliers()
        {
            return _dbContext.Suppliers.ToList();
        }

        public Supplier GetSupplier(int id)
        {
            return _dbContext.Suppliers.Find(id);
        }

        public void AddSupplier(Supplier supplier)
        {
            _dbContext.Suppliers.Add(supplier);
            _dbContext.SaveChanges();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            _dbContext.Suppliers.Update(supplier);
            _dbContext.SaveChanges();
        }

        public void DeleteSupplier(Supplier supplier)
        {
            _dbContext.Suppliers.Remove(supplier);
            _dbContext.SaveChanges();
        }
    }
}
