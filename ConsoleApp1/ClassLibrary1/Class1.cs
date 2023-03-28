using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static List<int> Sequence(int N)
        {
            List<int> var = new List<int>();
            for (int i = 1; i <= N; i++)
                var.Add(i);
            return var;
        }
        public  void SequenceDisplay(int N)
        {
            if (N == 0)
                Console.WriteLine("N>0!");
            Console.WriteLine("{0}\n", String.Join(",", Sequence(N)));
        }
    }
}
