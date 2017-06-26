using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReadingException.Reader();
            //    try
            //    {
            //        Console.WriteLine("Enter a number: ");
            //        int FN = Int32.Parse(Console.ReadLine());

            //        Console.WriteLine("Enter a number: ");
            //        int SN = Int32.Parse(Console.ReadLine());

            //        Console.WriteLine("Enter a number: ");
            //        int TN = Int32.Parse(Console.ReadLine());

            //        Result(FN, SN, TN);
            //        Console.ReadLine();
            //    }
            //    catch(Exception ex)
            //    {
            //        Console.WriteLine(ex.StackTrace);
            //    }
            //}




            //private static void Result(int i, int j, int k)
            //{
            //    int Result = (i / j)*k;
            //    Console.WriteLine("Result: " + Result);

        }
    }
}
