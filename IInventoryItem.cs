// Name: Alex Kotoka
// Student ID: 11123892
// Project: Multi-question C# Console Application
// Date: August 2025

namespace AssignmentSolutions.Q3.Warehouse
{
    public interface IInventoryItem
    {
        int Id { get; }
        string Name { get; }
        int Quantity { get; set; }
    }
}
