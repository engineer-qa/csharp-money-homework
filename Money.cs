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

    public (int resultFirstAmount, int resultSecondAmount) SplitAmount(double amount)
    {
        var splitedAmount = amount.ToString().Split(',');
        return splitedAmount.Length > 1
            ? (int.Parse(splitedAmount.First()), int.Parse(splitedAmount.Last()))
            : (int.Parse(splitedAmount.First()), 0);
    }
}
