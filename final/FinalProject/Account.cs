public abstract class Account
    {
        private string _username;
        private string _password;
        private int _balance = 0;
        private int _debt = 0;

        public void SetUsername(string username)
        {
            _username = username;
        }

        public void SetPassword(string password)
        {
            _password = password;
        }

        public void DisplayBalance()
        {
            Console.Clear();
            Console.WriteLine($"your current balance is {_balance}");
            Console.WriteLine($"your current debt is {_debt}");
            Console.WriteLine("press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }

        public int GetBalance()
        {
            return _balance;
        }

        public void UpdateBalance(int newBalance)
        {
            _balance = newBalance;
        }

        public void Deposit()
        {
            Deposit Deposit1 = new Deposit();
            _balance = Deposit1.AddMoney(_balance);
        }

        public void Withdraw()
        {
            Withdrawel Withdrawel1 = new Withdrawel();
            _balance = Withdrawel1.SubtractMoney(_balance);
        }

        public virtual void TakeDebt()
        {
            DebtHandler Debt1 = new DebtHandler();
            _debt = Debt1.BorrowMoney(_debt);
        }

        public virtual void PayDebt()
        {
            DebtHandler Debt2 = new DebtHandler();
            _debt = Debt2.MakePayment(_debt);
        }

        public string GetPassword()
        {
            return _password;
        }
    }