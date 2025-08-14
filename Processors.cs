// Name: Alex Kotoka
// Student ID: 11123892
// Project: Multi-question C# Console Application
// Date: August 2025

using System;

namespace AssignmentSolutions.Q1.Finance
{
    public class BankTransferProcessor : ITransactionProcessor
    {
        public void Process(Transaction t)
        {
            Console.WriteLine($"[BankTransfer] Processing {t.Amount:C} for {t.Category} on {t.Date:d}.");
        }
    }

    public class MobileMoneyProcessor : ITransactionProcessor
    {
        public void Process(Transaction t)
        {
            Console.WriteLine($"[MobileMoney] Processing {t.Amount:C} for {t.Category} on {t.Date:d}.");
        }
    }

    public class CryptoWalletProcessor : ITransactionProcessor
    {
        public void Process(Transaction t)
        {
            Console.WriteLine($"[CryptoWallet] Sending {t.Amount} tokens equivalent for {t.Category} on {t.Date:d}.");
        }
    }
}
