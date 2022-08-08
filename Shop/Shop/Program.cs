using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystalPrice = 10;
            int purchasedСrystal;
            bool enoughGold;

            Console.Write("Введите количество золотых монет: ");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.Write($"У вас {gold} монет. Кристал стоит {crystalPrice}, " +
                $"сколько кристалов вы хотели бы купить? ");
            purchasedСrystal = Convert.ToInt32(Console.ReadLine());

            enoughGold = gold >= purchasedСrystal * crystalPrice;
            purchasedСrystal *= Convert.ToInt32(enoughGold);

            gold -= purchasedСrystal * crystalPrice;

            Console.WriteLine($"Теперь у вас {gold} золотых монет и {purchasedСrystal} кристалов");
            Console.ReadKey();

        }
    }
}
