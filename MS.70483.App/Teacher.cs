using System;
using System.Collections.Generic;
using System.Text;

namespace MS._70483.App
{
    class Teacher
    {
        public Question question;

        public Question RunQuestion(Question question)
        {
            switch (question.number)
            {
                case 1:
                    Q1 q = new Q1();
                    return q.Start(question);
                default:
                    return this.question;
            }
        }
    }
}
