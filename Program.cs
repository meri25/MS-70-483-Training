using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MS_70_483
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Q1--");
            Console.WriteLine(TestIfWebSite("http://www.google.com"));
        }

        public static List<string> TestIfWebSite(string url)
        {
            const string pattern = @"http://(www\.)?(^\.]+)\.com";
            List<string> result = new List<string>();

            MatchCollection myMatches = Regex.Matches(url, pattern);

            // Option.A <Answer>
            result = (List<string>)myMatches.GetEnumerator();
            // Note:
            // MatchCollection.GetEnumeratorメソッドは、コレクションを反復処理する列挙子を返します。

            // Option.B
            // result = (List<string>)myMatches.SyncRoot();
            // Error

            // Option.C
            // result = (from System.Text.RegularExpressions.Match m in myMatches select m.Value).ToList<string>();

            // Option.D
            //result = (from System.Text.RegularExpressions.Match m in myMatches where !m.Success select m.Value).ToList<string>();

            return result;
        }
    }
}
