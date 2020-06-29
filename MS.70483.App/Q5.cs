using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MS._70483.App
{
    class Q5 : Question
    {
        private Question question;
        public Q5()
        {
            this.isSampleFlag = true;
        }
        public Question Start(Question question)
        {
            this.question = question;

            if (question.sampleFlag)
            {
                Q5_Lean.Start();
                this.question.answer = "Got it?";
                this.sampleFlag = false;
                return this.question;
            }

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

        }
        private static void OptionB()
        {

        }
        private static void OptionC()
        {

        }
        private static void OptionD()
        {

        }
    }

    class Q5_Lean
    {
        /**
         * 次の例(Start)では、4つのタスクを作成して実行します。 
         * 3つのタスクは、型 Objectの引数を受け取る actionという名前の Action<T> デリゲートを実行します。 
         * 4番目のタスクは、タスク作成メソッドの呼び出しでインラインで定義されているラムダ式 (Action デリゲート) を実行します。 
         * 各タスクはインスタンス化され、別の方法で実行されます。
         * 
         **/
        public static void Start()
        {
            Action<object> action = (object obj) =>
            {
                Console.WriteLine("Task={0}, obj={1}, Thread={2}",
                    Task.CurrentId, obj,
                    Thread.CurrentThread.ManagedThreadId);
            };

            // Create a task but do not start it.
            Task t1 = new Task(action, "alpha");

            // Construct a started task
            Task t2 = Task.Factory.StartNew(action, "beta");
            // Block the main thread to demonstrate that t2 is executing
            t2.Wait();

            // Launch t1 
            t1.Start();
            Console.WriteLine("t1 has been launched. (Main Thread={0})",
                              Thread.CurrentThread.ManagedThreadId);
            // Wait for the task to finish.
            t1.Wait();

            // Construct a started task using Task.Run.
            String taskData = "delta";
            Task t3 = Task.Run(() => {
                Console.WriteLine("Task={0}, obj={1}, Thread={2}",
                                  Task.CurrentId, taskData,
                                   Thread.CurrentThread.ManagedThreadId);
            });
            // Wait for the task to finish.
            t3.Wait();

            // Construct an unstarted task
            Task t4 = new Task(action, "gamma");
            // Run it synchronously
            t4.RunSynchronously();
            // Although the task was run synchronously, it is a good practice
            // to wait for it in the event exceptions were thrown by the task.
            t4.Wait();
        }
    }
}
