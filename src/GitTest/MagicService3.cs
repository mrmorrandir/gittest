using GitTest.Abstractions;

namespace GitTest;

public class MagicService3 : IMagicService
{
    public string GetMagicString()
    {
        var number = new Random().Next();
        // Comment for the magic string
        return $"A number #{number} is magic!";
    }
}