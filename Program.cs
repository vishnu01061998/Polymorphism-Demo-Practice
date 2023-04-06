using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Demo_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arithmetic arithmetic = new Arithmetic();
            arithmetic.Add();
            arithmetic.Add(10);
            arithmetic.Add(20 , 10);
            arithmetic.Add(10.5f , 20);
            arithmetic.Add(10.5f, 20.5f);
            arithmetic.Add(20.5f, 10);

        }
    }
}
