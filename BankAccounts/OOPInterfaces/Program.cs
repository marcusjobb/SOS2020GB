namespace OOPInterfaces
{
    using OOPInterfaces.Interfaces;

    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The Main.
        /// </summary>
        private static void Main()
        {
            var bank = new List<IAccount>
            {
                new SavingAccount     (10000)  { Name="Saving"},
                new SavingAccount     (140000) { Name="Saving for a house"},
                new SavingAccount     (10)     { Name="Salary"},
                new SavingAccount     (1000)   { Name="Månadspizza"},
                new InvestmentAccount (1000)   { Name="Investment"},
                new Creditcard        (0)      { Name="James", MaxCredit=1500},
                new Creditcard        (0)      { Name="Maria", MaxCredit=1500},
                new Creditcard        (0)      { Name="Marie", MaxCredit=1500},
                new Creditcard        (0)      { Name="Claudia", MaxCredit=1500},
            };

            var card = new Creditcard(1337) { Name = "Credit card", MaxCredit = 15000 };
            card.Withdraw(15000);
            bank.Add(card);

            foreach (var account in bank)
            {
                Console.WriteLine(account.AccountInfo());
            }
        }
    }
}
