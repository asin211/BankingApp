using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class CustomerForm : Form
    {
        Controller controller = new Controller();

        Customer selectedCustomer;

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            showCustomersInfoListBox.Items.Clear();
            comboBoxIsStaff.SelectedIndex = 0;

            updateCustomerButton.Enabled = false;
            deleteCustomerButton.Enabled = false;
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            string name =customerNameTextBox.Text.Trim();

            bool staff = comboBoxIsStaff.Text == "Yes" ? true : false;

            //if (!string.IsNullOrEmpty(name) && name.Trim().Length > 0)
            if (IsValidName(name))
            {
                if (isValidIntegerNumber(customerPhoneTextBox.Text))
                {
                    int phone = int.Parse(customerPhoneTextBox.Text);

                    Customer new_customer = new Customer(name, phone, staff);
                    controller.AddCustomer(new_customer);

                    resetFormInputs();
                    MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else
                {
                    MessageBox.Show("Please emter a valid phone number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please emter a valid name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            selectedCustomer.Name = customerNameTextBox.Text.Trim();
            selectedCustomer.Staff = comboBoxIsStaff.SelectedIndex == 1 ? true : false;

            //if (!string.IsNullOrEmpty(selectedCustomer.Name) && selectedCustomer.Name.Trim().Length > 0)
            if (IsValidName(selectedCustomer.Name))
            {
                if (isValidIntegerNumber(customerPhoneTextBox.Text))
                {
                    selectedCustomer.Phone = int.Parse(customerPhoneTextBox.Text);


                    controller.UpdateCustomer(selectedCustomer);
                    resetFormInputs();
                    MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Please emter a valid phone number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please emter a valid name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            controller.DeleteCustomer(selectedCustomer);
            resetFormInputs();
            MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void showCustomersInfoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (showCustomersInfoListBox.SelectedIndex != -1)
            {
                selectedCustomer = (Customer)showCustomersInfoListBox.SelectedItem;
                customerNameTextBox.Text = selectedCustomer.Name;
                customerPhoneTextBox.Text = selectedCustomer.Phone.ToString();
                comboBoxIsStaff.SelectedIndex = selectedCustomer.Staff ? 1 : 0;
            }
            else
            {
                MessageBox.Show("No items selecetd");
            }
            enablDisableButtons();
        }

        private bool IsValidName(string name)
        {
            // Regex pattern to allow only letters with a space between the first name and surname
            string pattern = @"^[A-Za-z]+(?:\s[A-Za-z]+)?$";

            // Check if the input matches the pattern
            return Regex.IsMatch(name, pattern);
        }

        private bool isValidIntegerNumber(string num)
        {
            return int.TryParse(num, out _);
        }

        private void resetFormInputs()
        {
            customerNameTextBox.Clear();
            customerPhoneTextBox.Clear();
            comboBoxIsStaff.SelectedIndex = 0;

            showCustomersInfoListBox.Items.Clear();

            //showCustomersInfoListBox.Items.Add("Id\t\tName\t\tPhone\t\tStaff");
            //showCustomersInfoListBox.Items.Add("-------------------------------------------------------------------");
            foreach (var customer in controller.CustomersList)
            {
                showCustomersInfoListBox.Items.Add(customer);
            }

            //showCustomersInfoListBox.SelectedIndex = 0;   //just an example

            enablDisableButtons();
        }

        private void enablDisableButtons()
        {
            if (showCustomersInfoListBox.SelectedIndex != -1)
            {
                updateCustomerButton.Enabled = true;
                deleteCustomerButton.Enabled = true;
                addCustomerButton.Enabled = false;
            }
            else
            {
                updateCustomerButton.Enabled = false;
                deleteCustomerButton.Enabled = false;
                addCustomerButton.Enabled = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application
        }
    }
}
