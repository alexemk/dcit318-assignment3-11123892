// Name: Alex Kotoka
// Student ID: 11123892
// Project: Multi-question C# Console Application
// Date: August 2025

using System.Collections.Generic;
using System.Linq;

namespace AssignmentSolutions.Q3.Warehouse
{
    public class InventoryRepository<T> where T : IInventoryItem
    {
        private readonly Dictionary<int, T> _items = new();

        public void AddItem(T item)
        {
            if (_items.ContainsKey(item.Id))
                throw new DuplicateItemException($"Item with ID {item.Id} already exists.");
            _items[item.Id] = item;
        }

        public T GetItemById(int id)
        {
            if (!_items.TryGetValue(id, out var item))
                throw new ItemNotFoundException($"Item with ID {id} not found.");
            return item;
        }

        public void RemoveItem(int id)
        {
            if (!_items.Remove(id))
                throw new ItemNotFoundException($"Item with ID {id} not found.");
        }

        public System.Collections.Generic.List<T> GetAllItems() => _items.Values.ToList();

        public void UpdateQuantity(int id, int newQuantity)
        {
            if (newQuantity < 0) throw new InvalidQuantityException("Quantity cannot be negative.");
            var item = GetItemById(id);
            item.Quantity = newQuantity;
        }
    }
}
