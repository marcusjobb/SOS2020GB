namespace OOPInterfaces
{
    /// <summary>
    /// Defines the <see cref="SavingAccount" />.
    /// </summary>
    internal class SavingAccount : Interfaces.IAccount
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
        /// Initializes a new instance of the <see cref="SavingAccount"/> class.
        /// </summary>
        public SavingAccount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SavingAccount"/> class.
        /// </summary>
        /// <param name="initialBalance">The initialBalance<see cref="double"/>.</param>
        public SavingAccount(double initialBalance)
        {
            if (initialBalance <= 0) throw new System.Exception("amount too small");
            Balance = initialBalance;
        }

        /// <summary>
        /// The AccountInfo.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        public string AccountInfo()
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
    }
}
