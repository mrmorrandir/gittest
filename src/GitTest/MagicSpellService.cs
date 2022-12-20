namespace GitTest;

public class MagicSpellService : IMagicSpellService
{
    private readonly List<MagicSpell> _spells;

    public MagicSpellService()
    {
        // A List of 50 MagicSpell records with name and description - all from the Harry Potter series
        // https://www.pottermore.com/writing-by-jk-rowling/magic-spells
        _spells = new List<MagicSpell>()
        {
            new MagicSpell("Accio", "To summon objects from a distance"),
            new MagicSpell("Aguamenti", "To conjure water from the air"),
            new MagicSpell("Alohomora", "To unlock a door or chest"),
            new MagicSpell("Anapneo", "To breathe underwater"),
            new MagicSpell("Aparecium", "To reveal hidden writing or objects"),
            new MagicSpell("Avada Kedavra", "To kill instantly"),
            new MagicSpell("Avis", "To conjure a flock of birds"),
            new MagicSpell("Colloportus", "To lock a door or chest"),
            new MagicSpell("Confringo", "To cause an explosion"),
            new MagicSpell("Confundo", "To confuse the target"),
            new MagicSpell("Crucio", "To cause extreme pain"),
            new MagicSpell("Descendo", "To descend quickly"),
            new MagicSpell("Diffindo", "To cut through solid objects"),
            new MagicSpell("Dissendium", "To hide objects"),
            new MagicSpell("Duro", "To harden objects"),
            new MagicSpell("Engorgio", "To enlarge objects"),
            new MagicSpell("Episkey", "To heal minor injuries"),
            new MagicSpell("Evanesco", "To make objects disappear"),
            new MagicSpell("Expecto Patronum", "To conjure a Patronus"),
            new MagicSpell("Expelliarmus", "To disarm the target"),
            new MagicSpell("Expulso", "To expel objects"),
            new MagicSpell("Ferula", "To heal broken bones"),
            new MagicSpell("Finite Incantatem", "To end a spell"),
            new MagicSpell("Flagrate", "To set things on fire"),
            new MagicSpell("Flipendo", "To cause objects to flip"),
            new MagicSpell("Glisseo", "To slide across a surface"),
            new MagicSpell("Homenum Revelio", "To reveal hidden people"),
            new MagicSpell("Impedimenta", "To cause objects to trip"),
            new MagicSpell("Imperio", "To control the target"),
            new MagicSpell("Impervius", "To make objects waterproof"),
            new MagicSpell("Incendio", "To set things on fire"),
            new MagicSpell("Langlock", "To cause the target to speak Parseltongue"),
            new MagicSpell("Levicorpus", "To levitate the target"),
            new MagicSpell("Liberacorpus", "To free the target from a levitation spell"),
            new MagicSpell("Locomotor Mortis", "To cause the target to move uncontrollably"),
            new MagicSpell("Lumos", "To light a wand"),
            new MagicSpell("Lumos Solem", "To light up the sky"),
            new MagicSpell("Meteolojinx Recanto", "To cause a rainstorm"),
            new MagicSpell("Mobiliarbus", "To make objects move"),
            new MagicSpell("Mobilicorpus", "To move the target's body"),
            new MagicSpell("Morsmordre", "To cause the target to die"),
            new MagicSpell("Nox", "To extinguish a wand"),
            new MagicSpell("Obliviate", "To erase a person's memory"),
            new MagicSpell("Oppugno", "To cause objects to attack"),
            new MagicSpell("Petrificus Totalus", "To paralyse the target"),
            new MagicSpell("Priori Incantatem", "To reveal the previous incantation"),
            new MagicSpell("Protego", "To protect the target from spells"),
            new MagicSpell("Reducto", "To break solid objects"),
            new MagicSpell("Rennervate", "To restore energy to the target"),
            new MagicSpell("Reparo", "To repair objects"),
            new MagicSpell("Revelio", "To reveal hidden objects"),
            new MagicSpell("Rictusempra", "To cause the target to laugh uncontrollably"),
            new MagicSpell("Riddikulus", "To cause the target to laugh uncontrollably"),
            new MagicSpell("Ridikulus", "To cause the target to laugh uncontrollably"),
            new MagicSpell("Scourgify", "To clean objects"),
            new MagicSpell("Silencio", "To cause the target to become silent"),
            new MagicSpell("Sonorus", "To amplify the sound of the target's voice"),
            new MagicSpell("Stupefy", "To stun the target"),
            new MagicSpell("Tarantallegra", "To cause the target to dance uncontrollably"),
            new MagicSpell("Waddiwasi", "To cause the target to vomit"),
            new MagicSpell("Wingardium Leviosa", "To levitate objects"),
            new MagicSpell("Zonko's Joke Solution", "To make objects fly"),
        };
    }

    public MagicSpell GetRandomSpell()
    {
        var random = new Random();
        var index = random.Next(_spells.Count);
        return _spells[index];
    }
}