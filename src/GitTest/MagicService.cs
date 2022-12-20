using GitTest.Abstractions;

namespace GitTest;

public class MagicService : IMagicService
{
    public string GetMagicString()
    {
        // Thats so true
        return "Magic is everywhere";
    }
}