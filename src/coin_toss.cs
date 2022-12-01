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

            int randomno = random.Next(1,3);
            if (randomno == 1 ) {
                Console.WriteLine("Heads");
            }
            else if (randomno == 2 )
            {
                Console.WriteLine("Tails");
            }
        }
    }
}
