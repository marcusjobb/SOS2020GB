namespace Bankkonton
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="MainForm" />.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            AppData.LoadAccounts();
            InitializeComponent();
        }

        /// <summary>
        /// The btAddAccount_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btAddAccount_Click(object sender, EventArgs e)
        {
            using (AccountCreate frm = new AccountCreate())
            {
                frm.ShowDialog();
            }
            RefreshList();
        }

        /// <summary>
        /// The Form1_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        /// <summary>
        /// The RefreshList.
        /// </summary>
        private void RefreshList()
        {
            lsAccounts.Items.Clear();
            lsAccounts.Items.AddRange(AppData.Accounts.ToArray());
        }

        /// <summary>
        /// The lsAccounts_DoubleClick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void lsAccounts_DoubleClick(object sender, EventArgs e)
        {
            Interfaces.IAccount account = lsAccounts.SelectedItem as Interfaces.IAccount;
            using (AddRemoveForm frm = new AddRemoveForm())
            {
                frm.Account = account;
                frm.ShowDialog();
            }
            RefreshList();
        }

        /// <summary>
        /// The MainForm_FormClosed.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="FormClosedEventArgs"/>.</param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppData.SaveAccounts();
        }
    }
}
