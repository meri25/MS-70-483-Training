using System;
using System.Collections.Generic;
using System.Text;

namespace MS_70_483
{
    class Question1_6
    {
    }

    delegate void AddUserCallback(int i);

    class UserTracker
    {
        // Option.A 1/2
        /*
                private static void PrintUserCount(int i)
                {
                    // ...
                }
        */
        List<User> users = new List<User>();

        public void AddUser(string name, AddUserCallback callback)
        {
            users.Add(new User(name));
            callback(users.Count);
        }
    }

    // Option.B 1/2
    // delegate void AddUserDelegate(UserTracker userTracker);

    // Option.C 1/2
    delegate void AddUserDelegate(String name, AddUserCallback callback);

    class Runner
    {
        UserTracker tracker = new UserTracker();
        public void Add(string name)
        {
            // Opction.A 2/2
            // AddUserCallback callback = PrintuserCount;

            // Option.B 2/2
            /*
                        AddUserDelegate addDelegate = (UserTracker) =>
                        {
                            // ...
                        };       
            */
            // Option.C 2/2

            AddUserDelegate adder = (i, callback) =>
            {
                // ...
            };
        }

    }

    // 以下、設問の便宜のために私が追記したクラス
    class User
    {
        public string name { get; set; }

        public User(string name)
        {
            this.name = name;
        }
    }

    public class SampleDelegate
    {
        // int を取り込んで String を返すメソッドのデリゲートを宣言する
        public delegate string MyMethodDeleate(int myInt);

        // デリゲートがポイントできるメソッドを定義する
        public class MySampleClass
        {
            // インスタンスメソッドを定義する
            public string MyStringMethod(int myInt)
            {
                if (myInt > 0)
                    return ("positive");
                if (myInt < 0)
                    return ("negative");
                return ("zero");
            }

            // static メソッドを定義する
            public static string MySignMethod(int myInt)
            {
                if (myInt > 0)
                    return ("+");
                if (myInt < 0)
                    return ("-");
                return ("");
            }
        }

        public static void SampleDelegateMain()
        {
            /*
            メソッドごとにデリゲートを1つ作成する。
            インスタンスメソッドの場合、インスタンス（mySC）を提供する必要がある。
            static メソッドの場合、クラス名を利用する。
            */
            MySampleClass mySC = new MySampleClass();
            MyMethodDeleate myD1 = new MyMethodDeleate(mySC.MyStringMethod);
            MyMethodDeleate myD2 = new MyMethodDeleate(MySampleClass.MySignMethod);

            // デリゲートを呼び出す
            Console.WriteLine("{0} is {1}; user the sign \"{2}\".", 5, myD1(5), myD2(5));
            Console.WriteLine("{0} is {1}; user the sign \"{2}\".",-3, myD1(-3), myD2(-3));
            Console.WriteLine("{0} is {1}; user the sign \"{2}\".", 0, myD1(0), myD2(0));
        }
    }
}
