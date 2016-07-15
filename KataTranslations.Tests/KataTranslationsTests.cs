using System;
using NUnit.Framework;

namespace Kata.Tests
{
    [TestFixture]
    public class KataTranslationsTests
    {
        [TestCase(new[]{"code", "wars"}, "codewars", true)]
        [TestCase(new[]{"code", "wars"}, "codewar", false)]
        [TestCase(new [] {"wars", "code"}, "codewars", true)]
        [TestCase(new [] {"code", "wars"}, "codecodewars", true)]
        [TestCase(new [] {"code", "star", "wars"}, "starwars", true)]
        [TestCase(new string [] {}, "codewars", false)]
        [TestCase(new[] {"code", "wars"}, "code", true)]
        [TestCase(new[] {"a", "b", "c", "d", "e", "f"}, "abcdef", true)]
        [TestCase(new[] {"a", "b", "c", "d", "e", "f"}, "abcdefg", false)]
        [TestCase(new string [] {"ab", "a", "bc"}, "abc", true)]
        public void ValidStringBasicTest(string[] dictionary, string word, bool expected)
        {
            //Assert
            Assert.AreEqual(expected, Kata.ValidateString(dictionary, word));
        }

        [TestCase(10, 5, 20)]
        [TestCase(20, 20, 190)]
        [TestCase(15, 10, 60)]
        public void SumOfManyIntsSimpleTest(long n, long m, long expected)
        {
            //Assert 
            Assert.AreEqual(expected, Kata.SumOfManyInts(n, m));
        }

        [Test]
        public void SumOfManyIntsAdvansedTest([Random(1, Int32.MaxValue, 10)] long n, [Random(1, Int32.MaxValue, 10)]long m)
        {
            //Arrange 
            Func<long, long> sum = s => (s * (s + 1)) / 2;
            long expected = sum(m - 1) * (n / m) + sum(n % m);
            
            //Assert 
            Assert.AreEqual(expected, Kata.SumOfManyInts(n, m));
        }

        [TestCase("", false)]
        [TestCase("12.b.3.a", false)]
        [TestCase("abc.def.ghi.jkl", false)]
        [TestCase("123.456.789.0", false)]
        [TestCase("12.34.56", false)]
        [TestCase("256.1.2.3", false)]
        [TestCase("1.2.3.4.5", false)]
        [TestCase("123,45,67,89", false)]
        [TestCase(" 1.2.3.4", false)]
        [TestCase("1.2.3.4 ", false)]

        [TestCase("127.0.0.1", true)]
        [TestCase("1.1.1.1", true)]
        [TestCase("4.4.4.4", true)]
        [TestCase("255.255.255.255", true)]
        [TestCase("192.168.0.1", true)]
        [TestCase("255.0.1.0", true)]
        [TestCase("54.2.2.2", true)]
        [TestCase("1.2.3.4", true)]
        [TestCase("255.127.63.31", true)]
        [TestCase("32.64.128.255", true)]
        public void IpValidationTest(string ip, bool isValid)
        {
            Assert.AreEqual(isValid, Kata.IpValidator(ip));
        }
    }
}
