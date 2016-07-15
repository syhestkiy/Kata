using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kata
{
    public class KataTranslations
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dictionary">expected words in string</param>
        /// <param name="word">string to check</param>
        /// <returns></returns>
        public static bool ValidateString(string[] dictionary, string word)
        {
            return (dictionary.Reverse().Aggregate(word, (current, t) => current.Replace(t, string.Empty)).Length == 0);
        }

        /// <summary>
        /// # Write this function
        ///![](http://i.imgur.com/mlbRlEm.png)
        ///`for i from 1 to n`, do `i % m` and return the `sum`
        /// f(n= 10, m= 5) // returns 20 (1+2+3+4+0 + 1+2+3+4+0)
        ///*You'll need to get a little clever with performance, since n can be a very large number*
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static long SumOfManyInts(long n, long m)
        {
            Func<long, long> sum = s => (s*(s + 1))/2;
            return sum(m - 1)*(n/m) + sum(n%m);
        }

        /// <summary>
        /// Write an algorithm that will identify valid IPv4 addresses in dot-decimal format. 
        /// Input to the function is guaranteed to be a single string.
        /// Examples of valid inputs:
        /// 1.2.3.4
        /// 123.45.67.89
        /// Examples of invalid inputs:
        /// 1.2.3
        /// 1.2.3.4.5
        /// 123.456.78.90
        /// 123.045.067.089
        /// </summary>
        /// <param name="ip">string to validate</param>
        /// <returns>true - valid string, false - invalid</returns>
        public static bool IpValidator(string ip)
        {
            return
                (Regex.Match(ip, @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$"))
                    .Success;
        }
    }
}
