namespace GitTest.UnitTests;

public class MagicServiceTests
{
    [Fact]
    public void ShouldReturnMagicString_WhenCalled()
    {
        var magicService = new MagicService();
        
        var result = magicService.GetMagicString();
        
        result.Should().StartWith("Magic");
    }
}