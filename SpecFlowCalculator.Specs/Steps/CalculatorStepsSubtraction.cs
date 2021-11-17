using System;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public class CalculatorStepsSubtraction
    {

        private readonly Calculator _calculator = new Calculator();
        private int _result;

        [Given(@"The First number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }
        
        [Given(@"The second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }
        
        [When(@"Second number is subtracted from the first number")]
        public void WhenSecondNumberIsSubtractedFromTheFirstNumber()
        {
            _result = _calculator.Subtract();
        }
        
        [Then(@"the result of subtraction should be (.*)")]
        public void ThenTheResultOfSubtractionShouldBe(int result)
        {
            _result.Should().Be(result);
			Console.WriteLine("Wynik: "+_result);
        }
    }
}
