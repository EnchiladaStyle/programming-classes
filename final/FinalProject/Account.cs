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

        public int getBalance()
        {
            return _balance;
        }

        public virtual void displayDebt()
        {
            Console.WriteLine(_dept);
        }

        public void updateBalance(int newBalance)
        {
            _balance = newBalance;
        }
    }