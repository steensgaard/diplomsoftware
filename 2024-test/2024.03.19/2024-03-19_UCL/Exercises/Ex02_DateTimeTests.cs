using FluentAssertions;
using FluentAssertions.Common;
using FluentAssertions.Extensions;
using System;
using Xunit;

namespace Exercises;

public class Ex02_DateTimeTests
{
    [Fact]
    public void In_2024_Easter_Sunday_Falls_On_March_31st()
    {
        // Arrange
        var expected = 31.March(2024);

        // Act
        DateTime date = EasterSunday();

        // Assert
        date.Should().Be(expected);
    }

    [Fact]
    public void The_start_of_this_presentation_is_within_5_minutes_of_the_scheduled_time()
    {
        // Arrange
        var expectedStartOfLecture = 19.March(2024).At(08.Hours(30.Minutes()));

        // Act
        DateTime date = StartOfThisPresentation();

        // Assert
        date.Should().BeWithin(5.Minutes());

    }

    [Fact]
    public void In_2024_Danish_daylight_saving_time_ends_27th_of_October_at_0300_GMT_Plus2()
    {
        // Express expectedEndOfDst using the Fluent API from FluentAssertions.Extensions
        // See https://fluentassertions.com/datetimespans/ for examples

        // Arrange
        DateTimeOffset expectedEndOfDst = 27.October(2024).At(3, 0).WithOffset(2.Hours());

        // Act
        DateTimeOffset date = DaylightSavingTimeEnd();

        // Assert
        date.Should().Be(expectedEndOfDst);
    }

    #region Helpers
    private static DateTime EasterSunday() => new(2024, 03, 31);

    private static DateTime StartOfThisPresentation() => new DateTime(2024, 03, 19, 08, 30, 00).AddMinutes(new Random().Next(-5, 5));

    private static DateTimeOffset DaylightSavingTimeEnd() => new(2024, 10, 27, 03, 00, 00, TimeSpan.FromHours(2));
    #endregion
}
