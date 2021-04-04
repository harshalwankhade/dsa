using System;

namespace ArrayRotation
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Program obj =new Program();
            
            //Method-1   using temp array            
            //Method-2   using temp variable
            //Method-3   using Juggling Array Algorithm
            //Method-4   using Block Swap Algorithm
            int shiftVal=0;
            var array2_1=new int[] {10,12,14,18,21,85,99};
            obj.DisplayOutput(array2_1);
            Console.WriteLine("------------------");
            shiftVal=3;
            array2_1=obj.Method1(array2_1, shiftVal);            
            Console.WriteLine($"Shifting by {shiftVal}");
            obj.DisplayOutput(array2_1);            
            Console.WriteLine("************************");
            var array2_2=new int[] {};
            obj.DisplayOutput(array2_2);
            Console.WriteLine("------------------");
            shiftVal=3;
            array2_2=obj.Method1(array2_2, shiftVal);
            Console.WriteLine($"Shifting by {shiftVal}");            
            obj.DisplayOutput(array2_2);            
            Console.WriteLine("************************");
            var array2_3=new int[] {10,12};
            obj.DisplayOutput(array2_3);
            Console.WriteLine("------------------");
            shiftVal=2;
            array2_3=obj.Method1(array2_3, shiftVal);
            Console.WriteLine($"Shifting by {shiftVal}");            
            obj.DisplayOutput(array2_3);            
            Console.WriteLine("************************");
            var array2_4=new int[] {10,12,-23,45,4,0};
            obj.DisplayOutput(array2_4);
            Console.WriteLine("------------------");
            shiftVal=50554;
            array2_4=obj.Method1(array2_4, shiftVal);
            Console.WriteLine($"Shifting by {shiftVal}");            
            obj.DisplayOutput(array2_4);            
            Console.WriteLine("************************");

        }
        public void DisplayOutput(int [] collection)
        {            
            foreach (var item in collection)
            {
                Console.Write(item+" ");                
            }
            Console.WriteLine();            
        }
    }
}
