namespace Bankkonton
{
    using Bankkonton.Enummerators;
    using Bankkonton.Interfaces;

    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="AppData" />.
    /// </summary>
    internal static class AppData
    {
        /// <summary>
        /// Defines the Accounts.
        /// </summary>
        public static List<Interfaces.IAccount> Accounts = new List<Interfaces.IAccount>();

        /// <summary>
        /// Load the accounts.
        /// </summary>
        internal static void LoadAccounts()
        {
            // Load creditcards and add to list
            var cards = new GenericJsonFilehandler<List<Creditcard>>(AccountTypes.CreditCard.ToString());
            cards.Load();
            if (cards.Data != null) Accounts.AddRange(cards.Data);

            // Load invest accounts and add to list
            var invest = new GenericJsonFilehandler<List<InvestmentAccount>>(AccountTypes.InvestmentAccount.ToString());
            invest.Load();
            if (invest.Data != null) Accounts.AddRange(invest.Data);

            // Load savings account and add to list
            var saving = new GenericJsonFilehandler<List<SavingAccount>>(AccountTypes.SavingsAccount.ToString());
            saving.Load();
            if (saving.Data != null) Accounts.AddRange(saving.Data);

            // Load friends and add to list
            var friends = new GenericJsonFilehandler<List<Friend>>(AccountTypes.Friends.ToString());
            friends.Load();
            if (friends.Data != null) Accounts.AddRange(friends.Data);

            if (Accounts.Count == 0)
            {
                Accounts = new List<IAccount>
                {
                    new SavingAccount     (10000)  { Name="Saving"},
                    new SavingAccount     (140000) { Name="Saving for a house"},
                    new SavingAccount     (10)     { Name="Salary"},
                    new SavingAccount     (1000)   { Name="Månadspizza"},
                    new InvestmentAccount (1000)   { Name="Investment"},
                    new Friend            (0)      { Name="James", MaxCredit=1500},
                    new Friend            (0)      { Name="Maria", MaxCredit=1500},
                    new Friend            (0)      { Name="Marie", MaxCredit=1500},
                    new Friend            (0)      { Name="Claudia", MaxCredit=1500},
                    new Creditcard        (1337)   { Name = "MasterCard", MaxCredit = 15000 },
                    new Creditcard        (1200)   { Name = "American Express", MaxCredit = 15000 },
            };
            }
        }

        /// <summary>
        /// Save the Accounts.
        /// </summary>
        internal static void SaveAccounts()
        {
            // Extract all Creditcards from the list and save them
            var cards = new GenericJsonFilehandler<List<Creditcard>>(AccountTypes.CreditCard.ToString())
            {
                Data = Accounts.Where(a => a.GetType() == typeof(Creditcard))
                .Select(a => a as Creditcard).ToList()
            };
            cards.Save();

            // Extract all InvestAccounts from the list and save them
            var invest = new GenericJsonFilehandler<List<InvestmentAccount>>(AccountTypes.InvestmentAccount.ToString())
            {
                Data = Accounts.Where(a => a.GetType() == typeof(InvestmentAccount))
                .Select(a => a as InvestmentAccount).ToList()
            };
            invest.Save();

            // Extract all Savings accounts from the list and save them
            var saving = new GenericJsonFilehandler<List<SavingAccount>>(AccountTypes.SavingsAccount.ToString())
            {
                Data = Accounts.Where(a => a.GetType() == typeof(SavingAccount))
                .Select(a => a as SavingAccount).ToList()
            };
            saving.Save();

            // Extract all Friend from the list and save them
            var friends = new GenericJsonFilehandler<List<Friend>>(AccountTypes.Friends.ToString())
            {
                Data = Accounts.Where(a => a.GetType() == typeof(Friend))
                .Select(a => a as Friend).ToList()
            };
            saving.Save();
        }
    }
}