﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapUsingNewK
{
   
    class NumberManipulator
    {
        public void swap(int x, int y)
        {
            int z;

            z = x;
            x = y; 
            y = z; 
        }
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
          

            /* local variable definition */

            int a = 100;
            int b = 200;

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);

            /* calling a function to swap the values */

            n.swap(a, b);

            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);
            Console.ReadLine();
        }
    }
}
