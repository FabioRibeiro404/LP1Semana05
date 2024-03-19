using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            string str1 = args[0];
            int diceNum = int.Parse(str1);

            string str2 = args[1];
            int seed = int.Parse(str2);


            Random dice = new Random(seed);

            for (int i = 0; i < diceNum; i++)
            {
                result += dice.Next(1, 7);
            }
            Console.WriteLine(result);
        }
    }
}
