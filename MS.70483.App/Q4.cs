using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MS._70483.App
{
    class Q4 : Question
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
                    this.question.answer = "Wrong!";
                    return this.question;
                case "c":
                    OptionC();
                    this.question.answer = "Wrong!";
                    return this.question;
                case "d":
                    OptionD();
                    this.question.answer = "Correct!";
                    return this.question;
                default:
                    return this.question;
            }
        }
        private static void OptionA()
        {
            // Get a Type object.
            Type t = typeof(int);
            // Instantiate an Assembly class to the assembly housing the Integer type.
            Assembly assem = Assembly.GetAssembly(t);
            // Display the name of the assembly.
            Console.WriteLine("Name: {0}", assem.FullName);
            // Get the location of the assembly using the file: protocol.
            Console.WriteLine("CodeBase: {0}", assem.CodeBase);
        }
        private static void OptionB()
        {
            // this.GetType();
            Console.WriteLine("Error");
        }
        private static void OptionC()
        {
            // You must supply a valid fully qualified assembly name.
            Assembly SampleAssembly = Assembly.Load
                ("SampleAssembly, Version=1.0.2004.0, Culture=neutral, PublicKeyToken=8744b20f8da049e3");
            // Display all the types contained in the specified assembly.
            foreach (Type oType in SampleAssembly.GetTypes())
            {
                Console.WriteLine(oType.Name);
            }
        }
        private static void OptionD()
        {
            // Get the assembly from a known type in that assembly.
            Type t = typeof(Q4);
            Assembly assemFromType = t.Assembly;
            Console.WriteLine("Assembly that contains Example:");
            Console.WriteLine("   {0}\n", assemFromType.FullName);

            // Get the currently executing assembly.
            Assembly currentAssem = Assembly.GetExecutingAssembly();
            Console.WriteLine("Currently executing assembly:");
            Console.WriteLine("   {0}\n", currentAssem.FullName);

            Console.WriteLine("The two Assembly objects are equal: {0}",
                              assemFromType.Equals(currentAssem));
        }
    }
}
