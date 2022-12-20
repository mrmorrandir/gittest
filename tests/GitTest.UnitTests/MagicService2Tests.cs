namespace GitTest.UnitTests;

public class MagicService2Tests
{
    [Fact]
    public void ShouldReturnMagicString_WhenCalled()
    {
        var magicService = new MagicService2();
        
        var result = magicService.GetMagicString();
        
        result.Should().Match("*Magic*number*");
    }
}