using System;
using System.Collections.Generic;
using System.Text;

namespace MS_70_483
{
    class Question1_5
    {
        public static void ExceptionTraining()
        {
            try
            {
                throw null;
            }
            // Option.A
/*
            catch (Exception ex)
            {
                ExceptionLogger.LogException(ex);
                throw;
            }
*/
            // Option.B
/*
            catch (Exception ex)
            {
                ExceptionLogger.LogException(ex);
                throw ex;
            }
*/
            // Option.C
/*
            catch
            {
                ExceptionLogger.LogException(new Exception());
                throw;
            }
*/
            // Option.D

            catch
            {
                var ex = new Exception();
                throw ex;
            }

        }

    }

    class ExceptionLogger: Exception
    {
        public static void LogException(Exception ex)
        {
            Log(ex);
        }

        public ExceptionLogger() { }

        public ExceptionLogger(string message) : base(message) { }
 
        public ExceptionLogger(string message, Exception inner) : base(message) { }

        private static void Log(Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}
