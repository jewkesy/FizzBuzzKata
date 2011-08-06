
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace FizzBuzzKata.Tests
{
    public class ProgramTest
    {
        private readonly Program _fizzBuzzKata = new Program();
        private IList<String> _sut;

        [TestFixtureSetUp]
        public void SetupFixture()
        {
            _sut = _fizzBuzzKata.PlayGame(100);
        }

        [Test]
        public void TestThatDivisbleBy3ReturnsFizz()
        {
            Assert.That(_sut[2], Is.EqualTo("Fizz"));
        }

        [Test]
        public void TestThatDivisibleBy5ReturnsBuzz()
        {
            Assert.That(_sut[4], Is.EqualTo("Buzz"));
        }

        [Test]
        public void TestThatDivisbleBy3And5ReturnsFizzBuzz()
        {
            Assert.That(_sut[14], Is.EqualTo("FizzBuzz"));
        }
        
        [Test]
        public void TestThatNumericsAreReturnedforAKnownNumber()
        {
            Assert.That(_sut[0], Is.EqualTo("1"));
        }

        [Test]
        public void TestThatAKnownNumericReturnedIsStringFormat()
        {
            Assert.That(_sut[0], Is.EqualTo("1"));
            Assert.That(_sut[0], Is.Not.EqualTo(1));
        }

        [Test]
        public void TestThatNumberOfRecordsReturnedMatchesInputNumber()
        {
            IList<String> sut = _fizzBuzzKata.PlayGame(20);
            Assert.That(sut.Count, Is.EqualTo(20));
        }

        [Test]
        public void TestThatNegativeNumberPassedThrowsException()
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => _fizzBuzzKata.PlayGame(-5));
            Assert.AreEqual("noRecords must be greater than zero", exception.Message);
        }

        [Test]
        public void TestThatZeroNumberPassedThrowsException()
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => _fizzBuzzKata.PlayGame(-5));
            Assert.AreEqual("noRecords must be greater than zero", exception.Message);
        }

        [Test]
        public void TestThatPositiveNumberPassedReturnsAPopulatedList()
        {
            Assert.That(_sut.Count, Is.GreaterThan(0));
        }

        [Test]
        public void TestThatWeIncrementByOne()
        {
            Assert.That(_sut[0], Is.EqualTo("1"));
            Assert.That(_sut[1], Is.EqualTo("2"));
            Assert.That(_sut[97], Is.EqualTo("98"));
        }
    }
}
