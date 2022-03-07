using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMethots
{
    internal class Program
    {
        static int FibonacciSerisi(int sayi)
        {
            if (sayi == 0)
                return 0;
            else if(sayi == 1)
        return 1;
    else
                return FibonacciSerisi(sayi - 1) + FibonacciSerisi(sayi - 2);
        }
        static void Main(string[] args)
        {
            
        }
    }
}
