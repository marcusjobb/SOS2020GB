namespace Bankkonton
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="AddRemoveForm" />.
    /// </summary>
    public partial class AddRemoveForm : Form
    {
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        public Interfaces.IAccount Account { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRemoveForm"/> class.
        /// </summary>
        public AddRemoveForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This happens before the form is loaded.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void fmAddRemove_Load(object sender, EventArgs e)
        {
            if (Account == null)
            {
                MessageBox.Show("Account not selected");
                Close();
            }
            else
            {
                txAccountName.Text = Account.Name;
                txBalance.Text = Account.Balance.ToString();
            }
        }

        /// <summary>
        /// This happens when the deposit button is clicked.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void txDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                double.TryParse(txAmount.Text, out double amount);
                Account.Deposit(amount);
                Account.Name = txAccountName.Text;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// This happens when the withdraw button is clicked.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                double.TryParse(txAmount.Text, out double amount);
                Account.Name = txAccountName.Text;
                Account.Withdraw(amount);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
