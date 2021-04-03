using NUnit.Framework;
using ExpleoDetectAnagramLibrary;

namespace ExpleoDetectAnagramTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("liSTen", "Silent", true)]
        [TestCase("Debit Card", "Bad Credit", true)]
        [TestCase("list2en", "Silent", false)]
        [TestCase("anagram", "Anagram", false)]
        [TestCase("anagram", "a man rag", true)]
        public void Test1(string firstInput, string secondInput, bool expected)
        {

            bool actual = ExpleoDetectAnagram.DetectAnagram(firstInput, secondInput);
            Assert.AreEqual(expected, actual);
        }
    }
}