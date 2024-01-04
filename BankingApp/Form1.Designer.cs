namespace BankingApp
{
    partial class Form1
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
            this.panelWindowContainer = new System.Windows.Forms.Panel();
            this.customerAccountsDisplayLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.welcomeCustomerLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.showAccountsInfoListBox = new System.Windows.Forms.ListBox();
            this.accountsSelectionLabel = new System.Windows.Forms.Label();
            this.isStaffLabel = new System.Windows.Forms.Label();
            this.interestButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.enterAmountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTypesOfAccounts = new System.Windows.Forms.ComboBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.panelWindowContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWindowContainer
            // 
            this.panelWindowContainer.BackColor = System.Drawing.Color.Moccasin;
            this.panelWindowContainer.Controls.Add(this.customerNameLabel);
            this.panelWindowContainer.Controls.Add(this.customerAccountsDisplayLabel);
            this.panelWindowContainer.Controls.Add(this.label2);
            this.panelWindowContainer.Controls.Add(this.welcomeCustomerLabel);
            this.panelWindowContainer.Controls.Add(this.exitButton);
            this.panelWindowContainer.Controls.Add(this.showAccountsInfoListBox);
            this.panelWindowContainer.Controls.Add(this.accountsSelectionLabel);
            this.panelWindowContainer.Controls.Add(this.isStaffLabel);
            this.panelWindowContainer.Controls.Add(this.interestButton);
            this.panelWindowContainer.Controls.Add(this.withdrawButton);
            this.panelWindowContainer.Controls.Add(this.depositButton);
            this.panelWindowContainer.Controls.Add(this.enterAmountTextBox);
            this.panelWindowContainer.Controls.Add(this.label1);
            this.panelWindowContainer.Controls.Add(this.comboBoxTypesOfAccounts);
            this.panelWindowContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelWindowContainer.Location = new System.Drawing.Point(1, 1);
            this.panelWindowContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelWindowContainer.Name = "panelWindowContainer";
            this.panelWindowContainer.Size = new System.Drawing.Size(1129, 773);
            this.panelWindowContainer.TabIndex = 0;
            // 
            // customerAccountsDisplayLabel
            // 
            this.customerAccountsDisplayLabel.AutoSize = true;
            this.customerAccountsDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAccountsDisplayLabel.Location = new System.Drawing.Point(32, 160);
            this.customerAccountsDisplayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerAccountsDisplayLabel.Name = "customerAccountsDisplayLabel";
            this.customerAccountsDisplayLabel.Size = new System.Drawing.Size(206, 29);
            this.customerAccountsDisplayLabel.TabIndex = 16;
            this.customerAccountsDisplayLabel.Text = "Accounts Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(40, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 46);
            this.label2.TabIndex = 15;
            this.label2.Text = "Citi Bank";
            // 
            // welcomeCustomerLabel
            // 
            this.welcomeCustomerLabel.AutoSize = true;
            this.welcomeCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeCustomerLabel.ForeColor = System.Drawing.Color.SandyBrown;
            this.welcomeCustomerLabel.Location = new System.Drawing.Point(637, 66);
            this.welcomeCustomerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeCustomerLabel.Name = "welcomeCustomerLabel";
            this.welcomeCustomerLabel.Size = new System.Drawing.Size(241, 33);
            this.welcomeCustomerLabel.TabIndex = 14;
            this.welcomeCustomerLabel.Text = "Welcome Admin";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1005, 64);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(73, 33);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // showAccountsInfoListBox
            // 
            this.showAccountsInfoListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAccountsInfoListBox.FormattingEnabled = true;
            this.showAccountsInfoListBox.HorizontalScrollbar = true;
            this.showAccountsInfoListBox.ItemHeight = 20;
            this.showAccountsInfoListBox.Location = new System.Drawing.Point(37, 395);
            this.showAccountsInfoListBox.Margin = new System.Windows.Forms.Padding(2);
            this.showAccountsInfoListBox.Name = "showAccountsInfoListBox";
            this.showAccountsInfoListBox.ScrollAlwaysVisible = true;
            this.showAccountsInfoListBox.Size = new System.Drawing.Size(1059, 324);
            this.showAccountsInfoListBox.TabIndex = 10;
            // 
            // accountsSelectionLabel
            // 
            this.accountsSelectionLabel.AutoSize = true;
            this.accountsSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsSelectionLabel.Location = new System.Drawing.Point(53, 302);
            this.accountsSelectionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accountsSelectionLabel.Name = "accountsSelectionLabel";
            this.accountsSelectionLabel.Size = new System.Drawing.Size(155, 20);
            this.accountsSelectionLabel.TabIndex = 9;
            this.accountsSelectionLabel.Text = "Select Account Type";
            // 
            // isStaffLabel
            // 
            this.isStaffLabel.AutoSize = true;
            this.isStaffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isStaffLabel.Location = new System.Drawing.Point(44, 252);
            this.isStaffLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isStaffLabel.Name = "isStaffLabel";
            this.isStaffLabel.Size = new System.Drawing.Size(98, 20);
            this.isStaffLabel.TabIndex = 7;
            this.isStaffLabel.Text = "isStaffLabel";
            // 
            // interestButton
            // 
            this.interestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestButton.Location = new System.Drawing.Point(952, 315);
            this.interestButton.Margin = new System.Windows.Forms.Padding(2);
            this.interestButton.Name = "interestButton";
            this.interestButton.Size = new System.Drawing.Size(143, 45);
            this.interestButton.TabIndex = 6;
            this.interestButton.Text = "Interest";
            this.interestButton.UseVisualStyleBackColor = true;
            this.interestButton.Click += new System.EventHandler(this.interestButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawButton.Location = new System.Drawing.Point(783, 315);
            this.withdrawButton.Margin = new System.Windows.Forms.Padding(2);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(143, 45);
            this.withdrawButton.TabIndex = 5;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositButton.Location = new System.Drawing.Point(612, 315);
            this.depositButton.Margin = new System.Windows.Forms.Padding(2);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(143, 45);
            this.depositButton.TabIndex = 4;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // enterAmountTextBox
            // 
            this.enterAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterAmountTextBox.Location = new System.Drawing.Point(769, 232);
            this.enterAmountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.enterAmountTextBox.Name = "enterAmountTextBox";
            this.enterAmountTextBox.Size = new System.Drawing.Size(237, 29);
            this.enterAmountTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(575, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Amount";
            // 
            // comboBoxTypesOfAccounts
            // 
            this.comboBoxTypesOfAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTypesOfAccounts.FormattingEnabled = true;
            this.comboBoxTypesOfAccounts.Items.AddRange(new object[] {
            "Everyday Account",
            "Investment Account",
            "Omni Account"});
            this.comboBoxTypesOfAccounts.Location = new System.Drawing.Point(47, 338);
            this.comboBoxTypesOfAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTypesOfAccounts.Name = "comboBoxTypesOfAccounts";
            this.comboBoxTypesOfAccounts.Size = new System.Drawing.Size(387, 32);
            this.comboBoxTypesOfAccounts.TabIndex = 1;
            this.comboBoxTypesOfAccounts.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypesOfAccounts_SelectedIndexChanged);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(44, 214);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(164, 20);
            this.customerNameLabel.TabIndex = 17;
            this.customerNameLabel.Text = "customerNameLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 773);
            this.Controls.Add(this.panelWindowContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelWindowContainer.ResumeLayout(false);
            this.panelWindowContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWindowContainer;
        private System.Windows.Forms.ComboBox comboBoxTypesOfAccounts;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox enterAmountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label isStaffLabel;
        private System.Windows.Forms.Button interestButton;
        private System.Windows.Forms.Label accountsSelectionLabel;
        private System.Windows.Forms.ListBox showAccountsInfoListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label welcomeCustomerLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label customerAccountsDisplayLabel;
        private System.Windows.Forms.Label customerNameLabel;
    }
}

