using System;

namespace Lesen3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите умножаемое число");
            string a = Console.ReadLine();
            Console.WriteLine("Введите множитель");
            string b = Console.ReadLine();
            int c = Convert.ToInt32(a);
            int d = Convert.ToInt32(b);
            int result;
            Kal kal = new Kal();
            result = kal.Kalculator(c,d);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
