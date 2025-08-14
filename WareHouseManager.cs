// Name: Alex Kotoka
// Student ID: 11123892
// Project: Multi-question C# Console Application
// Date: August 2025

using System;

namespace AssignmentSolutions.Q3.Warehouse
{
    public class WareHouseManager
    {
        private readonly InventoryRepository<ElectronicItem> _electronics = new();
        private readonly InventoryRepository<GroceryItem> _groceries = new();

        public void SeedData()
        {
            _electronics.AddItem(new ElectronicItem(1, "Laptop", 5, "Acer", 24));
            _electronics.AddItem(new ElectronicItem(2, "Smartphone", 10, "Samsung", 12));
            _electronics.AddItem(new ElectronicItem(3, "Headphones", 15, "Sony", 6));

            _groceries.AddItem(new GroceryItem(1, "Rice 5kg", 20, DateTime.Today.AddMonths(12)));
            _groceries.AddItem(new GroceryItem(2, "Milk 1L", 50, DateTime.Today.AddDays(10)));
            _groceries.AddItem(new GroceryItem(3, "Eggs (tray)", 30, DateTime.Today.AddDays(14)));
        }

        public void PrintAllItems<T>(InventoryRepository<T> repo) where T : IInventoryItem
        {
            foreach (var i in repo.GetAllItems()) Console.WriteLine(" - " + i);
        }

        public void IncreaseStock<T>(InventoryRepository<T> repo, int id, int quantity) where T : IInventoryItem
        {
            try
            {
                var item = repo.GetItemById(id);
                repo.UpdateQuantity(id, item.Quantity + quantity);
                Console.WriteLine($"Stock increased: {item.Name} now {item.Quantity}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error increasing stock: {ex.Message}");
            }
        }

        public void RemoveItemById<T>(InventoryRepository<T> repo, int id) where T : IInventoryItem
        {
            try { repo.RemoveItem(id); Console.WriteLine($"Removed item #{id}"); }
            catch (Exception ex) { Console.WriteLine($"Error removing item: {ex.Message}"); }
        }

        public void Run()
        {
            Console.WriteLine("=== QUESTION 3: Warehouse Inventory ===");
            SeedData();

            Console.WriteLine("Grocery Items:");
            PrintAllItems(_groceries);
            Console.WriteLine("Electronic Items:");
            PrintAllItems(_electronics);

            // Demonstrate exceptions per requirements
            try { _electronics.AddItem(new ElectronicItem(1, "Duplicate Laptop", 1, "Brand", 12)); }
            catch (Exception ex) { Console.WriteLine($"Expected duplicate add error: {ex.Message}"); }

            RemoveItemById(_groceries, 999); // non-existent

            // Trigger invalid quantity
            try { _electronics.UpdateQuantity(2, -5); }
            catch (Exception ex) { Console.WriteLine($"Expected invalid qty error: {ex.Message}"); }

            Console.WriteLine();
        }
    }
}
