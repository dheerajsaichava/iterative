using System;

namespace iterative
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("how many years of experience do u have in professional programming?");
            string year = Console.ReadLine();
                int years = int.Parse(year);
            //Console.ReadKey(true);
            
                for (int i = 0; i <= years; i++)
                {
                    Console.WriteLine("you have" + i.ToString() + "years of experience ");
                    

            }
            Console.ReadKey(true);
        }
        }
}
