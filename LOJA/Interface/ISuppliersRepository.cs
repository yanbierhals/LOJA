using LOJA.Models;

namespace LOJA.Interface
{
    public interface ISuppliersRepository
    {
        List<Supplier> GetSuppliers();
        Supplier GetSupplier(int id);
        void AddSupplier(Supplier supplier);
        void UpdateSupplier(Supplier supplier);
        void DeleteSupplier(Supplier supplier);
    }
}