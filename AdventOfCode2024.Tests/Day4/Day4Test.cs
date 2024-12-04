namespace AdventOfCode2024.Tests.Day4;

public class Day4Test : ITest
{
    [Fact]
    public void ShouldReturnResultExamplePart1()
    {
        var result = Sut().GetTotalXmas("input_example.txt");
        Assert.Equal(18, result);
    }

    [Fact]
    public void ShouldReturnAllDiagnals()
    {
        var result = Sut().GetTotalXmas("input_example2.txt");
        Assert.Equal(4, result);
    }
    
    [Fact]
    public void ShouldReturnAllRightLeft()
    {
        var result = Sut().GetTotalXmas("input_example3.txt");
        Assert.Equal(4, result);
    }
    
    [Fact]
    public void ShouldReturnResultPart1()
    {
        var result = Sut().GetTotalXmas("input.txt");
        Assert.Equal(4, result);
    }

    public void ShouldReturnResultExamplePart2()
    {
        throw new NotImplementedException();
    }

    public void ShouldReturnResultPart2()
    {
        throw new NotImplementedException();
    }
    private Solutions.Day4.Day4 Sut() => new Solutions.Day4.Day4();

}