using CoffeSystem_DataAccess.DBContext;
using Microsoft.EntityFrameworkCore;
using CoffeSystem_DataAccess.Entities;

namespace CoffeSystem_DataAccess.Repositories
{
  
        public class DahboardRepositry
        {
            private readonly AppDbContext _context;

            public DahboardRepositry(AppDbContext context)
            {
                _context = context;
            }

            // Methode N°1 : GetRevenue today
            public decimal GetTodayRevenue()
            {
                DateTime today = DateTime.Today;
                DateTime tomorrow = today.AddDays(1);

                return _context.Orders.Where(o => o.OrderDate >= today && o.OrderDate < tomorrow).Sum(o => o.TotalAmount);
            }

            // Methode N°2: GetOdersToday
            public int GetOrdersToday()
            {

                DateTime today = DateTime.Today;
                DateTime tomorrow = today.AddDays(1);
               return  _context.Orders.Count(o => o.OrderDate >= today && o.OrderDate < tomorrow);


            }

            // Methode N°3: TotalProducts
            public int GetTotalProducts()
            {
                return _context.Products.Count();
            }

        // Methode N°4 : Get Low Stock Product
        public async Task<int> GetLowStockAsync(int threshold)
        {
            return await _context.Products
                .CountAsync(p =>
                    p.IsActive &&
                    p.StockQuantity <= threshold);
        }


        // Methode N°5 : GetRecentOrders
        public List<Order>GetRecentOrders(int count =5)
            {
                return _context.Orders.OrderByDescending(o => o.OrderDate).Take(count).ToList();
            }
        }
    }
