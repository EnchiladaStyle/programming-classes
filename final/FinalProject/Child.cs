

    

    public class Child : Account 
        {
            public override void TakeDebt()
        {
            Console.Clear();
            Console.WriteLine("You don't have sufficient priviledge to borrow money");
            Console.WriteLine("press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }

        public override void PayDebt()
        {
            Console.Clear();
            Console.WriteLine("You don't have sufficient priviledge to pay off debt");
            Console.WriteLine("press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
        }
