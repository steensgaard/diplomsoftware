using Bunit;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using BlazorDemo.Pages;
using AngleSharp.Common;


namespace BlazorDemo.Tests
{
    public class CalculatorTestDataClass : TestContext
    {
        [Theory, ClassData(typeof(DataClass))]
        public void CalculatorPage_AddNumbers(List<string> inputs)
        {
            // Arrange
            var calculatorComponent = RenderComponent<Calculator>();

            var firstNumber = calculatorComponent.Find("#firstNumber");
            firstNumber.Change(inputs[0]);
            var secondNumber = calculatorComponent.Find("#secondNumber");
            secondNumber.Change(inputs[1]);

            // // Act
            foreach (var button in calculatorComponent.FindAll("button"))
            {
                if (button.TextContent == "Add (+)")
                {
                    button.Click();
                }
            }

            // //Assert
            calculatorComponent.Find("#computationResult input").MarkupMatches("<input readonly=\"\" value=\"" + inputs[2] + "\" >");
        }
    }
}
