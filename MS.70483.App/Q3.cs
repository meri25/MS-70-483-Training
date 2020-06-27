using System;
using System.Collections.Generic;
using System.Text;

namespace MS._70483.App
{
    class Q3 : Question
    {
        private Question question;
        public Question Start(Question question)
        {
            this.question = question;
            switch (question.option)
            {
                case "a":
                    OptionA(3_000.5F);
                    this.question.answer = "Correct!";
                    return this.question;
                case "b":
                    OptionB(3_000.5F);
                    this.question.answer = "Correct!";
                    return this.question;
                case "c":
                    OptionC(3_000.5F);
                    this.question.answer = "Wrong!";
                    return this.question;
                case "d":
                    OptionD(3_000.5F);
                    this.question.answer = "Wrong!";
                    return this.question;
                default:
                    return this.question;
            }
        }
        private static void OptionA(float amount)
        {
            object amountRef = amount;
            int balance = (int)(float)amountRef;
            Console.WriteLine(balance);
        }
        private static void OptionB(float amount)
        {
            object amountRef = amount;
            
            int balance = (int)amountRef;
            Console.WriteLine(balance);
        }
        private static void OptionC(float amount)
        {
            object amountRef = amount;
            // int balance = amountRef;
            Console.WriteLine("Error");
        }
        private static void OptionD(float amount)
        {
            object amountRef = amount;
            int balance = (int)(double)amountRef;
            Console.WriteLine(balance);
        }
    }
}
