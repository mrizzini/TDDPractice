using NUnit.Framework;
using FizzBuzz.Service;

// using FizzBuzzService;

namespace Tests
{
    [TestFixture]
        public class FizzBuzzerTests
        {
            [Test]
            public void Buzzer_When1_Returns1()
            {
                // Arrange
                int input = 1;

                // Act
                string output = FizzBuzzer.GetValue(input); 

                // Assert
                Assert.AreEqual("1", output);
            }

            [Test]
            public void Buzzer_When2_Returns2()
            {
                int input = 2;

                //Act
                string output = FizzBuzzer.GetValue(input);

                // Assert
                Assert.AreEqual("2", output);
            }

            [Test]
            public void Buzzer_WhenDiv3_ReturnsFizz()
            {
                int input = 3;

                //Act
                string output = FizzBuzzer.GetValue(input);

                // Assert
                Assert.AreEqual("Fizz", output);
            }

            [Test]
            public void Buzzer_WhenDiv5_ReturnsBuzz()
            {
                int input = 5;

                //Act
                string output = FizzBuzzer.GetValue(input);

                // Assert
                Assert.AreEqual("Buzz", output);
            }

            [Test]
            public void Buzzer_WhenDiv3And5_ReturnsFizzBuzz()
            {
                int input = 15;

                //Act
                string output = FizzBuzzer.GetValue(input);

                // Assert
                Assert.AreEqual("FizzBuzz", output);
            }

        }
}