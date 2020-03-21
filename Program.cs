using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;
using System.Reflection;

namespace MS_70_483
{
    class Program
    {
        static void Main(string[] args)
        {
            #region q.1
            // Console.WriteLine("--Q1--");
            // TestIfWebSite("http://www.google.comhttp://www.googlea.comhttp://www.googleb.com");
            #endregion

            #region q.2
            // Console.WriteLine("--Q2--");
            // OutputLogDebugOrReleaseMode();
            #endregion

            #region q.3
            //Console.WriteLine("--Q3--");
            #endregion

            #region q.4
            // Console.WriteLine("--Q.4--");
            // Question4();
            #endregion

            #region q.5
            // Console.WriteLine("--Q5--");
            #endregion

            #region q.6
            // Console.WriteLine("Q6");
            #endregion

            #region q.1-1
            /*            Console.WriteLine("Q1-1");
                        Caluculate(3_000.5F);*/
            #endregion

            #region q.1-3
            // Console.WriteLine("Q1-3");
            // Question1_3.TaskTraining();
            // Question1_3.RunTraining();
            #endregion

            #region q.1-4
            // Console.WriteLine("q.1-4");
            #endregion

            #region q.1-5
            // Console.WriteLine("q.1-5");
            // Question1_5.ExceptionTraining();
            #endregion

            #region q.1-6
            // Console.WriteLine("Q.1-6");
            // SampleDelegate.SampleDelegateMain();
            #endregion

            #region q.1-7
            Console.WriteLine("Q.1-7");

            #endregion
        }

        private static List<string> TestIfWebSite(string url)
        {
            // 繰り返される単語の正規表現を定義
            const string pattern = @"http://(www\.)?([^\.]+)\.com";

            List<string> result = new List<string>();

            // pattern にマッチする文字列を探す
            MatchCollection myMatches = Regex.Matches(url, pattern);

            // Option.A <Answer>
            // result = (List<string>)myMatches.GetEnumerator();

            // Note:
            // MatchCollection.GetEnumeratorメソッドは、コレクションを反復処理する列挙子を返します。
            // ?-- デバッグするとエラー
            // System.InvalidCastException: 'Unable to cast object of type 'Enumerator' to type 'System.Collections.Generic.List`1[System.String]'.'
            // 解決方法：
            // ex.1 列挙子を利用したパターン
            /*            IEnumerator enumerator = myMatches.GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            Match val = (Match)enumerator.Current;
                            Console.WriteLine(val.Value);
                        }

                        // ex.2 foreach 文を利用したパターン
                        foreach (Match myMatch in myMatches)
                        {
                            Console.WriteLine(myMatch.Value);
                        }*/

            // ?-- 問題に対して疑問。このTestIfWebSiteでは、何を返したかったのだろう。


            // Option.B
            // result = (List<string>)myMatches.SyncRoot();
            // Error

            // Option.C
            // result = (from System.Text.RegularExpressions.Match m in myMatches select m.Value).ToList<string>();

            // Option.D
            //result = (from System.Text.RegularExpressions.Match m in myMatches where !m.Success select m.Value).ToList<string>();

            return result;
        }

        private static void OutputLogDebugOrReleaseMode()
        {
            #if (DEBUG)
                Console.WriteLine("Entering Debug Mode");
            #else
                Console.WriteLine("Entering ReleaseMode");
            #endif

        }

        private static List<Type> Question4()
        {
            List<Type> types = new List<Type>();
/*
            types = (AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(t => t.GetType(), t => new { t })
                .Where(t => t.IsClass && t.Assembly == this.GetType().select)).ToList<Type>();
*/
            return types;
        }

        #region q.1-1
        public static void Caluculate(float amount)
        {
            object amountRef = amount;

            // Options
            // Option.A
            // int balance = (int)(float)amountRef;

            // Option.B
            int balance = (int)amountRef;

            Console.WriteLine(balance);
        }
        #endregion

        #region q.1-8
        bool ConstainsHyperLink(string inputData)
        {
            string regExPattern = "href\\s*=\\s*(?:\"(?<1>[^\"]*)\"|(?<1>\\S+))";

            // Option.A
            var evaluator = new Regex(regExPattern, RegexOptions.CultureInvariant);

            // Option.B
            // var evaluator = new Regex(inputData);

            // Option.C
            /*
                var assemblyName = "Vlidation";
                var compilationInfo = new RegexCompilationInfo(inputData, RegexOptions.IgnoreCase, "Href", assemblyName, true);
                Regex.CompileToAssembly(new[] { compilationInfo }, new AssemblyName(assemblyName));
                var evaluator = new Regex(regExPattern, RegexOptions.CultureInvariant); 
            */

            // Option.D
            // var evaluator = new Regex(regExPattern, RegexOptions.Compiled);

            return evaluator.IsMatch(inputData);

        }
        #endregion
    }
}
