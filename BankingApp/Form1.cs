using System;
using System.CodeDom;
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
        Controller controller = new Controller();  // For accessing methods from controller class 

        //Customer class object
        Customer customer_1 = new Customer("Steve", 123456, true);

        // Creating objects from Acoounts classes
        EverydayAccount everydayAccount = new EverydayAccount(1000);
        InvestmentAccount investmentAccount = new InvestmentAccount(1000);
        OmniAccount omniAccount = new OmniAccount(1000);

        private Account account; // account for combobox selected account from customer accounts list
        
        public Form1()
        {
            InitializeComponent();
        }

        /*
        //delete this
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
        }
        */

        private void Form1_Load(object sender, EventArgs e)
        {
            // Adding Accounts to Customer Accounts List
            customer_1.AddAccount(everydayAccount);
            customer_1.AddAccount(investmentAccount);
            customer_1.AddAccount(omniAccount);

            /*
            // If Accounts are added to from controller class, access the data with code below 
            controller.AddAccount(customer_1, everydayAccount);
            controller.AddAccount(customer_1, investmentAccount);
            controller.AddAccount(customer_1, omniAccount);
            controller.AddCustomer(customer_1);
            customer_1 = controller.CustomersList[0];
            */

            isStaffLabel.Text = string.Empty; //clear any text from the label to display different type of accounts
            customerNameLabel.Text = string.Empty;


            // Update Customer Account Types
            comboBoxTypesOfAccounts.Items.Clear();  // Clear any items in the combobox
            try
            {
                if (customer_1.Accounts.Count > 0)
                {
                    // Adding Customer Accounts dynamically in the combebox
                    foreach (var account in customer_1.Accounts)
                    {
                        comboBoxTypesOfAccounts.Items.Add(account);
                    }
                    comboBoxTypesOfAccounts.SelectedIndex = 0;
                }
            }
            catch (System.IndexOutOfRangeException ex)
            {
                MessageBox.Show($"No accounts found!\nError: {ex.Message}");
            }
            /*
            catch (System.InvalidCastException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */

            welcomeCustomerLabel.Text = $"Welcome {customer_1.Name}"; // Welcome Customer Message
        }

        private void comboBoxTypesOfAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            showAccountsInfoListBox.Items.Clear(); // Clearing Listbox Items

            // Selecting specific account from combobox
            if (comboBoxTypesOfAccounts.SelectedItem is Account selectedAccount){
                isStaffLabel.Text = customer_1.Staff ? $"Staff: Yes" : $"Staff: No";
                customerNameLabel.Text = $"Name: {customer_1.Name}";
                account = (Account)comboBoxTypesOfAccounts.SelectedItem;
                account.AssociatedCustomer = customer_1;
            }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            showAccountsInfoListBox.Items.Clear();

            string amount = enterAmountTextBox.Text;
            enterAmountTextBox.Clear(); // Clear the user input

            // Validation if no items are selected from combobox
            if (comboBoxTypesOfAccounts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid Account!");
            }
            else
            {
                try
                {
                    // deposit validations
                    if (double.TryParse(amount, out double valid_amount) && valid_amount > 0)
                    {
                        account.Deposit(valid_amount);
                        MessageBox.Show($"${valid_amount} deposited successfully in {account.Type}!");
                        showAccountsInfoListBox.Items.Add(account.AccountInfo());
                    } else
                    {
                        throw new CustomException("Invalid input, please enter amount greater than 0!");
                    }
                }
                catch (CustomException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    showAccountsInfoListBox.Items.Add(account.AccountInfo());

                }
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            showAccountsInfoListBox.Items.Clear();

            string amount = enterAmountTextBox.Text;

            enterAmountTextBox.Clear(); // Clear the user input

            if (comboBoxTypesOfAccounts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid Account!");
                return;
            }

            try
            {
                if (!double.TryParse(amount, out double valid_amount) || valid_amount <= 0)
                {
                    //Validation if input is not a valid number/double
                    throw new CustomException("Invalid input. Please enter a valid amount greater than 0!");
                } else
                {
                    switch (account.Type)
                    {
                        case "Everyday Account":
                        case "Investment Account":
                        case "Omni Account":
                            if (CheckSufficientBalance(valid_amount))
                            {
                                account.Withdraw(valid_amount);
                                MessageBox.Show($"${valid_amount} withdrawn successfully from {account.Type}!");
                            }
                            else
                            {
                                HandleInsufficientBalance(valid_amount);
                            }
                            break;
                        default:
                            break;
                    }
                    showAccountsInfoListBox.Items.Add(account.AccountInfo());

                }
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                showAccountsInfoListBox.Items.Add(account.AccountInfo());
            }
        }


        private bool CheckSufficientBalance(double amount)
        {
            double balanceThreshold = account.Type == "Omni Account" ? account.Balance + 100 : account.Balance;

            if (balanceThreshold >= amount)
            {
                return true;
            }

            return false;
        }

        private void HandleInsufficientBalance(double amount)
        {
            try
            {
                switch (account.Type)
                {
                    case "Investment Account":
                    case "Omni Account":
                        MessageBox.Show($"Account doesn't have sufficient balance. Failed transaction fee charged ${account.GetFailedTransactionFee()}!");
                        account.ChargeFailedTransactionFee();
                        break;
                    default:
                        MessageBox.Show("Account doesn't have sufficient balance!");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
            }

        }

        private void interestButton_Click(object sender, EventArgs e)
        {
            enterAmountTextBox.Clear();

            showAccountsInfoListBox.Items.Clear();

            try
            {
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
                        MessageBox.Show($"Interest amount ${interest_earned} Added Successfully on your balance ${account.Balance}!");
                        account.AddInterest(interest_earned);
                    }
                    else
                    {
                        MessageBox.Show($"No interest earned on ${account.Balance}!");
                    }
                    showAccountsInfoListBox.Items.Add(account.AccountInfo());
                }
                enterAmountTextBox.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application
        }
    }
}
