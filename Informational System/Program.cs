using System.Text.Json;

namespace Informational_System
{
    internal class Program
    {
        public const string path = "\"C:\\Users\\misha\\OneDrive\\Рабочий стол\\работа\\Informational System\\Informational System\\bin\\Debug\\net6.0\\save.json\"";
        public static string auth = null;
        public static List<Administration> users;
        static void Main(string[] args)
        {
            if (File.Exists(path))
            {
                users = Load(path);
            }
            else
            {
                users = new List<Administration>
                {
                    new Administration(1, "admin", "1111", Role.Admin),
                    new Administration(2, "user", "1234", Role.User),
                    new Administration(3, "root", "0000", Role.Cashier)
                };
            }

            while (true)
            {
                Console.WriteLine("Введите логин");
                var login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                var password = "";
                while (true)
                {
                    var info = Console.ReadKey(true);
                    switch (info.Key)
                    {
                        case ConsoleKey.Enter:
                            break;
                        case ConsoleKey.Backspace:
                            Console.SetCursorPosition(password.Length - 1, 3);
                            Console.Write(" ");
                            break;
                        default:
                            password += info.KeyChar;
                            Console.Write('*');
                            break;
                    }
                    if(info.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                foreach (var user in users)
                {
                    if (login == user.Login && password == user.Password)
                    {
                        auth = login;
                        break;
                    }
                }
                if (auth != null)
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("Неверные данные");
            }
            if (auth == "admin")
            {
                AdminUs.Adm();
            }
            else if (auth == "user")
            {
                UserUs.UsingForm();
            }
        }

        private static List<Administration> Load(string path)
        {
            return JsonSerializer.Deserialize<List<Administration>>(File.ReadAllText(path));
        }

        public static void Save(string path, List<Administration> users)
        {
            File.WriteAllText(path, JsonSerializer.Serialize(users));
        }
    }
}
