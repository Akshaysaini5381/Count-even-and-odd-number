using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_even_and_odd_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size :");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            int evencount;
            evencount = 0;
            int oddcount;
            oddcount = 0;
            int ctr = 0;
            while (ctr<size)
            {
                Console.Write("Enter the array value {0}= " ,ctr+" ");
                arr[ctr] = int.Parse(Console.ReadLine());
                ctr++;
            }
            Console.Write("My array :");
            int ptr = 0;
            while (ptr<size)
            {
                Console.Write(" "+arr[ptr]);
                ptr++;
            }
            Console.WriteLine();
            int c=0;
            while (c<size)
            {
                if (arr[c]%2==0)
                {
                    evencount++;
                }
                c++;
            }
            Console.WriteLine("the even number :"+ evencount);
            Console.WriteLine();
            int od;
            od = 0;
            while (od<size)
            {
                if (arr[od]%2!=0)
                {
                    oddcount++;
                }
                od++;

            }
            Console.WriteLine("My odd number :"+oddcount);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
