using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KugaevskijSD.Sprint0.Task4.V0.Lib;
namespace Tyuiu.KugaevskijSD.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Class1.Addition(1, 5));
            Console.WriteLine(Class1.Subtraction(15, 5));
            Console.WriteLine(Class1.Multiplication(10, 10));
            Console.WriteLine(Class1.Division(5, 5));
            Console.ReadKey();
        }
    }
}