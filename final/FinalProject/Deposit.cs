public class Deposit : Transaction
    {
        private int _depositAmmount;

        public int AddMoney(int balance)
        {
            Console.Clear();
            _originalBalance = balance;
            Console.Write("How much would you like to deposit?:");
            _depositAmmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Your deposit was successful.");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            _modifiedBalance = _depositAmmount + _originalBalance;
            return _modifiedBalance;
            Console.Clear();
        }
    }