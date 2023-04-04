using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        bool end = false;

        Bank Bank1 = new Bank();
        Banker Banker1 = new Banker();
        Customer Customer1 = new Customer();
        Child Child1 = new Child();
        Account currentUser;
    
    do
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Bank.");
        Console.WriteLine("Please select your account status.\n1: Banker\n2: Customer\n3: Child");
        Console.Write("Enter the number for your status here: ");
        string answer = Console.ReadLine();

        if (answer == "1")
        {
            currentUser = Banker1;
            Console.WriteLine();
            Console.WriteLine("Hello Banker.");
            Console.Write("1: Read Reviews\n2: View Balance\n3: Deposit Money\n4: Withdraw Money\n5: Take out debt\n6: Pay debt");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                List<string> reviews = Bank1.getReviews();
                Banker1.readReviews(reviews);
            }
            else 
            {
            commonMethods(answer, currentUser);
            }
        }

        else if (answer == "2")
        {
            currentUser = Customer1;
            Console.WriteLine();
            Console.WriteLine("Hello Customer.");
            Console.Write("1: Write Review\n2: View Balance\n3: Deposit Money\n4: Withdraw Money\n5: Take out debt\n6: Pay debt");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                Console.WriteLine("Please submit your review here: ");
                Bank1.addToReviews(Console.ReadLine());
            }
            else 
            {
                commonMethods(answer, currentUser);
            }
        }

        else if (answer == "3")
        {
            currentUser = Child1;
            Console.WriteLine();
            Console.WriteLine("Hello Child");
            Console.Write("1: take Lolipop\n2: View Balance\n3: Deposit Money\n4: Withdraw Money\n5: Take out debt\n6: Pay debt");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                Console.WriteLine("yummy lolipop");
            }
            else 
            {
                commonMethods(answer, currentUser);
            }

        }
    } while (end == false);
    }

    static void commonMethods(string answer, Account currentUser)
    {
        if (answer == "2")
        {
            currentUser.displayBalance();
        }

        else if (answer == "3")
        {
            int oldBalance = currentUser.getBalance();
            
        }

        else if (answer == "4")
        {

        }

        else if (answer == "5")
        {

        }

        else if (answer == "6")
        {

        }
    }
}