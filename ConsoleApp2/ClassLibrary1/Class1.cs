using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public void Square(int a)
        {
            double enter = a / 2 + 1;
            for (int row = 1; row <= a; row++)
            {
                for (int k = 1; k <= a; k++)
                {
                    if (row == enter && k == enter) Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
