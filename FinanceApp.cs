// Name: Alex Kotoka
// Student ID: 11123892
// Project: Multi-question C# Console Application
// Date: August 2025

using System;
using System.Collections.Generic;

namespace AssignmentSolutions.Q1.Finance
{
    // Coordinates transactions, processors, and account behavior
    public class FinanceApp
    {
        private readonly List<Transaction> _transactions = new();

        public void Run()
        {
            Console.WriteLine("=== QUESTION 1: Finance Management System ===");

            var acct = new SavingsAccount("SA-001", 1000m);

            var t1 = new Transaction(1, DateTime.Now.Date, 120m, "Groceries");
            var t2 = new Transaction(2, DateTime.Now.Date, 300m, "Utilities");
            var t3 = new Transaction(3, DateTime.Now.Date, 700m, "Entertainment");

            ITransactionProcessor p1 = new MobileMoneyProcessor();
            ITransactionProcessor p2 = new BankTransferProcessor();
            ITransactionProcessor p3 = new CryptoWalletProcessor();

            p1.Process(t1);
            acct.ApplyTransaction(t1);

            p2.Process(t2);
            acct.ApplyTransaction(t2);

            p3.Process(t3);
            acct.ApplyTransaction(t3);

            _transactions.AddRange(new[] { t1, t2, t3 });
            Console.WriteLine();
        }
    }
}
