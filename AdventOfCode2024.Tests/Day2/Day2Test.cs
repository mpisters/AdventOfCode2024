namespace AdventOfCode2024.Tests.Day2;

public class Day2Test : ITest
{
    [Fact]
    public void ShouldReturnResultExamplePart1()
    {
        var result = Sut().GetTotalSaveReports("input_example.txt");
        Assert.Equal(2, result);
    }

    [Fact]
    public void ShouldReturnResultPart1()
    {
        var result = Sut().GetTotalSaveReports("input.txt");
        Assert.Equal(672, result);
    }

    public void ShouldReturnResultExamplePart2()
    {
        throw new NotImplementedException();
    }

    public void ShouldReturnResultPart2()
    {
        throw new NotImplementedException();
    }

    private Solutions.Day2.Day2 Sut() => new Solutions.Day2.Day2();
}