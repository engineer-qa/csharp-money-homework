namespace csharp_money_homework;

public class Money
{
    public int MainAmount { get; set; }
    public int SecondAmount { get; set; }

    public (bool resultIsCorrect, int resultAmount) ValidateAmount(string? amount)
    {
        bool resultIsCorrect = int.TryParse(amount, out int resultAmount);
        return (resultIsCorrect, resultAmount);
    }
    public void GetAmount()
    {
        Console.WriteLine($"Текущее состояние: {MainAmount},{SecondAmount}грн");
    }
}
