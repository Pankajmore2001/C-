using System;
using System.Linq;
namespace LinqProject{
    public class Program
    {
        static void Main()
        {
            int[] arr = new int[] {12,22,66,76,90,89,99,101,45,77};

            int count=0;
            for(int i =0;i<arr.Length;i++)
            {
                if(arr[i]>40)
                {
                    count++;
                }
            }
            
            int[] brr = new int[count];
            int index = 0 ;
            for(int i =0;i<arr.Length;i++)
            {
                if(arr[i]>40)
                {
                    brr[index++]=arr[i];
                }
            }
            Console.WriteLine("Array with values greater than 40:");
            foreach(int i in brr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Array.Sort(brr);
            Console.WriteLine("Array After sort:");
            foreach(int i in brr)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
            Array.Reverse(brr);
            Console.WriteLine("Array After Desending sort:");
            foreach(int i in brr)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
            

            // LINQ Code to demonstate how to use linq to reduce code size
            Console.WriteLine("Array elements greater than 40 using LINQ:");
            var Crr = from i in arr where i>40 orderby i descending select i;
            foreach(int i in Crr)
            {
                Console.Write(i+" ");
            }


        }
    }
}