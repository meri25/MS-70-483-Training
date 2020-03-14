using System;
using System.Threading;
using System.Threading.Tasks;

namespace MS_70_483
{
    class Question1_3
    {
        public static void TaskTraining()
        {
            /*
             タスクのインスタンス化の4つの例。
             https://docs.microsoft.com/ja-jp/dotnet/api/system.threading.tasks.task?view=netframework-4.8#task-instantiation
             */

            Action<object> action = (object obj) =>
            {
                Console.WriteLine("Task={0}, obj={1}, Thread={2}",
                    Task.CurrentId, obj,
                    Thread.CurrentThread.ManagedThreadId
                    );
            };

            // タスクを作成する。この時点では、実行されない。
            Task t1 = new Task(action, "beta-1");

            // すでに実行が開始しているタスクを生成する。
            Task t2 = Task.Factory.StartNew(action, "beta-2");
            t2.Wait();

            // t1 を実行する
            t1.Start();
            Console.WriteLine("t1 has been launched. (Main Thread={0})",
                Thread.CurrentThread.ManagedThreadId);

            // t1 を待機ささせる
            t1.Wait();

            // Task.Run() を使って開始タスクを作成する
            String taskData = "dlta";
            Task t3 = Task.Run(() =>
            {
                Console.WriteLine("Task={0}, obj={1}, Thread={2}",
                    Task.CurrentId, taskData,
                    Thread.CurrentThread.ManagedThreadId);
            });

            // t3 を待機させる
            t3.Wait();

            // 未開始のタスクを作成する
            Task t4 = new Task(action, "gamma");

            // 同期実行する
            t4.RunSynchronously();

            // タスクが実行されて、例外がスローされてもそのタスクで待機する
            t4.Wait();
;        }

        /*
         RunTraining()
         現在のスレッドの Thread.ManagedThreadId を実行する ShowThreadInfo を定義する。
         これはアプリケーションスレッドから直接呼び出され、 Run(Action) メソッドに渡される Action デリゲートから呼び出される。
        */


        public static void RunTraining()
        {
            var t = Task.Run(() => ShowThreadInfo("Task"));
            t.Wait();

            ShowThreadInfo("Application");
        }

        static void ShowThreadInfo(string s)
        {
            Console.WriteLine("{0} Thread ID: {1}",
                s, Thread.CurrentThread.ManagedThreadId);
        }
    }

    class Question1_3_TaskComletionSouce
    {
        public static void TaskTraining()
        {

        }
    }
}
