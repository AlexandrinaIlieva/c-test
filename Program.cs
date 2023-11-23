using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Diskriminanta

            int a;
            int b;
            int c;
            int D;

            Console.WriteLine("Моля, въведете стойност на a");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Моля, въведете стойност на b");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Моля, въведете стойност на c");
            c = Convert.ToInt32(Console.ReadLine());

            D = b * b - 4 * a * c;

            Console.WriteLine(D);

            if (D > 0)
            {
                Console.WriteLine(D);
            }
            else if (D < 0)
                    {
                Console.WriteLine("Няма реални корени");
            }
            
        }
    }
}
