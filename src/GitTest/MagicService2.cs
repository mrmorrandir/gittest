using GitTest.Abstractions;

namespace GitTest;

public class MagicService2 : IMagicService
{
    public string GetMagicString()
    {
        var number = new Random().Next();
        // Kommentar
        return $"Magic is in the number #{number}!";
    }
}