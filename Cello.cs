namespace csharp_money_homework
{
    public class Cello : MusicalInstrument
    {
        public Cello() : base("Виолончель")
        {
            Description = "Тестовое описание для Виолончели";
            OriginHistory = "Тестовая история для Виолончели";
        }

        public override void Desc() => Console.WriteLine(Description);
        public override void History() => Console.WriteLine(OriginHistory);

        public override void Show() => Console.WriteLine($"{Name}");
    }
}
