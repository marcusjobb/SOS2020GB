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

    public partial class AccountInfo : Form
    {

        private string[] AccountTypes = new string[]
        {
            "Savings account",
            "Investment account",
            "Credit card",
            "Friends"
        };

        //public Interfaces.IAccount Account { get; set; }

        public AccountInfo()
        {
            InitializeComponent();
        }

        private void AccountInfo_Load(object sender, EventArgs e)
        {
            cbAccountType.Items.AddRange(AccountTypes);
        }

        private void txInitialAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("0123456789".IndexOf(e.KeyChar) < 0)
            {
                e.Handled = true;
            }
        }

        private void txCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("0123456789".IndexOf(e.KeyChar) < 0)
            {
                e.Handled = true;
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            double.TryParse(txInitialAmount.Text, out double initBalance);

            double.TryParse(txInitialAmount.Text, out double maxCredit);

            switch (cbAccountType.SelectedItem.ToString())
            {
                case "Savings account":
                    AccountData.Accounts.Add(new SavingAccount
                    (initBalance)
                    {
                        Name = txAccountName.Text,
                    }
                    );
                    break;
                case "Investment account":
                    AccountData.Accounts.Add(new InvestmentAccount
                    (initBalance)
                    {
                        Name = txAccountName.Text,
                    }
                    );
                    break;
                case "Friends":
                case "Credit card":
                    AccountData.Accounts.Add(new Creditcard
                    (initBalance)
                    {
                        Name = txAccountName.Text,
                        MaxCredit= maxCredit
                    }
                    );
                    break;
                default:
                    break;
            }
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
