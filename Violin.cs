namespace csharp_money_homework;

public class Violin : MusicalInstrument
{
    public Violin() : base("Скрипка")
    {
        Description = "Тестовое описание для Скрипки";
        OriginHistory = "Тестовая история для Скрипки";
    }

    public override void Desc() => Console.WriteLine(Description);
    public override void History() => Console.WriteLine(OriginHistory);

    public override void Show() => Console.WriteLine($"{Name}");
}
