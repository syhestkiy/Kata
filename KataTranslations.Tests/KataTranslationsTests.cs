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
    }
}
