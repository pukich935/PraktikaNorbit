using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            class1.Square(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
