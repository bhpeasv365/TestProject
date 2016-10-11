using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBankProject
{
    public class BankAccount
    {
        public const double DEFAULT_INTEREST_RATE = 0.01;

        public int AccountNumber { get; private set; }
        public double Balance { get; private set; }
        public double InterestRate { get; set; }

        public BankAccount(int accNumber, double initialBalance, double initialInterestRate)
        {
            AccountNumber = accNumber;
            Balance = initialBalance;
            InterestRate = initialInterestRate;
        }

        public BankAccount(int accNumber, double initialBalance) : this(accNumber, initialBalance, DEFAULT_INTEREST_RATE) { }

        public BankAccount(int accNumber) : this(accNumber, 0.0) { }

        public void deposit(double amount)
        {
            if (amount < 0)
                throw new ArgumentException("Unable to deposit a negative amount");
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
                throw new ArgumentException("Unable to withdraw a negative amount");
            if (amount > Balance)
                throw new ArgumentException("Unable to withdraw an amount exceeding the balance");
            Balance -= amount;
        }
    }
}
