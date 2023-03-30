using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
    }

    public abstract class Account
    {
        private string _username;
        private string _password;
        private int _balance = 0;
        private int _dept = 0;

        public void setUsername(string username)
        {
            _username = username;
        }

        public void setPassword(string password)
        {
            _password = password;
        }

        public void displayBalance()
        {
            Console.WriteLine(_balance);
        }

        public virtual void displayDept()
        {
            Console.WriteLine(_dept);
        }
    }

    public class Banker : Account
    {
        public void countAllFunds()
        {

        }
    }

    public class Customer : Account
    {
        public void writeReview()
        {

        }
    }

    public class Child : Account 
    {
        public override void displayDept()
        {
            
        }
    }

    public class Transaction
    {
        private int _originalBalance;
        private int _modifiedBalance;
    }

    public class Deposit : Transaction
    {
        private int _depositAmmount;

        public void addMoney()
        {

        }
    }

    public class Withdrawel : Transaction
    {
        private int _withdrawAmmount;
    }

    public void subtractMoney()
    {

    }

    public class DeptHandler : Transaction
    {
        private int _dept;
        private int _borrowAmmount;
        private int _paymentAmmount;

        public void makePayment()
        {

        }

        public void BorrowMoney()
        {

        }
    }
}