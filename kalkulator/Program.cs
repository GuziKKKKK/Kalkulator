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
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnozenie");
                Console.WriteLine("4. Dzielenie");
                Console.WriteLine("5. SQRT");
                Console.WriteLine("6. Exit");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 5:
                        loop = false;
                        break;
                }
            }
        }
    }
}
