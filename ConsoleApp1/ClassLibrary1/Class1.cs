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
            List<int> primes = new List<int>();
            for (int i = 1; i <= N; i++)
                primes.Add(i);
            return primes;
        }
        public  void SequenceDisplay(int N)
        {
            if (N == 0)
                Console.WriteLine("N>0!");
            Console.WriteLine("{0}\n", String.Join(",", Sequence(N)));
        }
    }
}
