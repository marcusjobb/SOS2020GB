namespace Bankkonton
{

    partial class MainForm
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
            this.btAddAccount = new System.Windows.Forms.Button();
            this.lsAccounts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btAddAccount
            // 
            this.btAddAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddAccount.Location = new System.Drawing.Point(425, 12);
            this.btAddAccount.Name = "btAddAccount";
            this.btAddAccount.Size = new System.Drawing.Size(112, 23);
            this.btAddAccount.TabIndex = 0;
            this.btAddAccount.Text = "Add Account";
            this.btAddAccount.UseVisualStyleBackColor = true;
            this.btAddAccount.Click += new System.EventHandler(this.btAddAccount_Click);
            // 
            // lsAccounts
            // 
            this.lsAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsAccounts.FormattingEnabled = true;
            this.lsAccounts.Location = new System.Drawing.Point(14, 12);
            this.lsAccounts.Name = "lsAccounts";
            this.lsAccounts.Size = new System.Drawing.Size(396, 329);
            this.lsAccounts.TabIndex = 1;
            this.lsAccounts.DoubleClick += new System.EventHandler(this.lsAccounts_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 358);
            this.Controls.Add(this.lsAccounts);
            this.Controls.Add(this.btAddAccount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAddAccount;
        private System.Windows.Forms.ListBox lsAccounts;
    }
}

