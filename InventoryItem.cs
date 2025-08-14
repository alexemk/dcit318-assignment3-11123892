// Name: Alex Kotoka
// Student ID: 11123892
// Project: Multi-question C# Console Application
// Date: August 2025

using System;

namespace AssignmentSolutions.Q5.InventoryLogger
{
    public record InventoryItem(int Id, string Name, int Quantity, DateTime DateAdded) : IInventoryEntity;
}
