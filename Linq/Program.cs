using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =  { 5, 4, 1, 3, 9, 8 };


             List<string> nameList =new List<string>(){"Pranaya", "Kumar" };
           
            IEnumerable<char> querySyntax = from str in nameList
                                            from ch in str
                                            select ch;
            foreach (char c in querySyntax)
            {
                Console.Write(c + " ");
            }
            Console.ReadKey();




            //Step1: Data Source
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            //Step2: Query
            //LINQ Query using Query Syntax to fetch all numbers which are > 5
            var QuerySyntax = from obj in numbers //Data Source
                              where obj > 5 //Condition
                              select obj; //Selection
            //Step3: Execution
            foreach (var item in QuerySyntax)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();







            var res = from a in numbers where a < 5 orderby a select a;
            foreach (int i in res)
            Console.WriteLine(i);
            Console.WriteLine("\n");


            int[] nums = new int[] { 0, 1, 2 };
            var ress = from a in nums where a < 1 orderby a select a;
            foreach (int i in ress)
                Console.WriteLine(i);



            /*   var numsPlusOne = from n in numbers select n;
               for(int i=0; i<numbers.Length; i++)
               {
                   Console.WriteLine(numbers[i]);
               }
               foreach (var i in numsPlusOne)
               {
                   Console.WriteLine(i.ToString());
               }

               */

        }
    }
}
