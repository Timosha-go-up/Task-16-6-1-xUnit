using Task_16_6_1_xUnit;
namespace Task_16_6_1_xUnit_Tests
{
    public class CalculatorTest
    {

        [Fact]
        public void Additional_MustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.Equal(110, calculator.Additional(100, 10));
        }

        [Fact]
        public void Subtraction_MustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.Equal(90, calculator.Subtraction(100, 10));
        }
        
        [Fact]
        public void Multiplication_MustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.Equal(1000, calculator.Miltiplication(100, 10));
        }

        [Fact]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.Equal(10, calculator.Division(100, 10));
        }
    }
}