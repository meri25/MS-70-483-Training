using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MS._70483.App
{
    class Q6 : Question
    {
        private Question question;
        public Q6()
        {
            this.isSampleFlag = true;
        }
        public Question Start(Question question)
        {
            this.question = question;

            if (question.option == "ab" || question.option == "ba")
            {
                this.question.answer = "Correct!";
                return this.question;
            }else
            {
                this.question.answer = "Wrong!";
                return this.question;
            }
        }
    }

    class Lease
    {
        public event MaximumTermReachedHandler OnmaximamTerReached;
        private int _term;
        private const int MaximumTerm = 5;
        private const decimal Rate = 0.034m;
        public int Term
        {
            get
            {
                return _term;
            }
            set
            {
                if (value <= MaximumTerm)
                {
                    _term = value;
                }
                else
                {
                    if (OnmaximamTerReached != null)
                    {
                        OnmaximamTerReached(this, new EventArgs());
                    }
                }
            }
        }
        public delegate void MaximumTermReachedHandler(object source, EventArgs e);
    }
}
