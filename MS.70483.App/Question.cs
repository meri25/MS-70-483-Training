using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace MS._70483.App
{
    class Question
    {
        public int number { get; set; }
        public string statement { get; set; }
        public string option { get; set; }
        public string answer { get; set; }

        public Question()
        {
        }
    }
}
