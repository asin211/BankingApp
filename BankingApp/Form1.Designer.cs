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
            this.exitButton = new System.Windows.Forms.Button();
            this.logoLabel = new System.Windows.Forms.Label();
            this.showAccountsInfoListBox = new System.Windows.Forms.ListBox();
            this.accountsSelectionLabel = new System.Windows.Forms.Label();
            this.accountNameDisplayLabel = new System.Windows.Forms.Label();
            this.interestButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.enterAmountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTypesOfAccounts = new System.Windows.Forms.ComboBox();
            this.welcomeCustomerLabel = new System.Windows.Forms.Label();
            this.panelWindowContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWindowContainer
            // 
            this.panelWindowContainer.BackColor = System.Drawing.Color.Moccasin;
            this.panelWindowContainer.Controls.Add(this.exitButton);
            this.panelWindowContainer.Controls.Add(this.logoLabel);
            this.panelWindowContainer.Controls.Add(this.showAccountsInfoListBox);
            this.panelWindowContainer.Controls.Add(this.accountsSelectionLabel);
            this.panelWindowContainer.Controls.Add(this.accountNameDisplayLabel);
            this.panelWindowContainer.Controls.Add(this.interestButton);
            this.panelWindowContainer.Controls.Add(this.withdrawButton);
            this.panelWindowContainer.Controls.Add(this.depositButton);
            this.panelWindowContainer.Controls.Add(this.enterAmountTextBox);
            this.panelWindowContainer.Controls.Add(this.label1);
            this.panelWindowContainer.Controls.Add(this.comboBoxTypesOfAccounts);
            this.panelWindowContainer.Controls.Add(this.welcomeCustomerLabel);
            this.panelWindowContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelWindowContainer.Location = new System.Drawing.Point(2, 2);
            this.panelWindowContainer.Name = "panelWindowContainer";
            this.panelWindowContainer.Size = new System.Drawing.Size(1552, 1160);
            this.panelWindowContainer.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1405, 78);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 49);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.SandyBrown;
            this.logoLabel.Location = new System.Drawing.Point(68, 53);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(299, 74);
            this.logoLabel.TabIndex = 11;
            this.logoLabel.Text = "Citi Bank";
            // 
            // showAccountsInfoListBox
            // 
            this.showAccountsInfoListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAccountsInfoListBox.FormattingEnabled = true;
            this.showAccountsInfoListBox.HorizontalScrollbar = true;
            this.showAccountsInfoListBox.ItemHeight = 32;
            this.showAccountsInfoListBox.Location = new System.Drawing.Point(51, 465);
            this.showAccountsInfoListBox.Name = "showAccountsInfoListBox";
            this.showAccountsInfoListBox.ScrollAlwaysVisible = true;
            this.showAccountsInfoListBox.Size = new System.Drawing.Size(1454, 516);
            this.showAccountsInfoListBox.TabIndex = 10;
            // 
            // accountsSelectionLabel
            // 
            this.accountsSelectionLabel.AutoSize = true;
            this.accountsSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsSelectionLabel.Location = new System.Drawing.Point(74, 196);
            this.accountsSelectionLabel.Name = "accountsSelectionLabel";
            this.accountsSelectionLabel.Size = new System.Drawing.Size(289, 36);
            this.accountsSelectionLabel.TabIndex = 9;
            this.accountsSelectionLabel.Text = "Select Account Type";
            // 
            // accountNameDisplayLabel
            // 
            this.accountNameDisplayLabel.AutoSize = true;
            this.accountNameDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNameDisplayLabel.Location = new System.Drawing.Point(60, 401);
            this.accountNameDisplayLabel.Name = "accountNameDisplayLabel";
            this.accountNameDisplayLabel.Size = new System.Drawing.Size(368, 36);
            this.accountNameDisplayLabel.TabIndex = 7;
            this.accountNameDisplayLabel.Text = "accountNameDisplayLabel";
            // 
            // interestButton
            // 
            this.interestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestButton.Location = new System.Drawing.Point(1309, 345);
            this.interestButton.Name = "interestButton";
            this.interestButton.Size = new System.Drawing.Size(196, 68);
            this.interestButton.TabIndex = 6;
            this.interestButton.Text = "Interest";
            this.interestButton.UseVisualStyleBackColor = true;
            this.interestButton.Click += new System.EventHandler(this.interestButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawButton.Location = new System.Drawing.Point(1077, 345);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(196, 68);
            this.withdrawButton.TabIndex = 5;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositButton.Location = new System.Drawing.Point(841, 345);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(196, 68);
            this.depositButton.TabIndex = 4;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // enterAmountTextBox
            // 
            this.enterAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterAmountTextBox.Location = new System.Drawing.Point(1057, 212);
            this.enterAmountTextBox.Name = "enterAmountTextBox";
            this.enterAmountTextBox.Size = new System.Drawing.Size(324, 45);
            this.enterAmountTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(791, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 39);
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
            this.comboBoxTypesOfAccounts.Location = new System.Drawing.Point(66, 251);
            this.comboBoxTypesOfAccounts.Name = "comboBoxTypesOfAccounts";
            this.comboBoxTypesOfAccounts.Size = new System.Drawing.Size(530, 46);
            this.comboBoxTypesOfAccounts.TabIndex = 1;
            this.comboBoxTypesOfAccounts.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypesOfAccounts_SelectedIndexChanged);
            // 
            // welcomeCustomerLabel
            // 
            this.welcomeCustomerLabel.AutoSize = true;
            this.welcomeCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeCustomerLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeCustomerLabel.Location = new System.Drawing.Point(936, 72);
            this.welcomeCustomerLabel.Name = "welcomeCustomerLabel";
            this.welcomeCustomerLabel.Size = new System.Drawing.Size(351, 55);
            this.welcomeCustomerLabel.TabIndex = 0;
            this.welcomeCustomerLabel.Text = "Welcome User";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 1130);
            this.Controls.Add(this.panelWindowContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelWindowContainer.ResumeLayout(false);
            this.panelWindowContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWindowContainer;
        private System.Windows.Forms.Label welcomeCustomerLabel;
        private System.Windows.Forms.ComboBox comboBoxTypesOfAccounts;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox enterAmountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label accountNameDisplayLabel;
        private System.Windows.Forms.Button interestButton;
        private System.Windows.Forms.Label accountsSelectionLabel;
        private System.Windows.Forms.ListBox showAccountsInfoListBox;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

