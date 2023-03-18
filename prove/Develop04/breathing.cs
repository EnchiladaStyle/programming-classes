 public class Breathing : Activity
    {
        
       
        public override void Welcome()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the breathing activity!\nThis activity will help you relax by guiding your breathing rhythm.");
            Console.WriteLine();
            
        }

        public void Breath(int duration)
        {
            Console.WriteLine("Get Ready...");
            SpinnerAnimation();            
            for (int i=0; i<duration/10; i++)
            {
                Console.WriteLine("Breath in...");
                for (int j=5; j>0; j--)
                {
                    Console.Write(j);
                    Thread.Sleep(1000);
                    Console.Write("\b");
                }
                Console.WriteLine("Breath Out...");
                for (int j=5; j>0; j--)
                {
                    Console.Write(j);
                    Thread.Sleep(1000);
                    Console.Write("\b");
                }
            }
        }
    }