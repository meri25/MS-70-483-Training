using System;
using System.Runtime.CompilerServices;

namespace MS._70483.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Question question = new Question();
            Teacher teacher = new Teacher();

            bool next = true;

            while (next)
            {
                Console.WriteLine("-----------------------------------");

                Console.WriteLine("> Question Number?");
                question.number = Convert.ToInt32(Console.ReadLine());

                if(teacher.IsSmaple(question))
                {
                    Console.WriteLine("Do you wanna run samples?");
                    string q = Console.ReadLine();
                    if (q == "y")
                    {
                        question.sampleFlag = true;
                        Console.WriteLine(teacher.RunQuestion(question).answer);
                    }
                }

                Console.WriteLine("> Option Number?");
                question.option = Console.ReadLine();

                Console.WriteLine(teacher.RunQuestion(question).answer);
                Console.WriteLine("-----------------------------------");

                Console.WriteLine("Continue ? Press y/n.");
                next = Console.ReadLine() == "y" ? true : false;
            }
        }
    }
}
