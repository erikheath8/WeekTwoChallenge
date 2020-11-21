using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace weekTwoChallenge2
{
    class Greeter
    {
         public string FirstName { get; set; }
        public string getFirstName()
        {
            
            Console.WriteLine("Hello, Please enter your First Name....\n");
            FirstName = Console.ReadLine();
            Thread.Sleep(1000);
            return FirstName;
        }

        public void Greeting()
        {
            string greetFirst = FirstName;
            Console.WriteLine($"\nHello {greetFirst}.");
            Thread.Sleep(1500);
        }

         public void Greeting(string greetFirst)
        {
            Console.WriteLine($"\nHello {greetFirst}.");
            Thread.Sleep(1500);
        }


        public void Farewell()
        {
            string farFirstName = FirstName;
           Console.WriteLine($"\nGoodbye {farFirstName}.");
            Thread.Sleep(1500);
        }

        public void Farewell(string farFirstName)
        {
            Console.WriteLine($"\nGoodbye {farFirstName}.");
            Thread.Sleep(1500);
        }
       
        public void TimeDayGreet()
        {
            int hour = DateTime.Now.Hour;

            if (hour >= 1 && hour <= 12)
            {
                Console.WriteLine("\nGoodMorning.");
                Thread.Sleep(2500);
            }
            else if (hour >= 12 && hour <= 16)
            {
                Console.WriteLine("\nGood Afternoon.");
                Thread.Sleep(2500);
            }
            else if (hour >= 16 && hour <= 21)
            {
                Console.WriteLine("\nGood Evening.");
                Thread.Sleep(2500);
            }
            else if (hour >= 21 && hour <= 24)
            {
                Console.WriteLine("\nGood Night.");
                Thread.Sleep(2500);
            }

        }
    }
}
