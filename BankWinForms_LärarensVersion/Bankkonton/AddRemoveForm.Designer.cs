namespace Bankkonton
{

    partial class AddRemoveForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txDeposit = new System.Windows.Forms.Button();
            this.btWithdraw = new System.Windows.Forms.Button();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.txAccountName = new System.Windows.Forms.TextBox();
            this.txBalance = new System.Windows.Forms.TextBox();
            this.txAmount = new System.Windows.Forms.TextBox();
            this.btAmount = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txDeposit
            // 
            this.txDeposit.Location = new System.Drawing.Point(241, 12);
            this.txDeposit.Name = "txDeposit";
            this.txDeposit.Size = new System.Drawing.Size(109, 23);
            this.txDeposit.TabIndex = 0;
            this.txDeposit.Text = "&Deposit";
            this.txDeposit.UseVisualStyleBackColor = true;
            this.txDeposit.Click += new System.EventHandler(this.txDeposit_Click);
            // 
            // btWithdraw
            // 
            this.btWithdraw.Location = new System.Drawing.Point(241, 41);
            this.btWithdraw.Name = "btWithdraw";
            this.btWithdraw.Size = new System.Drawing.Size(109, 23);
            this.btWithdraw.TabIndex = 1;
            this.btWithdraw.Text = "&Withdraw";
            this.btWithdraw.UseVisualStyleBackColor = true;
            this.btWithdraw.Click += new System.EventHandler(this.btWithdraw_Click);
            // 
            // lbAccountName
            // 
            this.lbAccountName.AutoSize = true;
            this.lbAccountName.Location = new System.Drawing.Point(12, 9);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(47, 13);
            this.lbAccountName.TabIndex = 2;
            this.lbAccountName.Text = "Account";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Location = new System.Drawing.Point(12, 32);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(46, 13);
            this.lbBalance.TabIndex = 3;
            this.lbBalance.Text = "Balance";
            // 
            // txAccountName
            // 
            this.txAccountName.Location = new System.Drawing.Point(65, 9);
            this.txAccountName.Name = "txAccountName";
            this.txAccountName.Size = new System.Drawing.Size(163, 20);
            this.txAccountName.TabIndex = 4;
            // 
            // txBalance
            // 
            this.txBalance.Enabled = false;
            this.txBalance.Location = new System.Drawing.Point(64, 32);
            this.txBalance.Name = "txBalance";
            this.txBalance.Size = new System.Drawing.Size(163, 20);
            this.txBalance.TabIndex = 5;
            this.txBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txAmount
            // 
            this.txAmount.Location = new System.Drawing.Point(64, 66);
            this.txAmount.Name = "txAmount";
            this.txAmount.Size = new System.Drawing.Size(163, 20);
            this.txAmount.TabIndex = 7;
            this.txAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btAmount
            // 
            this.btAmount.AutoSize = true;
            this.btAmount.Location = new System.Drawing.Point(13, 69);
            this.btAmount.Name = "btAmount";
            this.btAmount.Size = new System.Drawing.Size(43, 13);
            this.btAmount.TabIndex = 6;
            this.btAmount.Text = "Amount";
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(241, 70);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(109, 23);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "&Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // AddRemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(362, 105);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.txAmount);
            this.Controls.Add(this.btAmount);
            this.Controls.Add(this.txBalance);
            this.Controls.Add(this.txAccountName);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.lbAccountName);
            this.Controls.Add(this.btWithdraw);
            this.Controls.Add(this.txDeposit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRemoveForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Remove funds";
            this.Load += new System.EventHandler(this.fmAddRemove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txDeposit;
        private System.Windows.Forms.Button btWithdraw;
        private System.Windows.Forms.Label lbAccountName;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.TextBox txAccountName;
        private System.Windows.Forms.TextBox txBalance;
        private System.Windows.Forms.TextBox txAmount;
        private System.Windows.Forms.Label btAmount;
        private System.Windows.Forms.Button btCancel;
    }
}