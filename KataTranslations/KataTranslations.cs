using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTranslations
{
    public class KataTranslations
    {
        public static bool ValidateString(string[] dictionary, string word)
        {
            return (dictionary.Reverse().Aggregate(word, (current, t) => current.Replace(t, string.Empty)).Length == 0);
        }
    }
}
