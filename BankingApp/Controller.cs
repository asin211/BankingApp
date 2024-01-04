using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    internal class Controller
    {
        private List<Customer> customersList = new List<Customer>();

        //Property with a getter to access customerList
        public IReadOnlyList<Customer> CustomersList => customersList.AsReadOnly();

        public void AddCustomer(Customer customer)
        {
            customersList.Add(customer);
        }

        public void UpdateCustomer(Customer updateCustomer)
        {
            Customer customerToUpdate = FindCustomerById(updateCustomer.CustomerId);
            if (customerToUpdate != null)
            {
                customerToUpdate.Name = updateCustomer.Name;
                customerToUpdate.Phone = updateCustomer.Phone;
                customerToUpdate.Staff = updateCustomer.Staff;
            }
        }

        public void DeleteCustomer(Customer deleteCustomer)
        {
            Customer customerToDelete = FindCustomerById(deleteCustomer.CustomerId);
            if (customerToDelete != null)
            {
                customersList.Remove(customerToDelete);
            }
        }

        private Customer FindCustomerById(int customerId)
        {
            return customersList.FirstOrDefault(customer => customer.CustomerId == customerId);
        }

        /*
        //Add Method to add an account to Accounts List (This method can be moved here as well from customer class, code to access and modify data has also been provided in form.cs)
        public void AddAccount(Customer customer, Account account)
        {
            customer.Accounts.Add(account);
        }
       */
    }
}
