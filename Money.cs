using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_money_homework
{
    public class Money
    {
        public int MainAmount { get; set; }
        public int SecondAmount { get; set; }

        public (bool resultIsCorrect, int resultAmount) ValidateAmount(string? amount)
        {
            bool resultIsCorrect = int.TryParse(amount, out int resultAmount);
            return (resultIsCorrect, resultAmount);
        }
        public double GetAmount()
        {
            return MainAmount;
        }
        public void SetAmount(int mainAmount, int secondAmount)
        {
            MainAmount += mainAmount;
            double secondResultAmount = SecondAmount + secondAmount;
            if (secondResultAmount > 99)
            {
                secondResultAmount = secondResultAmount / 100;
                (int resultFirstAmount, int resultSecondAmount) = SplitAmount(secondResultAmount);
                MainAmount += resultFirstAmount;
                SecondAmount = resultSecondAmount;
            }
            else
            {
                SecondAmount += secondAmount;
            }
        }
        private (int resultFirstAmount, int resultSecondAmount) SplitAmount(double amount)
        {
            var splitedAmount = amount.ToString().Split(',');
            return splitedAmount.Length > 1
                ? (int.Parse(splitedAmount.First()), int.Parse(splitedAmount.Last()))
                : (int.Parse(splitedAmount.First()), 0);
        }
    }
}
