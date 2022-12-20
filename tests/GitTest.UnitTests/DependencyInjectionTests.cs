using GitTest.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace GitTest.UnitTests;

public class DependencyInjectionTests
{
    [Fact]
    public void ShouldRegisterRealMagicService_WhenConfigurationUseRealMagic()
    {
        var services = new ServiceCollection();
        services.AddMagic(config => config.UseRealMagic());
        var serviceProvider = services.BuildServiceProvider();
        var magicService = serviceProvider.GetService<IMagicService>();
        magicService.Should().BeOfType<RealMagicService>();
    }

    [Fact]
    public void ShouldRegisterMagicService_WhenConfigurationUseMagic()
    {
        var services = new ServiceCollection();
        services.AddMagic(config => config.UseMagic());
        var serviceProvider = services.BuildServiceProvider();
        var magicService = serviceProvider.GetService<IMagicService>();
        magicService.Should().BeOfType<MagicService>();
    }
    
    [Fact]
    public void ShouldRegisterMagicService2_WhenConfigurationUseAlternateMagic()
    {
        var services = new ServiceCollection();
        services.AddMagic(config => config.UseAlternateMagic());
        var serviceProvider = services.BuildServiceProvider();
        var magicService = serviceProvider.GetService<IMagicService>();
        magicService.Should().BeOfType<MagicService2>();
    }
}