using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Demo_Practice
{
    internal class Arithmetic
    {
        public void Add()
        {
            Console.WriteLine("method with 0 argument");
        }

        public void Add(int num1) 
        {
            Console.WriteLine("method with 1 argument");
        }

        public void Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Addition of two integers type value="+ result);

        }
        public void Add(float num1, float num2)
        {
            float result = num1 + num2;
            Console.WriteLine("Addition of two float type value =" + result);

        }
        public void Add(int num1,float num2)
        {
            float result = num1 + num2;
            Console.WriteLine("Addition of one integers and one float type value=" + result);

        }
        public void Add(float num1, int num2)
        {
            float result = num1 + num2;
            Console.WriteLine("Addition of one float and one integers type value= " + result);
        }
    }


}
