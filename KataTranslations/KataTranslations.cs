using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTranslations
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
    }
}
