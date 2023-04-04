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