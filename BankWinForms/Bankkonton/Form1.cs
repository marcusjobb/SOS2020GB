namespace Bankkonton
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAddAccount_Click(object sender, EventArgs e)
        {
            using (var frm = new AccountInfo())
            {
                frm.ShowDialog();
            }
            RefreshList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (AccountData.Accounts.Count == 0)
            {
                AccountData.Accounts.AddRange(new List<Interfaces.IAccount>
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
                });

                RefreshList();
            }
        }
        private void RefreshList()
        {
            lsAccounts.Items.Clear();
            lsAccounts.Items.AddRange(AccountData.Accounts.ToArray());
        }

        private void lsAccounts_DoubleClick(object sender, EventArgs e)
        {
            var account = (Interfaces.IAccount)lsAccounts.SelectedItem;
            MessageBox.Show(account.Name);
            account.Deposit(100);
            RefreshList();
        }
    }
}
