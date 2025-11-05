namespace csharp_money_homework;

public class Product : Money
{
    public string ProductName { get; set; }

    public Product()
    {

    }

    public void GetProductName()
    {
        Console.WriteLine(ProductName);
    }

    public void SetAmount(int mainAmount, int secondAmount, bool isIncreasig)
    {
        if (isIncreasig)
        {
            IncreaseAmount(mainAmount, secondAmount);
            return;
        }
        DecreaseAmount(mainAmount, secondAmount);
    }

    private void IncreaseAmount(int mainAmount, int secondAmount)
    {
        int currentTotalCents = MainAmount * 100 + SecondAmount;
        int subtractTotalCents = mainAmount * 100 + secondAmount;

        int newTotalCents = currentTotalCents + subtractTotalCents;

        MainAmount = newTotalCents / 100;
        SecondAmount = newTotalCents % 100;
    }

    private void DecreaseAmount(int mainAmount, int secondAmount)
    {
        int currentTotalCents = MainAmount * 100 + SecondAmount;
        int subtractTotalCents = mainAmount * 100 + secondAmount;

        if (subtractTotalCents > currentTotalCents && currentTotalCents == 0)
        {
            Console.WriteLine("Нельзя уменьшить сумму ниже нуля!");
            MainAmount = 0;
            SecondAmount = 0;
            return;
        }
        else if (subtractTotalCents > currentTotalCents)
        {
            Console.WriteLine("Сумма не может быть с отрицательным значением!");
            return;
        }

        int newTotalCents = currentTotalCents - subtractTotalCents;

        MainAmount = newTotalCents / 100;
        SecondAmount = newTotalCents % 100;
    }
}