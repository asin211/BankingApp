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

        private int customerId;
        private string name;
        private int phone;
        private bool staff;

        public int CustomerId 
        { 
            get { return customerId; }
            set { customerId = value; }
        }

        public string Name 
        { 
            get { return name; } 
            set { name = value; }
        }

        public int Phone 
        {
            get { return phone; }
            set { phone = value; }
        }

        public bool Staff 
        {
            get { return staff; }
            set { staff = value; } 
        }

        // List to store customer's accounts
        public List <Account> Accounts { get; private set; } // List to store different Accounts

        // Constructor
        public Customer (string name, int phone, bool staff = true ) 
        {
            CustomerId = customer_id++;
            Name = name;
            Phone = phone;
            Staff = staff;

            //Intialize the list of accounts
            Accounts = new List<Account>();
        }

        //Add Method for adding an account (Code provided to move in controller class (JUST IGNORE THIS METHOD), also can directly use .add and remove this method)
        // Only asked for creating 3 methods for controller class for customer for 2nd assignment: add, update, delete. (28 Nov 23 recording - 40:40 min)
        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }

        public override string ToString()
        {
           return $"Id: {CustomerId}, Name: {Name}, Phone: {Phone}, Staff: {(Staff ? "Yes" : "No")}";
        }
    }
}
