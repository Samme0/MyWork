using Assigntment4WebApp.Models.Data;
using System.Collections.Generic;
using System.Linq;

namespace Assigntment5WebApp.Data
{
    public class OrderEntityFunctions
    {
        private readonly Assignment5DbContext _context;

        public OrderEntityFunctions(Assignment5DbContext context)
        {
            _context = context;
        }

        public void AddOrder(OrderEntity order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public List<OrderEntity> GetOrders()
        {
            return _context.Orders.ToList();
        }

        public List<OrderEntity> SearchOrders(string beverage, string appetizer, string sandwich, string dessert)
        {
            var query = _context.Orders.AsQueryable();

            if (!string.IsNullOrEmpty(beverage))
                query = query.Where(o => o.BeverageItem == beverage);
            if (!string.IsNullOrEmpty(appetizer))
                query = query.Where(o => o.AppetizerItem == appetizer);
            if (!string.IsNullOrEmpty(sandwich))
                query = query.Where(o => o.SandwichItem == sandwich);
            if (!string.IsNullOrEmpty(dessert))
                query = query.Where(o => o.DessertItem == dessert);

            return query.ToList();
        }
    }
}