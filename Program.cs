// Name: Alex Kotoka
// Student ID: 11123892
// Project: Multi-question C# Console Application
// Date: August 2025

using System;
using AssignmentSolutions.Q1.Finance;
using AssignmentSolutions.Q2.Health;
using AssignmentSolutions.Q3.Warehouse;
using AssignmentSolutions.Q4.Grading;
using AssignmentSolutions.Q5.InventoryLogger;

namespace AssignmentSolutions
{
    public class Program
    {
        public static void Main()
        {
            var q1 = new FinanceApp(); q1.Run();
            var q2 = new HealthSystemApp(); q2.Run();
            var q3 = new WareHouseManager(); q3.Run();
            var q4 = new StudentResultProcessor(); q4.Run();
            var q5 = new InventoryApp(); q5.Run();

            Console.WriteLine("=== All demos completed ===");
        }
    }
}
