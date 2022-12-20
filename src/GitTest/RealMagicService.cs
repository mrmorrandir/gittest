using GitTest.Abstractions;

namespace GitTest;

public class RealMagicService : IMagicService
{
    private readonly IMagicSpellService _magicSpellService;

    public RealMagicService(IMagicSpellService magicSpellService)
    {
        _magicSpellService = magicSpellService;
    }

    public string GetMagicString()
    {
        var (name, description) = _magicSpellService.GetRandomSpell();
        return $"Magic will come from {name} which is used {description.ToLower()}";
    }
}