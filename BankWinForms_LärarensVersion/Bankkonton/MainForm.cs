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

    public partial class MainForm : Form
    {
        public MainForm()
        {
            //AccountData.LoadAccounts();
            InitializeComponent();
        }

        private void btAddAccount_Click(object sender, EventArgs e)
        {
            using (var frm = new AccountCreate())
            {
                frm.ShowDialog();
            }
            RefreshList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void RefreshList()
        {
            lsAccounts.Items.Clear();
            lsAccounts.Items.AddRange(AccountData.Accounts.ToArray());
        }

        private void lsAccounts_DoubleClick(object sender, EventArgs e)
        {
            var account = lsAccounts.SelectedItem as Interfaces.IAccount;
            using (var frm = new AddRemoveForm())
            {
                frm.Account = account;
                frm.ShowDialog();
            }
            RefreshList();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //AccountData.SaveAccounts();
        }
    }
}
