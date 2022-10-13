namespace программа2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(" Выберите приложение: 1 - игра, угадай число; 2 - таблица умножения; " +
                    "\n 3 - приложение, вывод делителей числа; 4 - выйти из программы");
                int chislo = Convert.ToChar(Console.ReadLine());
                if (chislo == '1')
                {
                    pervay();
                }
                else
                    if (chislo == '2')
                {
                    vtoray();
                }
                else
                    if (chislo == '3')
                {
                    tretya();
                }
                else
                    if (chislo == '4')
                {
                    Console.WriteLine("вы вышли из программы");
                    break;
                }
            }

        }

        static void pervay()
        {
            Random random = new Random();
            int i = random.Next(100);
            Console.WriteLine("Компьютер загадал число от 1 до 100");
            Console.WriteLine("Введите число");
            int k = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (i == k)
                {
                    Console.WriteLine("Вы угадали число, это число " + k + "!");
                    break;
                }
                else
                {
                    if (i < k)
                    {
                        Console.WriteLine("Нет, это не это число, введите меньше. ");
                    }
                    else
                   if (i > k)
                    {
                        Console.WriteLine("Нет, это не это число, введите больше. ");
                    }
                    k = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        static void vtoray()
        {
            int[,] Itog = new int[10, 10];
            for (int i = 1; i < 10; i++)
            {
                for (int a = 1; a < 10; a++)
                {
                    Itog[i, a] = i * a;
                    Console.Write(Itog[i, a] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void tretya()
        {
            Console.Write("Введите число ");
            int i = int.Parse(Console.ReadLine());
            for (int a = 1; a <= i; a++)
            {
                if (i % a == 0)
                {
                    Console.Write("{0} ", a);
                }
            }
            Console.WriteLine("");
        }
    }
}
