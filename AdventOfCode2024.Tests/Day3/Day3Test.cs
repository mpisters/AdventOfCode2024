using NuGet.Frameworks;

namespace AdventOfCode2024.Tests.Day3;

public class Day3Test : ITest
{
    [Fact]
    public void ShouldReturnResultExamplePart1()
    {
        var result = Sut().GetTotalMultiplied("input_example.txt");
        Assert.Equal(161, result);
    }

    [Fact]
    public void ShouldReturnResultPart1()
    {
        var result = Sut().GetTotalMultiplied("input.txt");
        Assert.Equal(183380722, result);
    }

    [Fact]
    public void ShouldReturnResultExamplePart2()
    {
        var result = Sut().GetTotalMultipliedWithCommandos("input_example_part2.txt");
        Assert.Equal(48, result);
    }

    [Fact]
    public void ShouldReturnResultPart2()
    {
        var result = Sut().GetTotalMultipliedWithCommandos("input.txt");
        Assert.Equal(83546082, result);
    }

    private Solutions.Day3.Day3 Sut() => new Solutions.Day3.Day3();
}