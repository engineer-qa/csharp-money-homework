namespace csharp_money_homework;

public class Ukulele : MusicalInstrument
{
    public Ukulele() : base("Окулеле")
    {
        Description = "Тестовое описание для Окулеле";
        OriginHistory = "Тестовая история для Окулеле";
    }

    public override void Desc() => Console.WriteLine(Description);
    public override void History() => Console.WriteLine(OriginHistory);

    public override void Show() => Console.WriteLine($"{Name}");
}
