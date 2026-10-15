namespace PatternsLab.Problems.Prototype;

public class Weapon
{
    public string Name { get; set; }
    public int Damage { get; set; }

    public Weapon Clone() => new Weapon { Name = Name, Damage = Damage };

}

public abstract class Enemy
{
    private string _modelData;

    public string Name { get; set; }
    public int Health { get; set; }
    public Weapon Weapon { get; set; }
    public List<string> Abilities { get; set; } = new();
    public string ModelId => _modelData;

    protected Enemy()
    {
        Console.WriteLine("   ...loading 3D model (slow)...");
        Thread.Sleep(500);
        _modelData = "MODEL_" + Guid.NewGuid().ToString("N")[..6];
    }

    // Copy constructor 
    protected Enemy(Enemy other)
    {
        _modelData = other._modelData;
        Name = other.Name;
        Health = other.Health;
        Weapon = other.Weapon.Clone();                 // deep copy
        Abilities = new List<string>(other.Abilities); // deep copy
    }

    public abstract Enemy Clone();
}

public class Orc : Enemy
{
    public Orc()
    {
        Name = "Orc";
        Health = 100;
        Weapon = new Weapon { Name = "Axe", Damage = 25 };
        Abilities.Add("Rage");
    }

    private Orc(Orc other) : base(other) { }

    public override Enemy Clone() => new Orc(this);
}

public class Elf : Enemy
{
    public Elf()
    {
        Name = "Elf";
        Health = 70;
        Weapon = new Weapon { Name = "Bow", Damage = 18 };
        Abilities.Add("Stealth");
    }

    private Elf(Elf other) : base(other) { }

    public override Enemy Clone() => new Elf(this);
}

public class EnemyRegistry
{
    private readonly Dictionary<string, Enemy> _prototypes = new();

    public void Register(string key, Enemy prototype) => _prototypes[key] = prototype;

    public Enemy Create(string key)
    {
        if (!_prototypes.TryGetValue(key, out var proto))
            throw new KeyNotFoundException($"No prototype registered for '{key}'");
        return proto.Clone();
    }
}