namespace Bankkonton
{
    /// <summary>
    /// Defines the <see cref="Friend" />.
    /// </summary>
    internal class Friend : Interfaces.IAccount
    {
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the Balance.
        /// </summary>
        public double Balance { get;  set; }

        /// <summary>
        /// Gets or sets the MaxCredit.
        /// </summary>
        public double MaxCredit { get; set; } = 10000;

        /// <summary>
        /// Initializes a new instance of the <see cref="Friend"/> class.
        /// </summary>
        public Friend()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Friend"/> class.
        /// </summary>
        /// <param name="initialBalance">The initialBalance<see cref="double"/>.</param>
        public Friend(double initialBalance)
        {
            if (initialBalance <= -MaxCredit)
            {
                throw new System.Exception("amount too small");
            }

            Balance = initialBalance;
        }

        /// <summary>
        /// The AccountCreate.
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
            if (amount <= 0)
            {
                throw new System.Exception("amount too small");
            }

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
            if (amount <= 0)
            {
                throw new System.Exception("amount too small");
            }

            if (amount > (Balance + MaxCredit))
            {
                throw new System.Exception("friendship cash overloaded");
            }

            Balance -= amount;
            return Balance;
        }

        public override string ToString()
        {
            return $"{Name} {Balance}, credit = {MaxCredit}";
        }
    }
}
