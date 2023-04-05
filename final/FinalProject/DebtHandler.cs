public class DebtHandler : Transaction
    {
        private int _debt;
        private int _borrowAmmount;
        private int _paymentAmmount;

        public int MakePayment(int debt)
        {
            Console.Clear();
            _debt = debt;
            Console.Write("How much would you like to pay?:");
            _paymentAmmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Thank you for your payment.\nPress enter to continue");
            Console.ReadLine();
            _modifiedBalance = _debt + _paymentAmmount;
            return _modifiedBalance;
        }

        public int BorrowMoney(int debt)
        {
            Console.Clear();
            _debt = debt;
            Console.Write("How much would you like to borrow?:");
            _borrowAmmount = int.Parse(Console.ReadLine());
            Console.WriteLine("You have borrowed money. You better pay it back.\nPress enter to continue");
            _modifiedBalance = _debt - _borrowAmmount;
            Console.ReadLine();
            return _modifiedBalance;
        }
    }