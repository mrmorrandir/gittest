using Microsoft.Extensions.DependencyInjection;

namespace GitTest;

public class MagicConfigurationBuilder
{
    private readonly IServiceCollection _services;
    private readonly List<Action<IServiceCollection>> _configurations = new();

    public MagicConfigurationBuilder(IServiceCollection services)
    {
        _services = services;
    }
    
    public MagicConfigurationBuilder AddConfiguration(Action<IServiceCollection> configure)
    {
        _configurations.Add(configure);
        return this;
    }

    public IServiceCollection Build()
    {
        foreach (var configuration in _configurations)
            configuration(_services);

        return _services;
    }
}