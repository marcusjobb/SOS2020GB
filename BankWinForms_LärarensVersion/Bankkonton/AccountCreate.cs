namespace Bankkonton
{
    using Bankkonton.Enummerators;

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="AccountCreate" />.
    /// </summary>
    public partial class AccountCreate : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCreate"/> class.
        /// </summary>
        public AccountCreate()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This happens before the form is loaded.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void AccountCreate_Load(object sender, EventArgs e)
        {
            // Omvandla alla typer till en string array
            var lst = new List<string>();
            foreach (var item in Enum.GetValues(typeof(AccountTypes)))
            {
                lst.Add(item.ToString());
            }
            cbAccountType.Items.AddRange(lst.ToArray());
        }

        /// <summary>
        /// This happens when a key is pressed. Control to make sure only numbers are added.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
        private void txInitialAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("0123456789\b.,".IndexOf(e.KeyChar) < 0)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// This happens when a key is pressed. Control to make sure only numbers are added.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
        private void txCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("0123456789\b.,".IndexOf(e.KeyChar) < 0)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// OK button click handler.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btOK_Click(object sender, EventArgs e)
        {
            double.TryParse(txInitialAmount.Text, out double initBalance);

            double.TryParse(txInitialAmount.Text, out double maxCredit);

            Enum.TryParse<AccountTypes>(cbAccountType.SelectedItem.ToString(), out AccountTypes accountType);

            switch (accountType)
            {
                case AccountTypes.SavingsAccount:
                    AppData.Accounts.Add(new SavingAccount
                   (initBalance)
                    {
                        Name = txAccountName.Text,
                    }
                   );
                    break;

                case AccountTypes.InvestmentAccount:
                    AppData.Accounts.Add(new InvestmentAccount
                   (initBalance)
                    {
                        Name = txAccountName.Text,
                    }
                   );
                    break;

                case AccountTypes.CreditCard:
                    AppData.Accounts.Add(new Creditcard
                   (initBalance)
                    {
                        Name = txAccountName.Text,
                        MaxCredit = maxCredit
                    }
                   );
                    break;

                case AccountTypes.Friends:
                    AppData.Accounts.Add(new Friend
                   (initBalance)
                    {
                        Name = txAccountName.Text,
                        MaxCredit = maxCredit
                    }
                   );
                    break;

                default:
                    break;
            }
            Close();
        }

        /// <summary>
        /// Cancel was pressed.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}