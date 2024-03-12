using Bunit;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using BlazorDemo.Pages;
using AngleSharp.Common;


namespace BlazorDemo.Tests
{
    public class CalculatorTestInline : TestContext
    {
        [
            Theory,
            InlineData("1", "2", "3"),
            InlineData("2", "4", "6"),
        ]
        public void CalculatorPage_AddNumbers(string x, string y, string result)
        {
            // Arrange
            var calculatorComponent = RenderComponent<Calculator>();

            var firstNumber = calculatorComponent.Find("#firstNumber");
            firstNumber.Change(x);
            var secondNumber = calculatorComponent.Find("#secondNumber");
            secondNumber.Change(y);

            // // Act
            foreach (var button in calculatorComponent.FindAll("button"))
            {
                if (button.TextContent == "Add (+)")
                {
                    button.Click();
                }
            }

            // //Assert
            calculatorComponent.Find("#computationResult input").MarkupMatches("<input readonly=\"\" value=\"" + result + "\" >");
        }
    }
}
