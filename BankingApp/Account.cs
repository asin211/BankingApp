using BankingApp;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BankingApp
{
    public abstract class Account
    {
        private static int count = 1001; //Static Id for autoincrement
        public int AccountId { get; set; }
        public string Type { get; set; }

        public double Balance { get; set; }

        public void AddInterest(double earnedInterest)
        {
            Balance += earnedInterest;
        }

        public abstract double CalculateInterest(); // created this abstract method in this class to have access in other classes as well

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        //Abstract Method to be used by child classes
        public abstract void Withdraw(double amount);

        public abstract string AccountInfo();

        //Constructor
        public Account(double balance)
        {
            AccountId = count;
            Balance = balance;

            count++;
        }

        //Overiding ToString Method
        public override string ToString()
        {
            return Type;
        }
    }

    // Inherotance
    public class EverydayAccount : Account
    {
        // Implementation for the abstract method
        public override void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                MessageBox.Show($"${amount} withdrawn successfully from Everyday Account!");
            }else
            {
                MessageBox.Show("Account doesn't have sufficient balance!");
            }
        }

        public override string AccountInfo()
        {
            return $"Account Id: {AccountId}, Type: {Type}, Balance: {Balance}";
        }

        public override double CalculateInterest() // created blank method to avoid error from parent abstract method
        {
            //No interest for this account for now
            return 0;
        }
        public EverydayAccount(double balance) : base(balance)
        {
            Type = "Everyday Account";
            Balance = balance;
        }
    }
    public class InvestmentAccount : Account
    {
        public double InterestRate = 0.04;

        public double FeeForFailedTransaction = 10;

        // Overring Methods
        public override double CalculateInterest()
        {
            double interestEarned = Balance * InterestRate;
            return interestEarned;
        }

        // Account Informations
        public override string AccountInfo ()
        {
            return $"Account Id: {AccountId}, Type: {Type}, Interest Rate: {InterestRate}, Failed Transaction Fee: {FeeForFailedTransaction}, Balance: {Balance}";
        }

        // Implementation for the abstract method
        public override void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                MessageBox.Show($"${amount} withdrawn successfully from Investment Account!");

            }
            else
            {
                MessageBox.Show("Account doesn't have sufficient balance! Failed transaction fee charged $10!");
                Balance -= FeeForFailedTransaction;
            }
        }
        public InvestmentAccount(double balance) : base(balance)
        {
            Type = "Investment Account";
            Balance = balance;
        }
    }

    public class OmniAccount : Account
    {
        public double InterestRate = 0.04;
        public double FeeForFailedTransaction = 10;
        public double OverDraftLimit = 100;

        public OmniAccount(int balance) : base(balance)
        {
            Type = "Omni Account";
            Balance = balance;
        }

        // Implementation of abstract method
        public override double CalculateInterest()
        {
            if (Balance > 1000)
            {
                double interestEarned = (Balance - 1000) * InterestRate;
                return interestEarned;
            }
            else
            {
                return 0;
            }
        }

        // Implementation for the abstract method
        public override void Withdraw(double amount)
        {
            if ((Balance + OverDraftLimit) >= amount)
            {
                Balance -= amount;
                MessageBox.Show($"${amount} withdrawn successfully from Omni Account!");


            }
            else
            {
                MessageBox.Show("Account doesn't have sufficient balance including overdraft limit of $100! Failed transaction fee charged $10!");
                Balance -= FeeForFailedTransaction;
            }
        }
        public override string AccountInfo()
        {
            return $"Account Id: {AccountId}, Type: {Type}, Interest Rate: {InterestRate} (No interest upto $1000), Overdraft Limit: {OverDraftLimit}, Failed Transaction Fee: {FeeForFailedTransaction}, Balance: {Balance}";
        }
    }
}