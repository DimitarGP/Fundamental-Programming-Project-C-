using System;

namespace SweetDesert
{
    class CalculateNeedMoney
    {
        static void Main()
        {
            decimal amountOfCach = decimal.Parse(Console.ReadLine());
            int numberOfGuest = int.Parse(Console.ReadLine());
            decimal priceOfBananas = decimal.Parse(Console.ReadLine());
            decimal priceOfEggs = decimal.Parse(Console.ReadLine());
            decimal priceOfBeries = decimal.Parse(Console.ReadLine());

            decimal numberOfSets = Math.Round((decimal) numberOfGuest/6);

            int bananas = 2;
            int eggs = 4;
            double berries = 0.2;

            decimal productsMoney = numberOfSets * (
                                    (decimal)bananas * priceOfBananas) 
                                    + numberOfSets * (eggs * priceOfEggs)
                                    + numberOfSets * ((decimal)berries * priceOfBeries);
            
            if (amountOfCach < productsMoney)
            {
                decimal needMoney = Math.Abs(amountOfCach - productsMoney);
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.",needMoney);
            }
            else
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.",productsMoney);
            }
            
        }
    }
}
