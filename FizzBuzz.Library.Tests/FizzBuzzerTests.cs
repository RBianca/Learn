using NUnit.Framework;
using System;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void Buzzer_When1_Returns1()
        {
            //Arange
            int input = 1;
            //Act
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("1", output);

        }
        public void Buzzer_When2_Returns2()
        {
            int input = 2;
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("2", output);

        }
        public void Buzzer_When3_Returns3()
        {
            int input = 3;
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);

        }

    }
}
