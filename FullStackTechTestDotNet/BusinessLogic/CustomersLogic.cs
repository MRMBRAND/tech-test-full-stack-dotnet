using FullStackTechTestDotNet.DataAccessLayer;
using FullStackTechTestDotNet.DataAccessLayer.Entities;

namespace FullStackTechTestDotNet.BusinessLogic
{
    public class CustomersLogic
    {
        private readonly AppDbContext _appDbContext;
        public CustomersLogic(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddCustomer(Customer customer)
        {
            _appDbContext.Customers.Add(customer);

            _appDbContext.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            var customer = _appDbContext.Customers.Find(id);

            _appDbContext.Customers.Remove(customer);

            _appDbContext.SaveChanges();
        }

        public IEnumerable<Customer> Get()
        {
            var customers = _appDbContext.Customers.ToList();

            return customers;
        }

        public void UpdateCustomer(int id, Customer updatedCustomer)
        {
            var customer = _appDbContext.Customers.Find(id);

            customer.Name = updatedCustomer.Name;
            customer.AddressLine1 = updatedCustomer.Name;
            customer.Town = updatedCustomer.Town;
            customer.Postcode = updatedCustomer.Postcode;

            _appDbContext.SaveChanges();
        }

        public IEnumerable<Customer> GetCustomerIdsWithOrders()
        {
            List<Customer> customerIdsWithOrders = new();

            var customers = _appDbContext.Customers.ToList();

            var orders = _appDbContext.Orders.ToList();

            foreach (var customer in customers)
            {
                foreach (var order in orders)
                {
                    if (order.CustomerId == customer.Id)
                    {
                        customerIdsWithOrders.Add(customer);
                    }
                }
            }

            return customerIdsWithOrders;
        }
    }
}
