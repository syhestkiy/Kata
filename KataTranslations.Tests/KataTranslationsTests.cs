using System;
using NUnit.Framework;

namespace KataTranslations.Tests
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
            Assert.AreEqual(expected, KataTranslations.ValidateString(dictionary, word));
        }

        [TestCase(10, 5, 20)]
        [TestCase(20, 20, 190)]
        [TestCase(15, 10, 60)]
        public void SumOfManyIntsSimpleTest(long n, long m, long expected)
        {
            //Assert 
            Assert.AreEqual(expected, KataTranslations.SumOfManyInts(n, m));
        }

        [Test]
        public void SumOfManyIntsAdvansedTest([Random(1, Int32.MaxValue, 10)] long n, [Random(1, Int32.MaxValue, 10)]long m)
        {
            //Arrange 
            Func<long, long> sum = s => (s * (s + 1)) / 2;
            long expected = sum(m - 1) * (n / m) + sum(n % m);
            
            //Assert 
            Assert.AreEqual(expected, KataTranslations.SumOfManyInts(n, m));
        }
    }
}
