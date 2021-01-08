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

    public partial class AddRemoveForm : Form
    {
        public Interfaces.IAccount Account { get; set; }

        public AddRemoveForm()
        {
            InitializeComponent();
        }

        private void fmAddRemove_Load(object sender, EventArgs e)
        {
            if (Account==null)
            {
                MessageBox.Show("Account not selected");
                Close();
            }
            else
            { 
            txAccountNae.Text = Account.Name;
            txBalance.Text = Account.Balance.ToString();
        }
        }

        private void txDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                double.TryParse(txAmount.Text, out double amount);
                Account.Deposit(amount);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                double.TryParse(txAmount.Text, out double amount);
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
