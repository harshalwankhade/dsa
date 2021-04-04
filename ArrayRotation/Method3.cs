using System;

namespace ArrayRotation
{
    partial class Program
    {        
        public int[] Method3(int [] collection, int d)
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
            int j,k,temp;
            int gcdVal=GetGCD(d,n);
            for (int i = 0; i < gcdVal; i++)
            {
                temp=collection[i];
                j=i;
                while (true)
                {
                    k=j+d;
                    if (k>=n)
                    {   k=k-n;  }    
                    if (k==i)
                    {   break;  }
                    collection[j]=collection[k];
                    j=k;
                }
                collection[j]=temp;
            }
            return collection;
        }

        /// this method returns GCD of two i/p nos by using recursion
        public int GetGCD(int a, int b)
        {
            if (b==0)
            {   return a;    }
            return GetGCD(b,a%b);
        }
    }
}
