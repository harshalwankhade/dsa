using System;

namespace ArrayRotation
{
    partial class Program
    {        
        public int[] Method1(int [] collection, int d)
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
            int [] finalArray=new int[n];
            int k=n-d;
            for (int i = 0; i < d; i++)
            {
                finalArray[k]=collection[i];
                k++;
            }
            k=0;
            for (int i = d; i < n; i++)
            {
                finalArray[k]=collection[i];
                k++;
            }
            return finalArray;
        }
    }
}
