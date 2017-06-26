using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTutorial
{

    public static class FileReadingException

    {
        public static void Reader()
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"C:\Users\Emmanuel\Documents\Sample Files\Data1.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine("Please check if the the file exist {0} exist", ex.FileName);
                Console.WriteLine();
                //Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine();
                //Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();

                }
                Console.WriteLine("Finally Block");

            }


        }


    }
}
