using System;

namespace ArrayRotation
{
    partial class Program
    {        
        public int[] Method2(int [] collection, int d)
        {   
            int n=collection.Length;
            if (d<1 || n==0 || d==n)
            {
                return collection;
            }
            else if(d>n)
            {
                d=d%n;
            }
            int i=0;
            while (true)
            {
                if(d+i==n)
                { break; }
                //swap (d+i)th and (i)th elements
                int temp=collection[d+i];
                collection[d+i]=collection[i];
                collection[i]=temp;
                i++;
            }
            i=d+1;
            if (i<n)
            {
             while (true)
            {
                if(i==n-1)
                { break; }
                //swap (d+i)th and (i)th elements
                int temp=collection[n-1];
                collection[n-1]=collection[i];
                collection[i]=temp;
                i++;
            }   
            }                                         
            return collection;
        }
    }
}
