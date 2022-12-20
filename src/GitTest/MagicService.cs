using GitTest.Abstractions;

namespace GitTest;

public class MagicService : IMagicService
{
    public string GetMagicString()
    {
        return "Magic string";
    }
}