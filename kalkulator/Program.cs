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
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnozenie");

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
