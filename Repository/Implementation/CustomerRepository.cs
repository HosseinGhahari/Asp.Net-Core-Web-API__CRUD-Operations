using Microsoft.EntityFrameworkCore;
using Web_Api___Repository_Pattern.Context;
using Web_Api___Repository_Pattern.Model;
using Web_Api___Repository_Pattern.Repository.Interface;

namespace Web_Api___Repository_Pattern.Repository.Implementation
{
    public class CustomerRepository : ICustomer
    {
        private readonly CustomerDbContext _context;
        public CustomerRepository(CustomerDbContext db)
        {
            _context = db;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }
        public Customer GetById(int id)
        {
            return _context.Customers.Where(a => a.CustomerId == id).FirstOrDefault() ?? null;
        }

        public void InsertCustomer(Customer Entity)
        {
           _context.Add(Entity);  
        }

        public void UpdateCustomer(Customer Entity)
        {
            _context.Entry(Entity).State = EntityState.Modified;
        }

        public void DeleteCustomer(int customerid)
        {
            var customer = _context.Customers.Find(customerid);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
            }
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
