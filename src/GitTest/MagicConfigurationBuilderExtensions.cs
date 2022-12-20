using GitTest.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace GitTest;

public static class MagicConfigurationBuilderExtensions
{
    public static void UseMagic(this MagicConfigurationBuilder builder) => builder.AddConfiguration(services => services.AddTransient<IMagicService, MagicService>());
    
    public static void UseAlternateMagic(this MagicConfigurationBuilder builder) => builder.AddConfiguration(services => services.AddTransient<IMagicService, MagicService2>());
    
    public static void UseRealMagic(this MagicConfigurationBuilder builder) => builder.AddConfiguration(services => services
        .AddTransient<IMagicService, RealMagicService>()
        .AddSingleton<IMagicSpellService, MagicSpellService>());
    
}