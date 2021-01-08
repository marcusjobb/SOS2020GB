﻿namespace Bankkonton
{
    /// <summary>
    /// Defines the <see cref="InvestmentAccount" />.
    /// </summary>
    internal class InvestmentAccount : Interfaces.IAccount
    {
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the Balance.
        /// </summary>
        public double Balance { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvestmentAccount"/> class.
        /// </summary>
        public InvestmentAccount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvestmentAccount"/> class.
        /// </summary>
        /// <param name="initialBalance">The initialBalance<see cref="double"/>.</param>
        public InvestmentAccount(double initialBalance)
        {
            if (initialBalance <= 0) throw new System.Exception("amount too small");
            Balance = initialBalance;
        }

        /// <summary>
        /// The AccountCreate.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        public string AccountCreate()
        {
            return $"Account name:{Name}, Balance {Balance}:-";
        }

        /// <summary>
        /// The Deposit.
        /// </summary>
        /// <param name="amount">The amount<see cref="double"/>.</param>
        /// <returns>The <see cref="double"/>.</returns>
        public double Deposit(double amount)
        {
            if (amount <= 0) throw new System.Exception("amount too small");
            Balance += amount;
            return Balance;
        }

        /// <summary>
        /// The Withdraw.
        /// </summary>
        /// <param name="amount">The amount<see cref="double"/>.</param>
        /// <returns>The <see cref="double"/>.</returns>
        public double Withdraw(double amount)
        {
            if (amount <= 0) throw new System.Exception("amount too small");
            if (amount > Balance) throw new System.Exception("no credit for you!");

            Balance -= amount;
            return Balance;
        }

        public override string ToString()
        {
            return AccountCreate();
        }

    }
}
