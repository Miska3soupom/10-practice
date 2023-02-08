using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informational_System
{
    public class Magazine
    {
        public string name;
        public int amount, price;
        public static List<Magazine> prod;
        public static List<string> Protocole = new() { "Продукты", "Техника", "Мебель", "Закончить покупки" };

        public Magazine(string Name, int Amount, int Price)
        {
            this.name = Name;
            this.amount = Amount;
            this.price = Price;
        }

        public Magazine() { }

        public static void Products()
        {
            prod = new() { new Magazine("Яблоки", 20, 100),
            new Magazine("Груши", 27, 120),
            new Magazine("Бананы", 13, 142)};
            foreach(var item in prod)
            {
                for (int i =1; i < prod.Count; i++)
                {
                    Console.SetCursorPosition(30, i);
                    Console.WriteLine(item.price.ToString());
                    Console.SetCursorPosition(15, i);
                    Console.WriteLine(item.amount.ToString());
                    Console.SetCursorPosition(3, i);
                    Console.WriteLine(item.name.ToString());
                }
            }
        }
        public static void Techno()
        {
            prod = new() { new Magazine("Планшеты", 50, 1200),
            new Magazine("Видеокарты", 2, 19999),
            new Magazine("Холодильники", 18, 15000)};
            foreach (var item in prod)
            {
                for (int i = 1; i < prod.Count; i++)
                {
                    Console.SetCursorPosition(30, i);
                    Console.WriteLine(item.price.ToString());
                    Console.SetCursorPosition(15, i);
                    Console.WriteLine(item.amount.ToString());
                    Console.SetCursorPosition(3, i);
                    Console.WriteLine(item.name.ToString());
                }
            }
        }
        public static void Fern()
        {
            prod = new() { new Magazine("Диваны", 17, 5000),
            new Magazine("Шкафы", 32, 3650),
            new Magazine("Стулья", 43, 500)};
            foreach (var item in prod)
            {
                for (int i = 1; i < prod.Count; i++)
                {
                    Console.SetCursorPosition(30, i);
                    Console.WriteLine(item.price.ToString());
                    Console.SetCursorPosition(15, i);
                    Console.WriteLine(item.amount.ToString());
                    Console.SetCursorPosition(3, i);
                    Console.WriteLine(item.name.ToString());
                }
            }
        }
    }
}
