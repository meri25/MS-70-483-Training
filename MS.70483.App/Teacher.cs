using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
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
                    Q1 q1 = new Q1();
                    return q1.Start(question);
                case 3:
                    Q3 q3 = new Q3();
                    return q3.Start(question);
                case 4:
                    Q4 q4 = new Q4();
                    return q4.Start(question);
                case 5:
                    Q5 q5 = new Q5();
                    return q5.Start(question);
                default:
                    return this.question;
            }
        }

        public bool IsSmaple(Question question)
        {
            switch (question.number)
            {
                case 1:
                    Q1 q1 = new Q1();
                    return q1.isSampleFlag;
                case 3:
                    Q3 q3 = new Q3();
                    return q3.isSampleFlag;
                case 4:
                    Q4 q4 = new Q4();
                    return q4.isSampleFlag;
                case 5:
                    Q5 q5 = new Q5();
                    return q5.isSampleFlag;
                default:
                    return this.question.isSampleFlag;
            }
            return this.question.isSampleFlag;
        }
    }
}
