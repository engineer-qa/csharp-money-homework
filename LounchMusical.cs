using csharp_money_homework;

public class LounchMusicalLogic()
{
    public void Lounch()
    {
        List<MusicalInstrument> orchestra = new()
        {
            new Violin(),
            new Trombone(),
            new Ukulele(),
            new Cello()
        };

        Console.WriteLine("Полиморфный вызов всех инструментов");

        foreach (var instrument in orchestra)
        {
            instrument.Show();
            instrument.Desc();
            instrument.History();
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
