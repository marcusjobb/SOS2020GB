namespace OOPInterfaces.Interfaces
{
    /// <summary>
    /// Defines the <see cref="IAccount" />.
    /// </summary>
    interface IAccount
    {
        /// <summary>
        /// Gets or sets the Name
        /// Name of the account.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets the Balance
        /// The money!.
        /// </summary>
        double Balance { get; }

        /// <summary>
        /// Get account info.
        /// </summary>
        /// <returns>a string with info.</returns>
        string AccountInfo();

        /// <summary>
        /// Withdraw money.
        /// </summary>
        /// <param name="amount">The amount<see cref="double"/>.</param>
        /// <returns>the balance.</returns>
        double Withdraw(double amount);

        /// <summary>
        /// Deposit money.
        /// </summary>
        /// <param name="amount">The amount<see cref="double"/>.</param>
        /// <returns>the balance.</returns>
        double Deposit(double amount);
    }
}
