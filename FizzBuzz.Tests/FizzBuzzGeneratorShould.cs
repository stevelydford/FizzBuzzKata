using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzGeneratorShould
    {
        private FizzBuzzGenerator _fizzBuzzGenerator;

        [SetUp]
        public void SetUp()
        {
            _fizzBuzzGenerator = new FizzBuzzGenerator();
        }

        [Test]
        public void ReturnFizzIfNumberIsDivisibleByThree()
        {
            var result = _fizzBuzzGenerator.Generate(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void ReturnBuzzIfNumberIsDivisibleByFive()
        {
            var result = _fizzBuzzGenerator.Generate(5);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void ReturnFizzBuzzIfNumberIsDivisibleByThreeAndFive()
        {
            var result = _fizzBuzzGenerator.Generate(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void ReturnTheOriginaNumberIfNumberIsNotDivisibleByThreeOrFive()
        {
            var result = _fizzBuzzGenerator.Generate(1);

            Assert.That(result, Is.EqualTo("1"));
        }
    }
}
