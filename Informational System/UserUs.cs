using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informational_System
{
    public class UserUs
    {
        static int select = 2;
        static string[] kostil = new string[3] { "Наименование", "Количество", "Цена" };

        public static void UsingForm()
        {
            ConsoleKey Key;
            Console.Clear();
            int i = 2;
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Добро пожаловать в магазин, " + Program.auth);
                Console.WriteLine("Выберите категорию продуктов: ");
                select = 2;
                foreach (string item in Magazine.Protocole)
                {
                    Console.SetCursorPosition(3, select);
                    Console.WriteLine(item);
                    select++;
                }
                Key = Console.ReadKey().Key;
                Console.Clear();
                switch (Key)
                {
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.RightArrow:
                        if (i < Magazine.Protocole.Count + 1)
                        {
                            i++;
                        }
                        else
                        {
                            i = 2;
                        }
                        Console.SetCursorPosition(0, i);
                        Console.WriteLine("-->");
                        break;
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.LeftArrow:
                        if (i > 2)
                        {
                            i--;
                        }
                        else
                        {
                            i = Magazine.Protocole.Count + 1;
                        }
                        Console.SetCursorPosition(0, i);
                        Console.WriteLine("-->");
                        break;
                    case ConsoleKey.Enter:
                        Print();
                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.WriteLine("Вы не купили ничего интересного(\nXДо свидания!");
                        Thread.Sleep(2500);
                        return;
                }
            }
        }

        private static void Print()
        {
            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(30, 0);
                Console.WriteLine(kostil[2]);
                Console.SetCursorPosition(15, 0);
                Console.WriteLine(kostil[1]);
                Console.SetCursorPosition(2, 0);
                Console.WriteLine(kostil[0]);
                int i = 1;
                if (select == 3)
                {
                    Magazine.Products();
                }
                else if (select == 4)
                {
                    Magazine.Techno();
                }
                else if (select == 5)
                {
                    Magazine.Fern();
                }
                ConsoleKey kluch = Console.ReadKey().Key;
                switch (kluch)
                {
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.UpArrow:

                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        return; 
                    case ConsoleKey.Enter:
                        break;
                }
            }
        }
    }
}
