using Web_Api___Repository_Pattern.Model;

namespace Web_Api___Repository_Pattern.Repository.Interface
{
    public interface ICustomer : IDisposable
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(int id);
        void InsertCustomer(Customer Entity);
        void UpdateCustomer(Customer Entity);
        void DeleteCustomer(int customerid);
        void Save();
    }
}
