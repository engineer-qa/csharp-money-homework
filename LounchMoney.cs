using csharp_money_homework;

public class LounchMoneyLogic()
{
    public void Lounch()
    {
        Money money = new Money();
        Product product = new Product();

        while (true)
        {
            bool isFirstAmountCorrect = false;
            bool isSecondAmountCorrect = false;
            int firstAmount = 0;
            int secondAmount = 0;
            int selectedOperation;

            string[] menu =
                {
        "Выберите действие:\n",
        "1. Задать цену и название продукту\n",
        "2. Получить цену и название продукта\n",
        "3. Повысить цену\n",
        "4. Понизить цену\n"
    };
            var message = string.Concat(menu);
            Console.WriteLine(message);

            var input = Console.ReadLine();
            var resultOperation = int.TryParse(input, out int operationResult);
            selectedOperation = operationResult;

            if (resultOperation)
            {
                if (operationResult < 1 || operationResult > menu.Length - 1)
                {
                    Console.Clear();
                    Console.WriteLine($"Вводить можно только цифры от 1 до {menu.Length - 1}");
                }
            }
            else if (!resultOperation)
            {
                Console.Clear();
                Console.WriteLine($"Вводить можно только цифры. Вы ввели {selectedOperation}");
            }
            if (selectedOperation == 1)
            {
                Console.WriteLine("Введите название продукта");
                product.ProductName = Console.ReadLine();
            }
            if (selectedOperation != 2)
            {
                while (!isFirstAmountCorrect)
                {
                    Console.WriteLine("Введите первое число");
                    (isFirstAmountCorrect, firstAmount) = money.ValidateAmount(Console.ReadLine());
                }

                while (!isSecondAmountCorrect)
                {
                    Console.WriteLine("Введите второе число");
                    (isSecondAmountCorrect, secondAmount) = money.ValidateAmount(Console.ReadLine());
                }
            }


            switch (selectedOperation)
            {
                case 2:
                    product.GetAmount();
                    product.GetProductName();
                    break;
                case 1:
                case 3:
                    product.SetAmount(firstAmount, secondAmount, true);
                    product.GetAmount();
                    break;
                case 4:
                    product.SetAmount(firstAmount, secondAmount, false);
                    product.GetAmount();
                    break;
                default:
                    break;
            }
        }
    }
}
