namespace Bankkonton
{

    partial class AccountInfo
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
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbAccountType = new System.Windows.Forms.Label();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.txAccountName = new System.Windows.Forms.TextBox();
            this.lbInitialBalance = new System.Windows.Forms.Label();
            this.txInitialAmount = new System.Windows.Forms.TextBox();
            this.lbCredit = new System.Windows.Forms.Label();
            this.txCredit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(507, 12);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 0;
            this.btOK.Text = "&OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(507, 41);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "&Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lbAccountType
            // 
            this.lbAccountType.AutoSize = true;
            this.lbAccountType.Location = new System.Drawing.Point(12, 9);
            this.lbAccountType.Name = "lbAccountType";
            this.lbAccountType.Size = new System.Drawing.Size(70, 13);
            this.lbAccountType.TabIndex = 2;
            this.lbAccountType.Text = "Account type";
            // 
            // cbAccountType
            // 
            this.cbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Location = new System.Drawing.Point(15, 25);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(436, 21);
            this.cbAccountType.TabIndex = 3;
            // 
            // lbAccountName
            // 
            this.lbAccountName.AutoSize = true;
            this.lbAccountName.Location = new System.Drawing.Point(12, 51);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(76, 13);
            this.lbAccountName.TabIndex = 4;
            this.lbAccountName.Text = "Account name";
            // 
            // txAccountName
            // 
            this.txAccountName.Location = new System.Drawing.Point(15, 67);
            this.txAccountName.Name = "txAccountName";
            this.txAccountName.Size = new System.Drawing.Size(436, 20);
            this.txAccountName.TabIndex = 5;
            // 
            // lbInitialBalance
            // 
            this.lbInitialBalance.AutoSize = true;
            this.lbInitialBalance.Location = new System.Drawing.Point(12, 90);
            this.lbInitialBalance.Name = "lbInitialBalance";
            this.lbInitialBalance.Size = new System.Drawing.Size(69, 13);
            this.lbInitialBalance.TabIndex = 6;
            this.lbInitialBalance.Text = "Initial amount";
            // 
            // txInitialAmount
            // 
            this.txInitialAmount.Location = new System.Drawing.Point(15, 106);
            this.txInitialAmount.Name = "txInitialAmount";
            this.txInitialAmount.Size = new System.Drawing.Size(198, 20);
            this.txInitialAmount.TabIndex = 7;
            this.txInitialAmount.Text = "0";
            this.txInitialAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txInitialAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txInitialAmount_KeyPress);
            // 
            // lbCredit
            // 
            this.lbCredit.AutoSize = true;
            this.lbCredit.Location = new System.Drawing.Point(12, 129);
            this.lbCredit.Name = "lbCredit";
            this.lbCredit.Size = new System.Drawing.Size(72, 13);
            this.lbCredit.TabIndex = 8;
            this.lbCredit.Text = "Credit amount";
            // 
            // txCredit
            // 
            this.txCredit.Location = new System.Drawing.Point(15, 145);
            this.txCredit.Name = "txCredit";
            this.txCredit.Size = new System.Drawing.Size(198, 20);
            this.txCredit.TabIndex = 9;
            this.txCredit.Text = "0";
            this.txCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txCredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txCredit_KeyPress);
            // 
            // AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 187);
            this.Controls.Add(this.txCredit);
            this.Controls.Add(this.lbCredit);
            this.Controls.Add(this.txInitialAmount);
            this.Controls.Add(this.lbInitialBalance);
            this.Controls.Add(this.txAccountName);
            this.Controls.Add(this.lbAccountName);
            this.Controls.Add(this.cbAccountType);
            this.Controls.Add(this.lbAccountType);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Name = "AccountInfo";
            this.Text = "AccountInfo";
            this.Load += new System.EventHandler(this.AccountInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbAccountType;
        private System.Windows.Forms.ComboBox cbAccountType;
        private System.Windows.Forms.Label lbAccountName;
        private System.Windows.Forms.TextBox txAccountName;
        private System.Windows.Forms.Label lbInitialBalance;
        private System.Windows.Forms.TextBox txInitialAmount;
        private System.Windows.Forms.Label lbCredit;
        private System.Windows.Forms.TextBox txCredit;
    }
}