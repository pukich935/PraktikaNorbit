﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            class1.SequenceDisplay(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
