namespace GitTest;

public record MagicSpell(string Name, string Description)
{
    // Deconstruct method
    public void Deconstruct(out string name, out string description)
    {
        name = Name;
        description = Description;
    }
}