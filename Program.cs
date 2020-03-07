using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;

namespace MS_70_483
{
    class Program
    {
        static void Main(string[] args)
        {
            #region q.1
            // Console.WriteLine("--Q1--");
            TestIfWebSite("http://www.google.comhttp://www.googlea.comhttp://www.googleb.com");
            #endregion

            #region q.2
            // Console.WriteLine("--Q2--");
            // OutputLogDebugOrReleaseMode();
            #endregion

            #region q.3
            Console.WriteLine("--Q3--");
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

            // ex.1 列挙子を利用したパターン
            IEnumerator enumerator = myMatches.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Match val = (Match)enumerator.Current;
                Console.WriteLine(val.Value);
            }

            // ex.2 foreach 文を利用したパターン
            foreach (Match myMatch in myMatches)
            {
                Console.WriteLine(myMatch.Value);
            }

            // Note:
            // MatchCollection.GetEnumeratorメソッドは、コレクションを反復処理する列挙子を返します。
            // ?-- デバッグするとエラー
            // System.InvalidCastException: 'Unable to cast object of type 'Enumerator' to type 'System.Collections.Generic.List`1[System.String]'.'

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

        public static bool Dowork()
        {
            return true;
        }
    }
}
