using CoffeSystem_DataAccess.Entities;
using CoffeSystem_DataAccess.Repositories;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeSystem_Business
{
    public class DashboardService
    {
        private readonly DahboardRepositry _repository;
        private readonly CafeSettingsRepository _settingsRepository;

        public DashboardService(DahboardRepositry repository, CafeSettingsRepository settingsRepository)
        {
            _repository = repository;
            _settingsRepository = settingsRepository;
        }
        // Methode N°1 : Get Today Revenue
        public decimal GetTodayRevenue()
        {
            return _repository.GetTodayRevenue();
        }

        // Methode N°2 : Get Orders Today
        public int GetTodayOrders()
        {
            return _repository.GetOrdersToday() ;
        }

        // Methode N°4 :Get Total Products
        public int GetTotalProducts()
        {
            return _repository.GetTotalProducts();
        }

        // Methode N°5: Get Low Stock
        public async Task<int> GetLowStockAsync()
        {
            var settings = await _settingsRepository
                .GetSettingsAsync();

            if (settings == null)
            {
                throw new InvalidOperationException(
                    "Cafe settings were not found.");
            }

            return await _repository.GetLowStockAsync(
                settings.LowStockThreshold);
        }

        // Methode N°6:Get Recent Orders
        public List<Order>GetRecentOrders(int count=5)
        {
            return _repository.GetRecentOrders(count);

        }

    }
}
