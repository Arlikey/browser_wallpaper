using System.Collections.ObjectModel;

namespace Collection
{
    /*internal class Program
    {
        static void Main(string[] args)
        {
            MyCollection<int> array = new MyCollection<int>();
            MyCollection<string> strings = new MyCollection<string>();
            array.Add(1);
            array.Add(1);
            array.Add(1);
            array.Add(1);
            Console.WriteLine(array.GetSumOfNumbers());
            strings.Add("Hello");
            strings.Add("World");
            strings.Add("Today");
            strings.Add("Is");
            strings.Add("Great");
            strings.Add("Day");
            char[] chars = strings.GetFirstSymbolsOfEveryRow();
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write(chars[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(strings.GetCountOfSymbolsOfWholeCollection());

        }

        public class MyCollection<T> : Collection<T>
        {
            public int GetSumOfNumbers()
            {
                int sum = 0;
                foreach (T item in this)
                {
                    if (item is int number)
                    {
                        sum += number;
                    }
                }
                return sum;
            }

            public int GetCountOfSymbolsOfWholeCollection()
            {
                int count = 0;
                foreach(T item in this)
                {
                    if (item is string str)
                    {
                        count += str.Length;
                    }
                }
                return count;
            }

            public char[] GetFirstSymbolsOfEveryRow()
            {
                char[] symbols = new char[this.Count];
                int i = 0;
                foreach (T item in this)
                {
                    if(item is string str)
                    {
                        symbols[i++] = str.First();
                    }
                }
                return symbols;
            }
        }
    }*/

    /*public class AdditionalTask2
    {
        static void Main(string[] args)
        {
            Stack<int> ints = new Stack<int>();
            ints.Push(1);
            ints.Push(2);
            ints.Push(3);
            ints.Push(4);
            ints.Push(5);
            ints.Push(6);
            ints.Push(7);
            ints.Push(8);
            ints.Push(9);

            Stack<int> odds = new Stack<int>();
            Stack<int> evens = new Stack<int>();

            foreach (int i in ints)
            {
                if (i % 2 == 0)
                {
                    evens.Push(i);
                }
                else
                {
                    odds.Push(i);
                }
            }

            Console.Write("Изначальный стек: ");
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }

            DoNotPop(ints);

            WithPop(ints);
        }

        public static void DoNotPop(Stack<int> stack)
        {
            Console.WriteLine("\n\nБЕЗ ИЗВЛЕКАНИЯ ЭЛЕМЕНТОВ\n\n");
            Stack<int> evens = new Stack<int>();
            Stack<int> odds = new Stack<int>();

            foreach (int i in stack)
            {
                if (i % 2 == 0)
                {
                    evens.Push(i);
                }
                else
                {
                    odds.Push(i);
                }
            }
            Console.Write("Четные: ");
            PrintStack(evens);
            Console.Write("Нечетные: ");
            PrintStack(odds);
        }

        public static void WithPop(Stack<int> stack)
        {
            Console.WriteLine("\n\nС ИЗВЛЕКАНИЕМ ЭЛЕМЕНТОВ\n\n");
            Stack<int> evens = new Stack<int>();
            Stack<int> odds = new Stack<int>();

            while (stack.Count != 0)
            {
                int item = stack.Pop();
                if (item % 2 == 0)
                {
                    evens.Push(item);
                }
                else { odds.Push(item); }
            }
            Console.Write("Четные: ");
            PrintStack(evens);
            Console.Write("Нечетные: ");
            PrintStack(odds);
        }

        public static void PrintStack(Stack<int> stack)
        {
            foreach (int i in stack)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }*/

    /*public class AdditionalTask3
    {
        class Program
        {
            static Dictionary<string, string> employees = new Dictionary<string, string>();

            static void Main(string[] args)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Управление сотрудниками: ");
                    Console.WriteLine("1. Добавить логин и пароль сотрудника");
                    Console.WriteLine("2. Удалить логин сотрудника");
                    Console.WriteLine("3. Изменить информацию о логине и пароле сотрудника");
                    Console.WriteLine("4. Получить пароль сотрудника по логину");
                    Console.WriteLine("5. Выход");
                    Console.Write("\nВведите ваше действие: ");

                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            AddEmployee();
                            break;
                        case 2:
                            RemoveEmployee();
                            break;
                        case 3:
                            UpdateEmployeePassword();
                            break;
                        case 4:
                            GetEmployeePassword();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Неверный ввод!");
                            break;
                    }

                    Console.WriteLine("Для продолжения нажмите любую клавишу!");
                    Console.ReadKey();

                    Console.WriteLine();
                }
            }

            static void AddEmployee()
            {
                Console.Clear();
                Console.Write("Введите логин сотрудника: ");
                string login = Console.ReadLine();

                if (employees.ContainsKey(login))
                {
                    Console.WriteLine("Сотрудник с таким логином уже существует!");
                }
                else
                {
                    Console.Write("Введите пароль сотрудника: ");
                    string password = Console.ReadLine();
                    employees.Add(login, password);
                    Console.WriteLine("Сотрудник был успешно добавлен!");
                }
            }

            static void RemoveEmployee()
            {
                Console.Clear();
                Console.Write("Введите логин сотрудника которого хотите удалить: ");
                string login = Console.ReadLine();

                if (employees.ContainsKey(login))
                {
                    employees.Remove(login);
                    Console.WriteLine("Сотрудник был успешно удален.");
                }
                else
                {
                    Console.WriteLine("Сотрудника с данным логином не существует.");
                }
            }

            static void UpdateEmployeePassword()
            {
                Console.Clear();
                Console.Write("Введите логин сотрудника пароль которого хотите изменить: ");
                string login = Console.ReadLine();

                if (employees.ContainsKey(login))
                {
                    Console.Write("Введите новый логин: ");
                    string newLogin = Console.ReadLine();
                    Console.Write("Введите новый пароль: ");
                    string newPassword = Console.ReadLine();
                    employees.Remove(login);
                    employees.Add(newLogin, newPassword);
                    Console.WriteLine("Логин и пароль были успешно изменены.");
                }
                else
                {
                    Console.WriteLine("Сотрудника с данным логином не существует.");
                }
            }

            static void GetEmployeePassword()
            {
                Console.Clear();
                Console.Write("Введите логин сотрудника чтобы получить пароль: ");
                string login = Console.ReadLine();

                if (employees.ContainsKey(login))
                {
                    string password = employees[login];
                    Console.WriteLine($"Пароль сотрудника {login}: {password}");
                }
                else
                {
                    Console.WriteLine("Сотрудника с данным логином не существует.");
                }
            }
        }
    }*/
}
