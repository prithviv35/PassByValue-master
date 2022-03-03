using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValue
{
    internal class Program
    {
        public static void Addition(out int k)
        {
            k = 30;
            k += k;
        }
        public void swapByValue(int x, int y)
        {
            int temp;

            temp = x; /* save the value of x */
            x = y;    /* put y into x */
            y = temp; /* put temp into y */
        }
        public void swapByRef(ref int x, ref int y)
        {
            int temp;

            temp = x; /* save the value of x */
            x = y;    /* put y into x */
            y = temp; /* put temp into y */
        }
        static void Main(string[] args)
        {
            Program n = new Program();

            int i = 100;
            int j = 200;

            Console.WriteLine("Before swap, value of i : {0}", i);
            Console.WriteLine("Before swap, value of j : {0}", j);

            /* calling a function to swap the values */
            n.swapByValue(i, j);

            Console.WriteLine("After swap, value of i : {0}", i);
            Console.WriteLine("After swap, value of j : {0}", j);

            /* local variable definition */
            int a = 100;
            int b = 200;

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);

            /* calling a function to swap the values */
            n.swapByRef(ref a, ref b);

            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);

            // Declaring variable
            // without assigning value
            int k;

            // Pass variable i to the method
            // using out keyword
            Addition(out k);

            // Display the value i
            Console.WriteLine("The addition of the value is: {0}", k);

            Console.ReadLine();


      } 
    }
}
