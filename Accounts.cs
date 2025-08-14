// Name: Alex Kotoka
// Student ID: 11123892
// Project: Multi-question C# Console Application
// Date: August 2025

using System;

namespace AssignmentSolutions.Q1.Finance
{
    // Base Account class
    public class Account
    {
        public string AccountNumber { get; }
        public decimal Balance { get; protected set; }

        public Account(string accountNumber, decimal initialBalance)
        {
            if (string.IsNullOrWhiteSpace(accountNumber)) throw new ArgumentNullException(nameof(accountNumber));
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        // Default behavior: deduct amount
        public virtual void ApplyTransaction(Transaction transaction)
        {
            Balance -= transaction.Amount;
            Console.WriteLine($"[Account] New balance: {Balance:C}");
        }
    }

    // SavingsAccount is sealed to restrict inheritance
    public sealed class SavingsAccount : Account
    {
        public SavingsAccount(string accountNumber, decimal initialBalance) : base(accountNumber, initialBalance) { }

        public override void ApplyTransaction(Transaction transaction)
        {
            if (transaction.Amount > Balance)
            {
                Console.WriteLine("Insufficient funds");
            }
            else
            {
                Balance -= transaction.Amount;
                Console.WriteLine($"[SavingsAccount] Deducted {transaction.Amount:C}. Updated balance: {Balance:C}");
            }
        }
    }
}
