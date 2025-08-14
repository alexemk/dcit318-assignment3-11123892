// Name: Alex Kotoka
// Student ID: 11123892
// Project: Multi-question C# Console Application
// Date: August 2025

using System;

namespace AssignmentSolutions.Q5.InventoryLogger
{
    public class InventoryApp
    {
        private InventoryLogger<InventoryItem> _logger;
        private readonly string _path;

        public InventoryApp()
        {
            _path = System.IO.Path.Combine(Environment.CurrentDirectory, "inventory_log.json");
            _logger = new InventoryLogger<InventoryItem>(_path);
        }

        public void SeedSampleData()
        {
            _logger.Add(new InventoryItem(1, "HDMI Cable", 25, DateTime.Now));
            _logger.Add(new InventoryItem(2, "USB-C Hub", 10, DateTime.Now));
            _logger.Add(new InventoryItem(3, "Surge Protector", 15, DateTime.Now));
            _logger.Add(new InventoryItem(4, "Ethernet Cable 10m", 40, DateTime.Now));
        }

        public void SaveData() => _logger.SaveToFile();
        public void LoadData() => _logger.LoadFromFile();

        public void PrintAllItems()
        {
            foreach (var i in _logger.GetAll())
                Console.WriteLine($"Item #{i.Id}: {i.Name} | Qty={i.Quantity} | Added={i.DateAdded}");
        }

        public void Run()
        {
            Console.WriteLine("=== QUESTION 5: Inventory Logger (records + generics + file IO) ===");
            SeedSampleData();
            SaveData();

            // simulate a new session by re-initializing the logger, then loading from disk
            _logger = new InventoryLogger<InventoryItem>(_path);
            LoadData();
            PrintAllItems();
            Console.WriteLine();
        }
    }
}
