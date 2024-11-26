using FullStackTechTestDotNet.DataAccessLayer;
using FullStackTechTestDotNet.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace FullStackTechTestDotNet.BusinessLogic
{
    public class OrdersLogic
    {
        private readonly AppDbContext _appDbContext;
        public OrdersLogic(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AddOrder(Order order)
        {
            _appDbContext.Orders.Add(order);

            _appDbContext.SaveChanges();
        }

        public IEnumerable<Order> GetOrders()
        {
            var orders = _appDbContext.Orders
            .Include(x => x.Customer)
            .ToList();

            return orders;
        }

        public void UpdateOrder(int id, Order updatedOrder)
        {
            var order = _appDbContext.Orders.Find(id);

            order.Name = updatedOrder.Name;
            order.CustomerId = updatedOrder.CustomerId;

            _appDbContext.SaveChanges();
        }

        public void DeleteOrder(int id) 
        {
            var order = _appDbContext.Orders.Find(id);

            _appDbContext.Orders.Remove(order);

            _appDbContext.SaveChanges();
        }
    }
}
