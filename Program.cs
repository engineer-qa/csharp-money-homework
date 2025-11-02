
using csharp_money_homework;

Money money = new Money();

Console.WriteLine("Введите первое число");
(bool isFirstAmountCorrect, int firstNum) = money.ValidateAmount(Console.ReadLine());

Console.WriteLine("Введите второе число");
(bool isSecondAmountCorrect, int secondNum) = money.ValidateAmount(Console.ReadLine());

money.SetAmount(firstNum, secondNum);

Console.WriteLine($"{money.MainAmount},{money.SecondAmount}");