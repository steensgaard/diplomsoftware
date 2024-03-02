using Bunit;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using BlazorDemo.Pages;
using AngleSharp.Common;

namespace BlazorDemo.Tests
{
    public class CalculatorTest : TestContext
    {
        [Fact]
        public void CalculatorPage_AddNumbers()
        {
            // Arrange
            var calculatorComponent = RenderComponent<Calculator>();

            var firstNumber = calculatorComponent.Find("#firstNumber");
            firstNumber.Change("40");
            var secondNumber = calculatorComponent.Find("#secondNumber");
            secondNumber.Change("2");

            // // Act
            foreach (var button in calculatorComponent.FindAll("button"))
            {
                if (button.TextContent == "Add (+)")
                {
                    button.Click();
                }
            }

            // //Assert
            calculatorComponent.Find("#computationResult input").MarkupMatches("<input readonly=\"\" value=\"42\" >");
        }

        [Fact]
        public void CalculatorPage_SubtractNumbers()
        {
            // Arrange
            var calculatorComponent = RenderComponent<Calculator>();

            var firstNumber = calculatorComponent.Find("#firstNumber");
            firstNumber.Change("40");
            var secondNumber = calculatorComponent.Find("#secondNumber");
            secondNumber.Change("2");

            // // Act
            foreach (var button in calculatorComponent.FindAll("button"))
            {
                if (button.TextContent == "Subtract (−)")
                {
                    button.Click();
                }
            }

            // //Assert
            calculatorComponent.Find("#computationResult input").MarkupMatches("<input readonly=\"\" value=\"38\" >");
        }

        [Fact]
        public void CalculatorPage_MultiplyNumbers()
        {
            // Arrange
            var calculatorComponent = RenderComponent<Calculator>();

            var firstNumber = calculatorComponent.Find("#firstNumber");
            firstNumber.Change("42");
            var secondNumber = calculatorComponent.Find("#secondNumber");
            secondNumber.Change("1");

            // // Act
            foreach (var button in calculatorComponent.FindAll("button"))
            {
                if (button.TextContent == "Multiply (X)")
                {
                    button.Click();
                }
            }

            // //Assert
            calculatorComponent.Find("#computationResult input").MarkupMatches("<input readonly=\"\" value=\"42\" >");
        }

        [Fact]
        public void CalculatorPage_PercentageNumbers()
        {
            // Arrange
            var calculatorComponent = RenderComponent<Calculator>();

            var firstNumber = calculatorComponent.Find("#firstNumber");
            firstNumber.Change("42");
            var secondNumber = calculatorComponent.Find("#secondNumber");
            secondNumber.Change("300");

            // // Act
            foreach (var button in calculatorComponent.FindAll("button"))
            {
                if (button.TextContent == "Percent (%)")
                {
                    button.Click();
                }
            }

            // //Assert
            calculatorComponent.Find("#computationResult input").MarkupMatches("<input readonly=\"\" value=\"126\" >");
        }

        [Fact]
        public void CalculatorPage_RootOfNumbers()
        {
            // Arrange
            var calculatorComponent = RenderComponent<Calculator>();

            var firstNumber = calculatorComponent.Find("#firstNumber");
            firstNumber.Change("2");
            var secondNumber = calculatorComponent.Find("#secondNumber");
            secondNumber.Change("9");

            // // Act
            foreach (var button in calculatorComponent.FindAll("button"))
            {
                if (button.TextContent == "x Root Of y")
                {
                    button.Click();
                }
            }

            // //Assert
            calculatorComponent.Find("#computationResult input").MarkupMatches("<input readonly=\"\" value=\"3\" >");
        }

        [Fact]
        public void CalculatorPage_XLogYNumbers()
        {
            // Arrange
            var calculatorComponent = RenderComponent<Calculator>();

            var firstNumber = calculatorComponent.Find("#firstNumber");
            firstNumber.Change("256");
            var secondNumber = calculatorComponent.Find("#secondNumber");
            secondNumber.Change("2");

            // // Act
            foreach (var button in calculatorComponent.FindAll("button"))
            {
                if (button.TextContent == "x Log base(y)")
                {
                    button.Click();
                }
            }

            // //Assert
            calculatorComponent.Find("#computationResult input").MarkupMatches("<input readonly=\"\" value=\"8\" >");
        }
    }
}
