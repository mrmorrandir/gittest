namespace GitTest.UnitTests;

public class RealMagicServiceTests
{
    [Fact]
    public void ShouldReturnMagicString_WhenCalled()
    {
        var magicService = new RealMagicService(new MagicSpellService());
        var result = magicService.GetMagicString();
        result.Should().Match("Magic will come from*which is used*");
    }
}