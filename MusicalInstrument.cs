namespace csharp_money_homework;

public abstract class MusicalInstrument
{
    public string Name { get; private set; }
    public string Description { get; protected set; }
    public string OriginHistory { get; protected set; }

    protected MusicalInstrument(string name)
    {
        Name = string.IsNullOrWhiteSpace(name)
            ? throw new ArgumentException("Name cannot be empty")
            : name;
    }

    public virtual void Show() => Console.WriteLine($"Инструмент: {Name}");

    public abstract void Desc();
    public abstract void History();
}
