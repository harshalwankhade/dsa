using System;

namespace ArrayRotation
{
    partial class Program
    {        
        public int[] Method4(int [] collection, int d)
        {            
            int n=collection.Length;
            if (d<1 || n==0 || d==n)
            {
                return collection;
            }
            else  if(d>n)
            {
                d=d%n;
            }
            ReverseArray(collection, 0, d);
            ReverseArray(collection, d+1, n-1);
            ReverseArray(collection, 0, n-1);
            return collection;
        }

        public void ReverseArray(int[] collection, int startIndex, int finishIndex)
        {
            while (startIndex<=finishIndex)
            {
                //swap positions of startIndex and finishIndex of array 
                int temp=collection[startIndex];
                collection[startIndex]=collection[finishIndex];
                collection[finishIndex]=temp;
                startIndex++;
                finishIndex--;
            }
        }
    }
}
