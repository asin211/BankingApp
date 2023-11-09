using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class Customer
    {
        private static int customer_id = 101; // Static Id for customer id

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }

        public bool Staff { get; set; }

        // List to store customer's accounts
        public List <Account> Accounts { get; set; } // List to store different Accounts

        // Constructor
        public Customer (string name, int phone, bool staff = false ) 
        {
            CustomerId = customer_id;
            Name = name;
            Phone = phone;
            Staff = staff;

            //Intialize the list of accounts
            Accounts = new List<Account>();

            customer_id++; // Auto Increment ID
        }

        //Add Method to add an account to Accounts List
        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }
    }
}
