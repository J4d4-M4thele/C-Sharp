using Ch04Ex02PrimeFactorsLib;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Xunit;

namespace Ch04Ex02PrimeFactorsTests
{
    public class PrimesUnitTests
    {
        [Fact]
        public void TestFactorsOf40 ()
        {
            int num = 40;
            string expected = "5 x 2 x 2 x 2";

            // act
            string actual = Primes.PrimeFactors(num);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestFactorsOf519()
        {
            // arrange
            int number = 519;
            string expected = "173 x 3";

            // act
            string actual = Primes.PrimeFactors(number);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}