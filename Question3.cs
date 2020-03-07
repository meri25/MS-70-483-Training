using System;
using System.Collections.Generic;
using System.Text;

namespace MS_70_483
{
    public class Question3
    {

        public void question3()
        {
            try
            {
                this.DoWork();
            }
            catch
            {

            }
        }
        

        public bool DoWork()
        {
            return true;
        }
    }



    public class ContosoException : System.Exception
    {
        static void Log(Exception ex)
        {
            Console.WriteLine($"ContosoException: {ex}");
        }

    }

    public  class ContosoDbException : ContosoException
    {
        static void Log(ContosoException ex)
        {
            Console.WriteLine($"ContosoDbException: {ex}");
        }
    }

    public class ContosoValidationException : ContosoException
    { 
        static void Log(ContosoException ex)
        {
            Console.WriteLine($"ContosoValidationException: {ex}");
        }
    }

}
