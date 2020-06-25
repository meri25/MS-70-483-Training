using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace MS._70483.App
{
    class Q1 : Question
    {
        private Question question;
        public Question Start (Question question)
        {
            this.question = question;
            switch (question.option)
            {
                case "a":
                    this.question.answer = "Correct!";
                    return this.question;
                case "b":
                    this.question.answer = "Wrong!";
                    return this.question;
                default:
                    return this.question;
            }
        }
    }
}
