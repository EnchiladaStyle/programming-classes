 public class Withdrawel : Transaction
    {
        private int _withdrawAmmount;
    

    public int SubtractMoney(int balance)
    {
            Console.Clear();
            _originalBalance = balance;
            Console.Write("How much would you like to withdraw?:");
            _withdrawAmmount = int.Parse(Console.ReadLine());
            if ((_originalBalance - _withdrawAmmount)>= 0)
            {
                Console.WriteLine("Your withdrawel was successful.\nPress enter to continue");
                _modifiedBalance = _originalBalance - _withdrawAmmount;
                Console.ReadLine();
                Console.Clear();
                return _modifiedBalance;
            }

            else 
            {
                Console.WriteLine("Insufficient funds\npress enter to continue");
                Console.ReadLine();
                return _originalBalance;
            }
    }

    }