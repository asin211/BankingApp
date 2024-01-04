namespace BankingApp
{
    public abstract class Account
    {
        public Customer AssociatedCustomer { get; set; }

        public double GetFailedTransactionFee()
        {
            double failedTransactionFee = 10;
            if (AssociatedCustomer != null && AssociatedCustomer.Staff)
            {
                return failedTransactionFee * .5;
            }
            else
            {
                return failedTransactionFee;
            }
        }

        private static int count = 1001; //Static Id for autoincrement
        public int AccountId { get; private set; }
        public string Type { get; protected set; }

        public double Balance { get; protected set; }

        public void Deposit(double amount) {
            if(amount <= 0)
            {
                throw new NegativeInputException();
            }
            Balance += amount;
        } 

        //Abstract Method to be used by child classes
        public abstract void Withdraw(double amount);

        public abstract double CalculateInterest(); // created this abstract method in this class to have access in other classes as well

        public void AddInterest(double earnedInterest)
        {
            Balance += earnedInterest;
        }

        public abstract double CalculateFailedTransactionFee();

        public abstract void ChargeFailedTransactionFee();

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

    // Inheritance
    public class EverydayAccount : Account
    {
        public EverydayAccount(double balance) : base(balance)
        {
            Type = "Everyday Account";
        }

        // Implementation for the abstract method
        public override void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new NegativeInputException();
            }
            else if (amount > Balance)
            {
                throw new InsufficientFundsException();
            } else
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                }
            }
        }

        public override double CalculateFailedTransactionFee()
        {
            return 0;
        }

        // created method to avoid error from parent abstract method
        public override void ChargeFailedTransactionFee() => Balance -= CalculateFailedTransactionFee();


        public override string AccountInfo() => $"Account Id: {AccountId}, Type: {Type}, Balance: {Balance}";

        public override double CalculateInterest() => 0; // created method to avoid error from parent abstract method
    }
    public class InvestmentAccount : Account
    {

        public double InterestRate = 0.04;

        public InvestmentAccount(double balance) : base(balance)
        {
            Type = "Investment Account";
        }

        // Overring Methods
        public override double CalculateInterest() => Balance * InterestRate;

        // Implementation for the abstract method
        public override void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new NegativeInputException();
            }
            else if (amount > Balance)
            {
                throw new InsufficientFundsException();
            }
            else
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                }
            }
        }

        public override double CalculateFailedTransactionFee()
        {
            return GetFailedTransactionFee(); ;
        }

        public override void ChargeFailedTransactionFee() => Balance -= CalculateFailedTransactionFee();



        // Account Info
        public override string AccountInfo() => $"Account Id: {AccountId}, Type: {Type}, Balance: {Balance}";
    }

    public class OmniAccount : Account
    {
        public double InterestRate = 0.04;
        public double OverDraftLimit = 100;

        public OmniAccount(double balance) : base(balance)
        {
            Type = "Omni Account";
        }

        // Implementation of abstract method
        public override double CalculateInterest() => Balance > 1000 ? (Balance - 1000) * InterestRate : 0;

        // Implementation for the abstract method
        public override void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new NegativeInputException();
            }
            else if (amount > (Balance + OverDraftLimit))
            {
                throw new InsufficientFundsException();
            }
            else
            {
                if ((Balance + OverDraftLimit) >= amount)
                {
                    Balance -= amount;
                }
            }
        }

        public override double CalculateFailedTransactionFee()
        {
            return GetFailedTransactionFee();
        }

        public override void ChargeFailedTransactionFee() => Balance -= CalculateFailedTransactionFee();


        public override string AccountInfo() => $"Account Id: {AccountId}, Type: {Type}, Balance: {Balance}";
    }
}
