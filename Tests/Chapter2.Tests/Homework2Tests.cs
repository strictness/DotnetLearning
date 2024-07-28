using System.Diagnostics.CodeAnalysis;
using Homework1and2;
using Wrapper.Console;

namespace Chapter2.Tests;


[ExcludeFromCodeCoverage]
public class Homework2Tests
{
    private readonly Mock<IConsole> _mockConsole = SetupMockConsole();

    [Fact]
    public void ReadsInputs_WhenInvoked_ReturnsDictionaryWithInputs()
    {
        // Arrange
        // Act
        var result = Program.ReadInputs(_mockConsole.Object);

        // Assert
        Assert.Equal("Tom", result["name"]);
        Assert.Equal("Jefferson", result["surname"]);
        Assert.Equal("19", result["age"]);
        Assert.Equal("50", result["weight"]);
        Assert.Equal("156.5", result["height"]);
    }

    [Fact]
    public void ReadsInputs_WhenInvokedWithNullValue_ThrowsArgumentException()
    {
        // Arrange
        _mockConsole.Setup(x => x.ReadLine()).Returns((string)null!);

        // Act
        void Act() => Program.ReadInputs(_mockConsole.Object);

        // Assert
        Assert.Throws<ArgumentException>(Act);
    }

    [Fact]
    public void PrintInformation_WhenInvoked_PrintsInfoBasedOnInputs()
    {
        // Arrange
        var inputs = new Dictionary<string, string>
        {
            { "name", "Tom" },
            { "surname", "Jefferson" },
            { "age", "19" },
            { "weight", "50" },
            { "height", "156.5" }
        };
        // Act
        Program.PrintInformation(_mockConsole.Object, inputs);

        // Assert
        _mockConsole.Verify(x =>
            x.WriteLine("Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm."));
        _mockConsole.Verify(x =>
            x.WriteLine("Body-mass index (BMI) is: 20.41"));
    }

    [Theory]
    [InlineData("97", "189", 27.15)]
    [InlineData("50", "156.5", 20.41)]
    [InlineData("0", "1", 0)]
    public void GetBMI_WhenInvokedWithWeightAndHeight_ReturnsBMI(string weightInKilograms,
        string heightInCentimeters, double expected)
    {
        // Act
        var result = Program.GetBMI(weightInKilograms, heightInCentimeters);
        var roundedResult = Math.Round(result, 2);

        // Assert
        Assert.Equal(expected, roundedResult);
    }

    private static Mock<IConsole> SetupMockConsole()
    {
        var mockConsole = new Mock<IConsole>();
        mockConsole.SetupSequence(x => x.ReadLine())
            .Returns("Tom")
            .Returns("Jefferson")
            .Returns("19")
            .Returns("50")
            .Returns("156.5");

        return mockConsole;
    }
}