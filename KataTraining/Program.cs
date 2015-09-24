using System;

namespace KataTraining
{
    public class Program
    {
        public static int[] Devide(int n)
        {
            return new[] {n/100, (n%100)/10, n%10};
        }
        public static void Main()
        {//3 10 11 12 999 123 1234 12345 123456 1234567
            DateTime startTime = DateTime.Now;
            //var t1 = Kata.TwistedSum(3);
            //var t2 = Kata.TwistedSum(10);
            //var t3 = Kata.TwistedSum(11);
            //var t4 = Kata.TwistedSum(12);
            //var t5 = Kata.TwistedSum(999);
            //var t6 = Kata.TwistedSum(123);
            //var t7 = Kata.TwistedSum(1234);
            //var t8 = Kata.TwistedSum(12345);
            //var t9 = Kata.TwistedSum(123456);
            //var t10 = Kata.TwistedSum(1234567);
            //var t11 = Kata.TwistedSum(12345678);
            //var t12 = Kata.TwistedSum(123456789);
            //var t13 = Kata.TwistedSum(1234567890);
            //var t10 = Kata.TwistedSum(1234567);

            //todo check this in Internet IS
            //Console.WriteLine(Equals("13 17 31 37 71 73 79 97", Kata.BackwardsPrime(1, 100)));
            //Console.WriteLine(Equals("9923 9931 9941 9967", Kata.BackwardsPrime(9900, 10000)));

            
            Console.WriteLine( Kata.GetReadableTime(86399));

            DateTime endTime = DateTime.Now;
            Console.WriteLine(new TimeSpan(endTime.Ticks - startTime.Ticks));
           
        }
    }
}
