using Informational_System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informational_System
{
    public class AdminUs
    {
        static public void Adm()
        {
            var select = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Добро пожаловать, " + Program.auth);
                Console.WriteLine("Список пользователей:");
                foreach (var user in Program.users)
                {
                    Console.WriteLine("   " + user.Login);
                }
                Console.SetCursorPosition(0, 2 + select);
                Console.WriteLine("-->");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (select < Program.users.Count - 1)
                            select++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (select > 0)
                            select--;
                        break;
                    case ConsoleKey.Enter: /*Инфа*/
                        var selected = Program.users[select];
                        Console.WriteLine("Логин: " + selected.Login + ", пароль: " + selected.Password);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.N: /*Создание пользователя*/
                        {
                            Console.Clear();
                            Console.WriteLine("Введите логин");
                            var login = Console.ReadLine();
                            Console.WriteLine("Введите пароль");
                            var password = Console.ReadLine();
                            int maxId = 1;
                            foreach (var user in Program.users)
                            {
                                if (maxId < user.Id)
                                {
                                    maxId = user.Id;
                                }
                            }
                            Program.users.Add(new Administration(maxId + 1, login, password, Role.Admin));
                        }
                        break;
                    case ConsoleKey.E: /*Изменение пользователя*/
                        {
                            Console.Clear();
                            Console.WriteLine("Введите новый логин");
                            var login = Console.ReadLine();
                            Console.WriteLine("Введите новый пароль");
                            var password = Console.ReadLine();
                            Program.users[select] = new Administration(Program.users[select].Id, login, password, Role.Admin);
                        }
                        break;
                    case ConsoleKey.D: /*Удаление пользователя*/
                        if (Program.users.Count > 0)
                        {
                            Program.users.RemoveAt(select);
                            select = 0;
                        }
                        break;
                    case ConsoleKey.F: /*Поиск*/
                        Console.Clear();
                        Console.WriteLine("Выберите свойство для поиска");
                        Console.WriteLine("1 - логин, 2 - пароль");
                        var prop = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите значение");
                        var val = Console.ReadLine();
                        Console.WriteLine("Результаты поиска");
                        switch (prop)
                        {
                            case 1:
                                foreach (var user in Program.users)
                                {
                                    if (user.Login.Contains(val))
                                    {
                                        Console.WriteLine(user.Login);
                                    }
                                }
                                break;
                            case 2:
                                foreach (var user in Program.users)
                                {
                                    if (user.Password.Contains(val))
                                    {
                                        Console.WriteLine(user.Login);
                                    }
                                }
                                break;
                        }
                        Console.ReadKey();
                        break;
                    case ConsoleKey.Q: /*Сохранить и выйти*/
                        Program.Save(Program.path, Program.users);
                        return;
                }
            }
        }
    }
}
