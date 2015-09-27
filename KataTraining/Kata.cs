using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace KataTraining
{
    public static class Kata
    {
        /// <summary>
        /// Write a function that takes a single string (word) as argument. The function must return an ordered list containing the indexes of all capital letters in the string.
        ///Example
        ///Assert.AreEqual(Kata.Capitals("CodEWaRs"), new int[]{0,3,4,6});
        /// </summary>
        /// <param name="word">Input string</param>
        /// <returns>int array which contains indexes of capital chars</returns>
        public static int[] Capitals(string word)
        {
            char[] temp = word.ToCharArray();
            int[] capitals = new int[temp.Count()];
            int j = 0, i;
            for (i = 0; i < temp.Count(); i++)
            {
                if ((temp[i] > 64) && (temp[i] < 91))
                {
                    capitals[j] = i;
                    j++;
                }
            }
            return capitals;
        }

        /// <summary>
        /// In mathematics, the factorial of a non-negative integer n, denoted by n!, is the product of all positive integers less than or equal to n. For example: 5! = 5 * 4 * 3 * 2 * 1 = 120. By convention the value of 0! is 1.
        ///Write a function to calculate factorial for a given input. If input is below 0 or above 12 throw an exception of type ArgumentOutOfRangeException (C#) or IllegalArgumentException (Java).
        ///More details about factorial can be found here: http://en.wikipedia.org/wiki/Factorial
        /// </summary>
        /// <param name="n">Input value</param>
        /// <returns>Factorial of n</returns>
        public static int Factorial(int n)
        {
            if (n < 0 || n > 12)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (n > 1)
                n = n * Factorial(n - 1);
            return n;
        }
        /// <summary>
        /// Why would we want to stop to only 50 shades of grey? Let's see to how many we can go.
        ///Write a function that takes a number n as a parameter and return an array containing n shades of grey in hexadecimal code (#aaaaaa for example). The array should be sorted in ascending order starting with #010101, #020202, etc. (using lower case letters).
        ///using System;
        ///public static class Kata {
        ///  public static class ShadesOfGrey(int n) {
        ///    // returns n shades of grey in an array
        ///  }
        ///}
        ///As a reminder, the grey color is composed by the same number of red, green and blue: #010101, #aeaeae, #555555, etc. Also, #000000 and #ffffff are not accepted values.
        ///When n is negative, just return an empty array. If n is higher than 254, just return an array of 254 elements.
        ///Have fun
        /// </summary>
        /// <param name="n"></param>
        /// <returns>String array with shades of gray</returns>
        public static string[] ShadesOfGray(int n)
        {
            string[] shadesOfGray = { };

            if (n < 0)
                return shadesOfGray = new string[0];

            if ((n < 254 || n > 254) && n > 0)
            {
                if (n > 254)
                {
                    n = 254;
                }
                shadesOfGray = new string[n];
                for (int i = 1; i <= n; i++)
                {
                    if (i < 16)
                    {
                        var s = "#" + "0" + i.ToString("X").ToLower() + "0" + i.ToString("X").ToLower() + "0" + i.ToString("X").ToLower();
                        shadesOfGray[i - 1] = s;
                    }
                    else
                    {
                        shadesOfGray[i - 1] = "#" + i.ToString("X").ToLower() + i.ToString("X").ToLower() + i.ToString("X").ToLower();
                    }
                }

            }
            return shadesOfGray;
        }
        /// <summary>
        /// Description:
        ///Your online store likes to give out coupons for special occasions. Some customers try to cheat the system by entering invalid codes or using expired coupons.
        ///Your mission: 
        ///Write a function called checkCoupon to verify that a coupon is valid and not expired. If the coupon is good, return true. Otherwise, return false.
        ///A coupon expires at the END of the expiration date. All dates will be passed in as strings in this format: "June 15, 2014"
        /// </summary>
        /// <param name="enteredCode"></param>
        /// <param name="correctCode"></param>
        /// <param name="currentDate"></param>
        /// <param name="expirationDate"></param>
        /// <returns>If the coupon is good, return true. Otherwise, return false.</returns>
        public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
        {
            bool isCodeCorrect = Equals(enteredCode, correctCode);

            var tempCurDate = currentDate.Replace(',', '\t').Split(' ');
            var tempExpDate = expirationDate.Replace(',', '\t').Split(' ');

            var curDate = DateTime.Parse(tempCurDate[1] + " " + tempCurDate[0] + " " + tempCurDate[2]);
            var expDate = DateTime.Parse(tempExpDate[1] + " " + tempExpDate[0] + " " + tempExpDate[2]);

            bool isDateCorrect = false;
            if ((DateTime.Compare(curDate, expDate) < 0))
                isDateCorrect = true;
            else if (DateTime.Compare(curDate, expDate) == 0)
                isDateCorrect = true;
            else
                isDateCorrect = false;
            return isDateCorrect && isCodeCorrect;
        }

        /// <summary>
        /// Usually when you buy something, you're asked whether your credit card number, phone number or answer to your most secret question is still correct. However, since someone could look over your shoulder, you don't want that shown on your screen. Instead, we mask it.
        ///Your task is to write a function maskify, which changes all but the last four characters into '#'.
        ///Examples
        ///Kata.Maskify('4556364607935616'); // should return "############5616"
        ///Kata.Maskify('64607935616');      // should return "#######5616"
        ///Kata.Maskify('1');                // should return "1"
        ///Kata.Maskify('');                 // should return ""
        /// "What was the name of your first pet?"
        ///Kata.Maskify('Skippy');                                   // should return "##ippy"
        ///Kata.Maskify('Nananananananananananananananana Batman!'); // should return "####################################man!"
        /// </summary>
        /// <param name="cc">Input string</param>
        /// <returns>Musked string</returns>
        public static string Maskify(string cc)
        {
            char[] arr = cc.ToCharArray();
            if (arr.Count() == 0)
                return string.Empty;
            for (int i = 0; i < arr.Count() - 4; i++)
                arr[i] = '#';
            return new string(arr);
        }
        /// <summary>
        /// Return the number (count) of vowels in the given string.
        ///We will consider a, e, i, o, and u as vowels for this Kata.
        /// </summary>
        /// <param name="str">input string</param>
        /// <returns>Number of vowels in string</returns>
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            char[] arr = str.ToLower().ToCharArray();
            for (int i = 0; i < arr.Count(); i++)
                if (arr[i] == 'a' || arr[i] == 'e' || arr[i] == 'i' || arr[i] == 'o' || arr[i] == 'u')
                    vowelCount++;


            return vowelCount;
        }
        /// <summary>
        /// Bob is preparing to pass IQ test. The most frequent task in this test is to find out which one of the given numbers differs from the others. Bob observed that one number usually differs from the others in evenness. Help Bob � to check his answers, he needs a program that among the given numbers finds one that is different in evenness, and return a position of this number.
        ///! Keep in mind that your task is to help Bob solve a real IQ test, which means indexes of the elements start from 1 (not 0)
        ///Examples :
        ///IQ.Test("2 4 7 8 10") => 3 // Third number is odd, while the rest of the numbers are even
        ///IQ.Test("1 2 1 1") => 2 // Second number is even, while the rest of the numbers are odd
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int Test(string numbers)
        {
            var n = numbers.Split(' ');
            var nums = new int[n.Count()];
            for (int i = 0; i < n.Count(); i++)
            {
                nums[i] = Int32.Parse(n[i]);
            }
            int numbersOfEven = 0, indexEven = 0, numbersOfUneven = 0, indexUneven = 0;

            for (int i = 0; i < nums.Count(); i++)
            {
                if (nums[i] % 2 == 0)
                {
                    numbersOfEven++;
                    indexEven = i + 1;
                }
                else
                {
                    numbersOfUneven++;
                    indexUneven = i + 1;
                }
            }

            int index = 0;
            index = numbersOfEven > 1 ? indexUneven : indexEven;
            return index;
        }
        /// <summary>
        /// Find the sum of the digits of all the numbers from 1 to N (both ends included).
        ///For N = 10 the sum is 1+2+3+4+5+6+7+8+9+(1+0) = 46
        ///For N = 11 the sum is 1+2+3+4+5+6+7+8+9+(1+0)+(1+1) = 48
        ///For N = 12 the sum is 1+2+3+4+5+6+7+8+9+(1+0)+(1+1) +(1+2)= 51
        /// </summary>
        /// <param name="n">Input value</param>
        /// <returns>Sum of the digits of all the numbers</returns>
        public static long TwistedSum(long n)
        {
            var nums = new List<long>();
            for (int i = 1; i <= n; i++)
            {
                nums.AddRange(i.ToString().ToCharArray().Select(v => Int64.Parse(v.ToString())));
            }
            return nums.Sum();
        }

        /// <summary>
        /// Backwards Read Primes are primes that when read backwards in base 10 (from right to left) are a different prime. (This rules out primes which are palindromes.)
        ///Examples:
        ///13 17 31 37 71 73 are Backwards Read Primes
        ///13 is such because it's prime and read from right to left writes 31 which is prime too. Same for the others.
        ///Task
        ///Find all Backwards Read Primes between two positive given numbers (both inclusive), the second one being greater than the first one. The resulting array or the resulting string will be ordered following the natural order of the prime numbers.
        ///backwardsPrime(2, 100) => "13 17 31 37 71 73 79 97"
        ///backwardsPrime(9900, 10000) => "9923 9931 9941 9967"
        /// </summary>
        /// <param name="start">Start value of interval</param>
        /// <param name="end">End value of interval</param>
        /// <returns>String with Backward read primes</returns>

        public static string BackwardsPrime(long start, long end)
        {
            var primes = new List<long>();
            for (long i = start; i <= end; i++)
            {
                if (i == 1 || i == 2 || i == 3 || i == 5 || i == 7)
                    i = i;
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                    primes.Add(i);
            }

            var backwardsPrime = new List<long>();
            foreach (var prime in primes)
            {
                long c = 0;
                if (prime > 10)
                {
                    c =
                        long.Parse(prime.ToString()
                            .ToCharArray()
                            .Reverse()
                            .Aggregate(string.Empty, (current, a) => current + a));

                    if (c % 2 != 0 && c % 3 != 0 && c % 5 != 0 && c % 7 != 0 && c % 11 != 0)
                        backwardsPrime.Add(prime);
                }
            }
            var result = string.Empty;
            foreach (var l in backwardsPrime)
            {
                if (l != backwardsPrime.Last())
                    result += l + " ";
                else
                    result += l;
            }
            return result;
        }


        /// <summary>
        /// I love Fibonacci numbers in general, but I must admit I love some more than others.
        ///I would like for you to write me a function that when given a number (n) returns the n-th number in the Fibonacci Sequence.
        ///For example:
        ///NthFib(4) == 2
        ///Because 2 is the 4th number in the Fibonacci Sequence.
        ///For reference, the first two numbers in the Fibonacci sequence are 0 and 1, and each subsequent number is the sum of the previous two.
        /// </summary>
        /// <param name="n">Nth element of Fibonachi sequence</param>
        /// <returns></returns>
        public static int NthElementOfFibonachiSequence(int n)
        {
            List<int> fs = new List<int> { 0, 1 };
            switch (n)
            {
                case 0:
                    return fs[0];
                case 1:
                    return fs[1];
                default:
                    for (int i = 2; i < n; i++)
                    {
                        fs.Add(fs[i - 1] + fs[i - 2]);
                    }
                    return fs[fs.Count - 1];
            }
        }

        public static string Swap(string str)
        {
            #region Obsolite Code
            //var arr = str.ToCharArray();
            //str = string.Empty;
            //foreach (var t in arr)
            //{
            //    if (t > 64 && t < 91)
            //        str += t.ToString().ToLower();
            //    else if (t > 96 && t < 123)
            //        str += t.ToString().ToUpper();
            //    else
            //        str += t;
            //}
            #endregion
            return String.Concat(str.Select(c => Char.IsLower(c) ? Char.ToUpper(c) : Char.ToLower(c)));
            #region Obsolite Code
            //var arr = str.ToCharArray();
            //str = string.Empty;
            //foreach (var c in arr)
            //{
            //    if (Char.IsUpper(c))
            //        str += Char.ToLower(c);
            //    else if (Char.IsLower(c))
            //        str += Char.ToUpper(c);
            //}
            //return str;
            #endregion
        }

        /// <summary>
        /// Filter the number
        ///Oh no! The number has been mixed up with the text. Your goal is to retreive the number from the text, can you return the number back to it's original state?
        ///Task
        ///Your task is to return a number from a string.
        ///Details
        ///You will be given a string of numbers and letters mixed up, you have to return all the numbers in that string in the order they occur.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int FilterString(string s)
        {
            return Int32.Parse(String.Concat(s.Where(c => Char.IsNumber(c)).Aggregate(string.Empty, (current, c) => current + c)));
        }

        /// <summary>
        /// At a job interview, you are challenged to write an algorithm to check if a given string, s, can be formed from two other strings, part1 and part2.
        ///The restriction is that the characters in part1 and part2 are in the same order as in s.
        ///The interviewer gives you the following example and tells you to figure out the rest from the given test cases:
        ///'codewars' is a merge from 'cdw' and 'oears':
        ///    s:  c o d e w a r s   = codewars
        ///part1:  c   d   w         = cdw
        ///part2:    o   e   a r s   = oears
        /// </summary>
        /// <param name="s"></param>
        /// <param name="part1"></param>
        /// <param name="part2"></param>
        /// <returns></returns>
        public static bool IsMerge(string s, string part1, string part2)
        {
            var arr1 = part1.ToCharArray();
            var arr2 = part2.ToCharArray();
            string result = string.Empty;
            int vowelCount = 0, consonansCount = 0;

            for (int i = 0; i < (arr1.Count() + arr2.Count()); i++)
            {
                if (!(arr1[i] == 'a' || arr1[i] == 'e' || arr1[i] == 'i' || arr1[i] == 'o' || arr1[i] == 'u') &&
                    consonansCount <= arr1.Count())
                {
                    result += arr1[consonansCount];
                    consonansCount++;
                }
                //else if()

            }
            //TODO Warning change this
            return false;
        }

        /// <summary>
        /// "Triple double"
        ///Write a function
        ///TripleDouble(long num1, long num2)
        ///which takes in numbers num1 and num2 and returns 1 if there is a straight triple of a number at any place in num1 and also a straight double of the same number in num2.
        ///For example:
        ///TripleDouble(451999277, 41177722899) == 1 // num1 has straight triple 999s and 
        /// num2 has straight double 99s
        ///TripleDouble(1222345, 12345) == 0 // num1 has straight triple 2s but num2 has only a single 2
        ///TripleDouble(12345, 12345) == 0
        ///TripleDouble(666789, 12345667) == 1
        ///If this isn't the case, return 0
        /// </summary>
        /// <param name="num1">First number</param>
        /// <param name="num2">Second number</param>
        /// <returns>1 - if input correct, 0 - if not;</returns>
        public static int TripleDouble(long num1, long num2)
        {
            var arr1 = num1.ToString().ToCharArray();
            var arr2 = num2.ToString().ToCharArray();
            var temp = arr1[0];
            var count = 1;
            bool firstCorrect = false, secondCorrect = false;
            for (int i = 1; i < arr1.Length; i++)
            {
                if (temp == arr1[i])
                    count++;
                else
                    count = 1;
                if (count == 3)
                    firstCorrect = true;
                temp = arr1[i];
            }
            temp = arr2[0];
            count = 1;
            for (int i = 1; i < arr2.Length; i++)
            {
                if (temp == arr2[i])
                    count++;
                else
                    count = 1;
                if (count == 2)
                    secondCorrect = true;
                temp = arr2[i];
            }
            if (firstCorrect && secondCorrect)
                return 1;
            return 0;
        }


        public static bool IsTriangleNumber(long number)
        {
            if (number == 0 || number == 1)
                return true;
            var primes = new List<long>();
            for (long i = 11; i < number; i++)
            {
                if (i == 2 || i == 3 || i == 5 || i == 7)
                    primes.Add(i);
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i % 9 != 0)
                    primes.Add(i);
            }
            return (primes.Sum()) == number;
        }

        private static List<long> IsPrime(long n)
        {
            var primes = new List<long>();
            for (long i = 2; i <= n; i++)
            {
                if (i == 2 || i == 3 || i == 5 || i == 7)
                    primes.Add(i);
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                    primes.Add(i);
            }
            return primes;
        }
        /// <summary>
        /// Help the bookseller!
        /// A bookseller has lots of books classified in 26 categories labeled A, B, ... Z. Each book has a code c of 3, 4, 5 or more capitals letters. The 1st letter of a code is the capital letter of the book category. In the bookseller's stocklist each code c is followed by a space and by a positive integer n (int n >= 0) which indicates the quantity of books of this code in stock.
        ///In a given stocklist all codes have the same length and all numbers have their own same length (can be different from the code length).
        ///For example an extract of one of the stocklists could be:
        ///L = {"ABART 20", "CDXEF 50", "BKWRK 25", "BTSQZ 89", "DRTYM 60"}.
        ///In this stocklist all codes have a length of five and all numbers have a length of two.
        ///You will be given a stocklist (e.g. : L) and a list of categories in capital letters e.g :
        ///  M = {"A", "B", "C", "W"}
        ///and your task is to find all the books of L with codes belonging to each category of M and to sum their quantity according to each category. You will have first to determine the common length of the codes and the common length of the quantities in L.
        ///For the lists L and M of example you have to return the string (in Haskell/Clojure a list of pairs):
        ///  (A : 20) - (B : 114) - (C : 50) - (W : 0)
        ///where A, B, C, W are the categories, 20 is the sum of the unique book of category A, 114 the sum corresponding to "BKWRK" and "BTSQZ", 50 corresponding to "CDXEF" and 0 to category 'W' since there are no code beginning with W.
        ///If L or M are empty return string is "" (Clojure should return an empty array instead).
        /// 
        /// </summary>
        /// <param name="listOfArt"></param>
        /// <param name="listOfFirstLetter"></param>
        /// <returns></returns> 
        public static string StockSummary(String[] listOfArt, String[] listOfFirstLetter)
        {
            var result = string.Empty;
            if (listOfArt.Length == 0 || listOfFirstLetter.Length == 0)
                return result;
            char ch = ' ';
            int sum = 0;
            for (int i = 0; i < listOfFirstLetter.Length; i++)
            {
                ch = listOfFirstLetter[i].ToCharArray().First();
                foreach (var item in listOfArt)
                {
                    if (ch == item.ToCharArray().First())
                    {
                        sum += Int32.Parse(string.Concat(
                                    String.Concat(item.Where(c => Char.IsNumber(c))
                                        .Aggregate(string.Empty, (current, c) => current + c))));
                    }
                }
                if (i != listOfFirstLetter.Length - 1)
                    result += "(" + ch + " : " + sum + ") - ";
                else
                    result += "(" + ch + " : " + sum + ")";
                sum = 0;
            }
            return result;
        }

        /// <summary>
        /// Get missing element
        /// Fellow code warrior, we need your help! We seem to have lost one of our array elements, and we need your help to retrieve it! Our array, superImportantArray, was supposed to contain all of the integers from 0 to 9 (in no particular order), but one of them seems to be missing.
        ///Write a function called getMissingElement that accepts an array of unique integers between 0 and 9 (inclusive), and returns the missing element.
        ///Examples:
        ///Kata.GetMissingElement( [0, 5, 1, 3, 2, 9, 7, 6, 4] ); // returns 8
        ///Kata.GetMissingElement( [9, 2, 4, 5, 7, 0, 8, 6, 1] ); // returns 3
        /// </summary>
        /// <param name="superImportantArray">input array without some number</param>
        /// <returns>Missing element</returns>
        public static int GetMissingElement(int[] superImportantArray)
        {
            var ideal = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int result = 0;
            Array.Sort(superImportantArray);
            for (int i = 0; i < superImportantArray.Length; i++)
                if (superImportantArray[i] != ideal[i])
                {
                    result = ideal[i];
                    break;
                }
                else
                    result = 9;
            return result;
        }

        /// <summary>
        /// Descending order
        /// Your task is to make a function that can take any non-negative integer as a argument and return it with it's digits in descending order. Descending order means that you take the highest digit and place the next highest digit immediately after it.
        ///Examples:
        ///Input: 145263 Output: 654321
        ///Input: 1254859723 Output: 9875543221
        /// </summary>
        /// <param name="num">Input value</param>
        /// <returns>Descended value</returns>
        public static int DescendingOrder(int num)
        {
            #region ObsoliteCode
            //var arr = num.ToString().ToCharArray();
            //int[] arrOfInts = new int[arr.Length];
            //for (int i = 0; i < arr.Count(); i++)
            //{
            //    arrOfInts[i] = int.Parse(arr[i].ToString());
            //}
            //Array.Sort(arrOfInts);
            //Array.Reverse(arrOfInts);
            //string result = string.Empty;
            //for (int i = 0; i < arrOfInts.Length; i++)
            //{
            //    result += arrOfInts[i];
            //}
            #endregion
            var arr = num.ToString().ToCharArray();
            Array.Sort(arr);
            Array.Reverse(arr);
            var result = string.Empty;
            foreach (var el in arr)
                result += el;
            return Int32.Parse(result);

        }


        /// <summary>
        /// Complete the function circleArea so that it will return the area of a circle with the given radius. Round the returned number to two decimal places (except for Haskell). If the radius is not positive or not a number, return false.
        ///Example:
        ///Kata.CalculateAreaOfCircle("-123"); //throws ArgumentException
        ///Kata.CalculateAreaOfCircle("0"); //throws ArgumentException
        ///Kata.CalculateAreaOfCircle("43.2673"); //return 5881.25
        ///Kata.CalculateAreaOfCircle("68"); //return 14526.72
        ///Kata.CalculateAreaOfCircle("number"); //throws ArgumentException
        /// </summary>
        /// <param name="radius">Input value</param>
        /// <returns>Area of the circle</returns>
        public static double CalculateAreaOfCircle(string radius)
        {
            var r = 0.0;
            var result = 0.0;
            if (!double.TryParse(radius, out r)
                || r == 0.0
                || r < 0
                || radius.ToCharArray().Contains(','))
                throw new ArgumentException();
            result = Math.PI * r * r;
            return Math.Round(result, 2);
        }

        /// <summary>
        /// Write a function that takes in a binary string and returns the equivalent decoded text (the text is ASCII encoded).
        ///Each 8 bits on the binary string represent 1 character on the ASCII table.
        ///The input string will always be a valid binary string.
        ///Characters can be in the range from "00000000" to "11111111" (inclusive)
        ///Note: In the case of an empty binary string your function should return an empty string.
        /// </summary>
        /// <param name="binary">Input binary code</param>
        /// <returns>String convertet from bin code</returns>
        public static string BinaryToString(string binary)
        {
            var text = string.Empty;
            if (Equals(string.Empty, binary))
                return text;
            var temp = string.Empty;
            for (int i = 0; i < binary.Length; i++)
            {
                temp += binary[i];
                if (temp.Length == 8)
                {
                    text += (char)(Convert.ToInt32(temp, 2));
                    temp = string.Empty;
                }
            }
            return text;
        }

        /// <summary>
        /// Write a function that can return the smallest value of an array or the index of that value. The function's 2nd parameter will tell whether it should return the value or the index.
        ///Assume the first parameter will always be an array filled with at least 1 number and no duplicates. Assume the second parameter will be a string holding one of two values: 'value' and 'index'.
        ///C# Kata.FindSmallest(new int[]{ 1, 2 , 3, 4, 5}, "value") // => 1 Kata.FindSmallest(new int[]{ 1, 2 , 3, 4, 5}, "index") // => 0
        /// </summary>
        /// <param name="numbers">Input array</param>
        /// <param name="toReturn">What to return?</param>
        /// <returns>Index or element</returns>
        public static int FindSmallest(int[] numbers, string toReturn)
        {
            int smallestValue = numbers[0], smallestIndex = 0, result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (smallestValue > numbers[i])
                {
                    smallestValue = numbers[i];
                    smallestIndex = i;
                }
            }
            if (Equals("value", toReturn))
                result = smallestValue;
            else
                result = smallestIndex;
            return result;
        }

        /// <summary>
        /// In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.
        ///Example:
        ///Kata.HighAndLow("1 2 3 4 5"); // return "5 1"
        ///Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
        ///Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
        ///Notes:
        ///All numbers are valid Int32, no need to validate them.
        ///There will always be at least one number in the input string.
        ///Output string must be two numbers separated by a single space, and highest number is first.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static string HighAndLow(string numbers)
        {
            var chars = numbers.Split(' ');
            var ints = new int[chars.Length];
            for (int i = 0; i < chars.Length; i++)
                ints[i] = Convert.ToInt32(chars[i]);
            Array.Sort(ints);
            return string.Concat(ints.Last() + " " + ints.First());
        }



        /// <summary>
        /// Write a function that will encrypt a given sentence into International Morse Code, both the input and out puts will be strings.
        ///Characters should be separated by a single space. Words should be separated by a triple space.
        ///For example, "HELLO WORLD" should return -> ".... . .-.. .-.. --- .-- --- .-. .-.. -.."
        ///To find out more about Morse Code follow this link: https://en.wikipedia.org/wiki/Morse_code
        ///A preloaded object/dictionary/hash called CHAR_TO_MORSE will be provided to help convert characters to Morse Code.
        /// </summary>
        /// <param name="englishStr">String in English</param>
        /// <returns>String in Morse code</returns>
        public static string ToMorse(string englishStr)
        {
            var arr = englishStr.ToLower().ToCharArray();
            var result = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                foreach (var key in Preloaded.CHAR_TO_MORSE.Keys)
                {
                    if (key == arr[i])
                        result += Preloaded.CHAR_TO_MORSE[key];
                }
                if (i != arr.Length - 1)
                    result += ' ';

                if (arr[i] == ' ')
                    result += ' ';
            }
            return result;
        }

        /// <summary>
        /// Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)
        ///HH = hours, padded to 2 digits, range: 00 - 99
        ///MM = minutes, padded to 2 digits, range: 00 - 59
        ///SS = seconds, padded to 2 digits, range: 00 - 59
        ///The maximum time never exceeds 359999 (99:59:59)
        ///You can find some examples in the test fixtures.
        /// </summary>
        /// <param name="seconds">Input value</param>
        /// <returns>Time value in format HH:MM:SS</returns>
        public static string GetReadableTime(int seconds)
        {
            int hours = 0, mins = 0, sec = 0;
            string result = string.Empty;
            hours = seconds / 3600;
            mins = (seconds % 3600) / 60;
            sec = seconds % 60;
            result += hours > 9 ? hours + ":" : "0" + hours + ":";
            result += mins > 9 ? mins + ":" : "0" + mins + ":";
            result += sec > 9 ? sec.ToString() : "0" + sec.ToString();
            return result;
        }

        /// <summary>
        /// Valid braces
        ///Write a function called validBraces that takes a string of braces, and determines if the order of the braces is valid.validBraces should return true if the string is valid, and false if it's invalid.
        ///This Kata is similar to the Valid Parentheses Kata, but introduces four new characters.Open and closed brackets, and open and closed curly braces.Thanks to @arnedag for the idea!
        ///All input strings will be nonempty, and will only consist of open parentheses '(' , closed parentheses ')', open brackets '[', closed brackets ']', open curly braces '{' and closed curly braces '}'.
        ///What is considered Valid? A string of braces is considered valid if all braces are matched with the correct brace.
        ///For example:
        ///'(){}[]' and '([{}])' would be considered valid, while '(}', '[(])', and '[({})](]' would be considered invalid.
        /// </summary>
        /// <param name="braces">Input string wiht braces</param>
        /// <returns>If input string valid -> true else false</returns>
        public static bool ValidBraces(string braces)
        {
            bool result = false;
            var openBraces = new List<char>();
            var closeBraces = new List<char>();
            for (int i = 0; i < braces.Length; i++)
            {
                if (braces[i] == '(' || braces[i] == '[' || braces[i] == '{')
                    openBraces.Add(braces[i]);
                if (braces[i] == ')' || braces[i] == ']' || braces[i] == '}')
                    closeBraces.Add(braces[i]);                
            }
            closeBraces.Reverse();
            string temp = string.Empty;
            if (closeBraces.Count() == openBraces.Count())
            {
                for(int i = 0; i < openBraces.Count(); i++)
                {
                    temp = openBraces[i].ToString() + closeBraces[i].ToString();
                    if (Equals(temp, "()") || Equals(temp, "[]") || Equals(temp, "{}"))
                        result = true;
                    else
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }

        /// <summary>
        /// Sum string as number
        ///Given the string representations of two integers, return the string representation of the sum of those integers.
        ///For example:
        ///sumStrings('1','2') // => '3'
        ///C# sumStrings("1","2") // => "3"
        ///A string representation of an integer will contain no characters besides the ten numerals "0" to "9".
        /// </summary>
        /// <param name="a">First num</param>
        /// <param name="b">Second num</param>
        /// <returns>a+b</returns>
        public static string SumStrings(string a, string b)
        {
            string result = string.Empty;
            var num1 = a.ToList();
            var num2 = b.ToList();

            if (num1.Count() != num2.Count())
            {
                int count1 = num1.Count(),count2=num2.Count();
                if (count1 > count2)
                {
                    for (int i = 0; i < count1 - count2; i++)
                        num2.Insert(0,'0');                    
                }

                if (count1 < count2)
                {
                    for (int i = 0; i < count2 - count1; i++)
                        num1.Insert(0,'0');
                }
            }

            int op1 = 0, op2 = 0, tempRes = 0, p = 0;
            for (int i = num1.Count() - 1; i > -1; i--)
            {
                op1 = int.Parse(num1[i].ToString());
                op2 = int.Parse(num2[i].ToString());
                tempRes = op1 + op2 + p;
                p = 0;
                if (tempRes > 9)
                {
                    p = 1;
                    tempRes = tempRes % 10;
                }
                result += tempRes;
            }
            if (p > 0)
                result += p;
            
            var sum = result.ToList().Reverse<char>().ToList();
            for (int i=0;i<sum.Count();i++)
            {
                var value = Int32.Parse(result[i].ToString());
                if (value > 0)
                    break;
                sum.RemoveAt(i);
            }

            return result = string.Concat(sum);
        }

        #region BetaKatas

        public static string TugOWar(int[][] teams)
        {
            string result = string.Empty;
            var firstTeam = new List<int>();
            var secondTeam = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                firstTeam.Add(teams[0][i]);
            }
            for (int i = 0; i < 5; i++)
            {
                secondTeam.Add(teams[1][i]);
            }
            if (firstTeam.Sum() == secondTeam.Sum())
            {
                secondTeam.Reverse();
                bool areEqual = false;
                for (int i = firstTeam.Count() - 1; i > -1; i--)
                {
                    if (firstTeam[i] == secondTeam[i])
                        areEqual = true;
                    else
                    {
                        result = (firstTeam[i] > secondTeam[i]) ? "Team 1 wins!" : "Team 2 wins!";
                        break;
                    }
                }
                if (areEqual)
                    result = "It's a tie!";
            }
            else
                result = (firstTeam.Sum() > secondTeam.Sum()) ? "Team 1 wins!" : "Team 2 wins!";
            return result;
        }

        public static string IntToBin(int num)
        {
            return Convert.ToString(num, 2);
        }

        #endregion
    }


    public class ArgumentException : Exception
    {
    }

    public class Preloaded
    {
        public static Dictionary<char, string> CHAR_TO_MORSE = new Dictionary<char, string>()
            {
                {'0', "-----"}, {'1', ".----"}, {'2', "..---"},
                {'3', "...--"}, {'4', "....-"}, {'5', "....."},
                {'6', "-...."}, {'7', "--..."}, {'8', "---.."},
                {'9', "----."},
                {'a', ".-"},    {'b', "-..."},  {'c', "-.-."},
                {'d', "-.."},   {'e', "."},
                {'f', "..-."},  {'g', "--."},   {'h', "...."},
                {'i', ".."},    {'j', ".---"},  {'k', "-.-"},
                {'l', ".-.."},  {'m', "--"},    {'n', "-."},
                {'o', "---"},   {'p', ".--."},  {'q', "--.-"},
                {'r', ".-."},   {'s', "..."},   {'t', "-"},
                {'u', "..-"},   {'v', "...-"},  {'w', ".--"},
                {'x', "-..-"},  {'y', "-.--"},  {'z', "--.."}
            };
    }
}