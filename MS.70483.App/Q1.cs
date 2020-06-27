using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace MS._70483.App
{
    class Q1 : Question
    {
        private Question question;
        public Question Start(Question question)
        {
            this.question = question;
            switch (question.option)
            {
                case "a":
                    OptionA();
                    this.question.answer = "Wrong!";
                    return this.question;
                case "b":
                    OptionB();
                    this.question.answer = "Correct!";
                    return this.question;
                case "c":
                    OptionC();
                    this.question.answer = "Wrong!";
                    return this.question;
                case "d":
                    OptionD();
                    this.question.answer = "Wrong!";
                    return this.question;
                default:
                    return this.question;
            }
        }

        private static void OptionA()
        {
            // #define DEBUG
            Console.WriteLine("Entering debug mode");
            // #define RELEASE
            Console.WriteLine("Entering release mode");
        }

        private static void OptionB()
        {
#if (DEBUG)
            Console.WriteLine("Entering debug mode");
#else
            Console.WriteLine("Entering release mode");
#endif
        }
        private static void OptionC()
        {
            #region DEBUG
            Console.WriteLine("Entering debug mode");
            #endregion
            #region RELEASEs
            Console.WriteLine("Entering debug mode");
            #endregion
        }
        private static void OptionD()
        {
            if (System.Reflection.Assembly.GetExecutingAssembly().IsDefined
                (typeof(System.Diagnostics.Debugger), false))
                Console.WriteLine("Entering debug mode");
            else
                Console.WriteLine("Entering relase mode");
        }
    }
}