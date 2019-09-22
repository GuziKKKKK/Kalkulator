using System;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while(loop)
            {
                Console.WriteLine("1. Subtract");
                Console.WriteLine("2. Add");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Exit");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        loop = false;
                        break;
                }
            }
        }
    }
}
