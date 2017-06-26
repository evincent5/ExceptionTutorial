using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace ExceptionTutorial
{
    class InnerException
    {
        public static void Inner()
        {
            try  
            {
                Console.WriteLine("Enter a number: ");
                int FN = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter a number: ");
                int SN = Int32.Parse(Console.ReadLine());

                int Result = FN / SN;
                Console.WriteLine("Result: " + Result);
            }
            catch (Exception ex)
            {
                string filePath = @"C:\Users\Emmanuel\Documents\Sample Files\Log.txt";
                if (File.Exists(filePath))
                {
                    StreamWriter streamWriter = new StreamWriter(filePath);
                    streamWriter.WriteLine(ex.GetType().Name);
                    Console.WriteLine();
                    streamWriter.WriteLine(ex.Message);
                    streamWriter.Close();
                    Console.WriteLine("There is a problem please try later");
                }
                else
                {
                    throw new FileNotFoundException(filePath + "is not present", ex);
                }
            }
        }




    }
}
