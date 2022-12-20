namespace GitTest.UnitTests;

public class MagicService3Tests
{
    [Fact]
    public void ShouldReturnMagicString_WhenCalled()
    {
        var magicService = new MagicService3();
        
        var result = magicService.GetMagicString();
        
        result.Should().Match("*number*");
    }
}