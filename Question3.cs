/*using System;
using System.Collections.Generic;
using System.Text;

namespace MS_70_483
{
    public class Question3
    {

        public void start()
        {
            try
            {
                this.DoWork();
            }
            catch (ContosoValidationException ex)
            {
                //Log(ex);
            }
            catch (ContosoException ex)
            {
               // Log(ex);
            }
            catch (Exception ex)
            {
                //Log(ex);
            }
        }
        

        public bool DoWork()
        {
            return true;
        }
    }



    public class ContosoException : Exception
    {
 *//*       public ContosoNotFoundException()
        {
            ContosoDbException();
        }

        public ContosoNotFoundException(string message)
            :base(message) { }

        public Log(Exception ex)
        {
            Console.WriteLine($"ContosoException: {ex}");
        }
        *//*
    }

    public  class ContosoDbException : ContosoException
    {

        public void Log(ContosoException ex)
        {
            Console.WriteLine($"ContosoDbException: {ex}");
        }
    }

    public class ContosoValidationException : ContosoException
    { 
        public void Log(ContosoException ex)
        {
            Console.WriteLine($"ContosoValidationException: {ex}");
        }
    }

}
*/