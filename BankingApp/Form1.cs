using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class Form1 : Form
    {
        //Customer class object
        Customer customer_1 = new Customer("Steve", 123456);

        // Creating objects from Acoounts classes
        EverydayAccount everydayAccount = new EverydayAccount(1000);
        InvestmentAccount investmentAccount = new InvestmentAccount(1000);
        OmniAccount omniAccount = new OmniAccount(1000);

        private Account account; // account for combobox selected account from customer accounts list

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Adding Accounts to Customer Accounts List
            customer_1.AddAccount(everydayAccount);
            customer_1.AddAccount(investmentAccount);
            customer_1.AddAccount(omniAccount);

            accountNameDisplayLabel.Text = string.Empty; //clear any text from the label to display different type of accounts

            // Update Customer Account Types
            comboBoxTypesOfAccounts.Items.Clear();  // Clear any items in the combobox

            // Adding Customer Accounts dynamically in the combebox
            foreach (var account in customer_1.Accounts)
            {
                comboBoxTypesOfAccounts.Items.Add(account);
            }
            comboBoxTypesOfAccounts.SelectedIndex = 0;

            welcomeCustomerLabel.Text = $"Welcome {customer_1.Name}"; // Welcome Customer Message
        }

        private void comboBoxTypesOfAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            showAccountsInfoListBox.Items.Clear(); // Clearing Listbox Items

            // Selecting specific account from combobox
            if (comboBoxTypesOfAccounts.SelectedItem is Account selectedAccount){
                accountNameDisplayLabel.Text = $"Account Type: {selectedAccount.Type}";
                showAccountsInfoListBox.Items.Add(selectedAccount.AccountInfo());

                account = (Account)comboBoxTypesOfAccounts.SelectedItem;
            }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            showAccountsInfoListBox.Items.Clear();

            string amount = enterAmountTextBox.Text;

            // Validation if no items are selected from combobox
            if (comboBoxTypesOfAccounts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid Account!");
            }
            else
            {
                // deposit validations
                if (double.TryParse(amount, out double valid_amount) && valid_amount > 0)
                {
                    account.Deposit(valid_amount);
                    MessageBox.Show($"${valid_amount} deposited successfully in {account.Type}!");
                    showAccountsInfoListBox.Items.Add(account.AccountInfo());
                }
                else
                {
                    //Validation if input is not a valid number/double
                    MessageBox.Show("Invalid input. Please enter a valid amount");
                    showAccountsInfoListBox.Items.Add(account.AccountInfo());
                }
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            showAccountsInfoListBox.Items.Clear();

            string amount = enterAmountTextBox.Text;

            if (comboBoxTypesOfAccounts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid Account!");
            }
            else
            {
                // Validation for amount to be over 0 and valid number/double
                if (double.TryParse(amount, out double valid_amount) && valid_amount > 0)
                {
                    account.Withdraw(valid_amount);
                    showAccountsInfoListBox.Items.Add(account.AccountInfo());
                }
                else
                {
                    //Validation if input is not a valid number/double
                    MessageBox.Show("Invalid input. Please enter a valid amount");
                    showAccountsInfoListBox.Items.Add(account.AccountInfo());

                }
            }
        }

        private void interestButton_Click(object sender, EventArgs e)
        {
            showAccountsInfoListBox.Items.Clear();

            if (comboBoxTypesOfAccounts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid Account!");
            }
            else if (account.Type == "Everyday Account")
            {
                MessageBox.Show("No Interest on this account!");
                showAccountsInfoListBox.Items.Add(account.AccountInfo());
            }
            else
            {
                // Interest Validations and Messages
                double interest_earned = account.CalculateInterest();
                if (interest_earned > 0)
                {
                    MessageBox.Show($"Interest amount ${interest_earned} Added Successfully in your balance ${account.Balance}!");
                    account.AddInterest(interest_earned);
                }
                else
                {
                    MessageBox.Show($"No interest earned on ${account.Balance}!");
                }
                showAccountsInfoListBox.Items.Add(account.AccountInfo());
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application
        }
    }
}
