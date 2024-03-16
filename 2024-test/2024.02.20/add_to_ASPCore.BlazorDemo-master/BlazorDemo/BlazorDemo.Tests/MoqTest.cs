using Bunit;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BlazorDemo;
using BlazorDemo.Pages;
using AngleSharp.Common;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace BlazorDemo.Tests
{
    public class MoqTest : TestContext
    {
        [Fact]
        public void TestingIndexPage()
        {
            // Arrange
            var mock = new Mock<IUserService>();
            mock.Setup(p => p.FetchUser(1)).Returns(new User(1, "Jim Raynor"));
            Services.AddSingleton<IUserService>(mock.Object);

            // Act
            var indexComponent = RenderComponent<BlazorDemo.Pages.Index>();
            
            // Assert
            var h1 = indexComponent.Find("h1").TextContent;
            h1.MarkupMatches("Hello, world! and Welcome to Jim Raynor");
        }
    }
}
