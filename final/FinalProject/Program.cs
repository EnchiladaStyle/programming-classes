using System;

class Program
{
    static void Main(string[] args)
    {
        
        string passwordAttempt;
        bool end = false;

        Bank Bank1 = new Bank();
        Banker Banker1 = new Banker();
        Customer Customer1 = new Customer();
        Child Child1 = new Child();
        Account currentUser;

        Banker1.SetPassword("12345");
        Customer1.SetPassword("54321");
        Child1.SetPassword("child");
    
    do
    {
        Console.Clear();
        bool ChangeUser = false;
        Console.WriteLine();
        Console.WriteLine("Welcome to the Bank.");
        Console.WriteLine("Please select your account status.\n1: Banker\n2: Customer\n3: Child");
        Console.Write("Enter the number for your status here: ");
        string answer = Console.ReadLine();

        if (answer == "1")
        {
            
            currentUser = Banker1;
            Console.WriteLine("\nPlease enter Your password. (The banker's password is 12345)");
            passwordAttempt = Console.ReadLine();
            if (passwordAttempt == currentUser.GetPassword())
            {
                do
                {
                    Console.Clear();
                    currentUser = Banker1;
                    Console.WriteLine();
                    Console.WriteLine("Hello Banker.");
                    Console.WriteLine("1: Read Reviews\n2: View Balance\n3: Deposit Money\n4: Withdraw Money\n5: Take out debt\n6: Pay debt\n7: Change User");
                    answer = Console.ReadLine();

                    if (answer == "1")
                    {
                        List<string> reviews = Bank1.GetReviews();
                        Banker1.ReadReviews(reviews);
                    }
                    else if (answer == "7")
                    {
                        ChangeUser = true;
                    }
                    else 
                    {
                    CommonMethods(answer, currentUser, ChangeUser);
                    }
                } while (ChangeUser == false);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("incorrect password\npress enter to continue");
                Console.ReadLine();
            
            }
        }

        else if (answer == "2")
        {
            currentUser = Customer1;
            Console.WriteLine("\nPlease enter Your password. (The customer's password is 54321)");
            passwordAttempt = Console.ReadLine();
            if (passwordAttempt == currentUser.GetPassword())
            {
                do
                {
                    Console.Clear();
                    
                    Console.WriteLine();
                    Console.WriteLine("Hello Customer.");
                    Console.WriteLine("1: Write Review\n2: View Balance\n3: Deposit Money\n4: Withdraw Money\n5: Take out debt\n6: Pay debt\n7: Change User");
                    answer = Console.ReadLine();
                    if (answer == "1")
                    {
                    
                        Bank1.AddToReviews(Customer1.WriteReview());
                    }
                    else if (answer == "7")
                    {
                        ChangeUser = true;
                    }
                    else 
                    {
                        CommonMethods(answer, currentUser, ChangeUser);
                    }
                } while (ChangeUser == false);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("incorrect password\npress enter to continue");
                Console.ReadLine();
            
            }
        }

        else if (answer == "3")
        {
            
            currentUser = Child1;
            Console.WriteLine("\nPlease enter Your password. (The child's password is child)");
            passwordAttempt = Console.ReadLine();
            if (passwordAttempt == currentUser.GetPassword())
            {
                do
                {
                    Console.Clear();
                    
                    Console.WriteLine();
                    Console.WriteLine("Hello Child");
                    Console.WriteLine("1: take Lolipop\n2: View Balance\n3: Deposit Money\n4: Withdraw Money\n5: Take out debt\n6: Pay debt\n7: Change User");
                    answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        Console.WriteLine("\nyummy lolipop\npress enter to continue");
                        Console.ReadLine();
                    }
                    else if (answer == "7")
                    {
                        ChangeUser = true;
                    }
                    else 
                    {
                        CommonMethods(answer, currentUser, ChangeUser);
                    }
                } while (ChangeUser == false);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("incorrect password\npress enter to continue");
                Console.ReadLine();
            
            }

        }
    } while (end == false);
    }

    static void CommonMethods(string answer, Account currentUser, bool ChangeUser)
    {
        if (answer == "2")
        {
            currentUser.DisplayBalance();
        }

        else if (answer == "3")
        {
            currentUser.Deposit();

        }

        else if (answer == "4")
        {
            currentUser.Withdraw();
        }

        else if (answer == "5")
        {
            currentUser.TakeDebt();
        }

        else if (answer == "6")
        {
            currentUser.PayDebt();
        }
    }
}