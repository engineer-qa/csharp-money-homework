namespace csharp_money_homework;

public class Trombone : MusicalInstrument
{
    public Trombone() : base("Трамбон")
    {
        Description = "Тестовое описание для Трамбона";
        OriginHistory = "Тестовая история для Трамбона";
    }

    public override void Desc() => Console.WriteLine(Description);
    public override void History() => Console.WriteLine(OriginHistory);

    public override void Show() => Console.WriteLine($"{Name}");
}
