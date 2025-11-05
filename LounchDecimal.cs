using csharp_money_homework;

public class LouncDecimalLogic()
{
    public void Lounch()
    {
        var decimalNumber = new DecimalNumber(150);
        Console.WriteLine($"DecimalNumber = {decimalNumber.Value}");

        Console.ReadKey();
    }
}
