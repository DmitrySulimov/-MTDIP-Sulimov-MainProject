using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static int a, b, sum;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число а");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            b = Int32.Parse(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("Ваша сумма равна {0}", sum);
            Console.ReadKey();
        }
    }
}
