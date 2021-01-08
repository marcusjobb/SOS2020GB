namespace Bankkonton
{
    using Bankkonton.Interfaces;

    using Newtonsoft.Json;

    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    static class AccountData
    {
        public static List<Interfaces.IAccount> Accounts = new List<Interfaces.IAccount>();

        //internal static void SaveAccounts()
        //{
        //    SaveAccounts("Creditcards", Accounts.Where(a => a.GetType() == typeof(Creditcard)).ToList());
        //    SaveAccounts("Investment", Accounts.Where(a => a.GetType() == typeof(InvestmentAccount)).ToList());
        //    SaveAccounts("Saving", Accounts.Where(a => a.GetType() == typeof(SavingAccount)).ToList());
        //}

        //private static void SaveAccounts(string file, List<IAccount> list)
        //{
        //    File.WriteAllText(file + ".acc.json", JsonConvert.SerializeObject(file, Formatting.Indented));
        //}

        //public static void LoadAccounts()
        //{
        //    LoadAccounts("Creditcards", typeof(Creditcard));
        //    LoadAccounts("Investment", typeof(InvestmentAccount));
        //    LoadAccounts("Saving", typeof(SavingAccount));
        //}
        //private static List<Interfaces.IAccount> LoadAccounts(string filename, Type accType)
        //{
        //    var data = string.Empty;
        //    if (File.Exists(filename + ".json"))
        //    {
        //        try
        //        {
        //            data = File.ReadAllText(filename + ".json");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //            data = "";
        //        }
        //    }
        //    return (List<Interfaces.IAccount>)JsonConvert.DeserializeObject<List<accType>>(data);
        //}
    }
}
