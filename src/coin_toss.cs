using System;

namespace Coin_Toss
{
    class coin_toss
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------Coin Toss----------------------------------------");
            Console.WriteLine("--------------------------------------v1.0-------------------------------------------");

            Random random = new Random();
            Console.WriteLine("What's your guess?");
            Console.WriteLine("1.Heads");
            Console.WriteLine("2.Tails");
            Console.WriteLine("Enter a number: ");
            string num = Console.ReadLine();
            int num1 = Convert.ToInt32(num);

            if (num1 == 1) {
                Console.WriteLine("You guessed Heads");
            }
            else if (num1 == 2)
            {
                Console.WriteLine("You guessed Tails");
            }

            int randomno = random.Next(1,3);
            if (randomno == 1 ) {
                Console.WriteLine("RESULT: Heads");
            }
            else if (randomno == 2 )
            {
                Console.WriteLine("RESULT: Tails");
            }

            Console.WriteLine("Do you want to flip again, press y");
            string ask = Console.ReadLine();

            while (ask == "y")
            {
                Main(args);
            }

            Console.ReadLine();
        }
    }
}
