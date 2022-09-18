Console.WriteLine("1. Сложить 2 числа");
Console.WriteLine("2. Вычесть первое из второго");
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("4. Разделить первое на второе");
Console.WriteLine("5. Возвести в степень N первое число");
Console.WriteLine("6. Найти квадратный корень из числа");
Console.WriteLine("7. Найти n-ый процент от числа");
Console.WriteLine("8. Найти факториал из числа");
Console.WriteLine("9. Выйти из программы");

for (int i = 0; i < 9; i++)
{
    while (i < 9)
    {
        Console.WriteLine("Выбирите одно из действий:");
        int d = Convert.ToInt32(Console.ReadLine());

        if (d == 1)

        {
            Console.WriteLine("Ведите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат:");
            Console.WriteLine(a + b);
        }

        else if (d == 2)
        {
            Console.WriteLine("Ведите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат:");
            Console.WriteLine(a - b);
        }

        else if (d == 3)
        {
            Console.WriteLine("Ведите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат:");
            Console.WriteLine(a * b);
        }

        else if (d == 4)
        {
            Console.WriteLine("Ведите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат:");
            Console.WriteLine(a / b);
        }

        else if (d == 5)
        {
            Console.WriteLine("Ведите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень:");
            int N = Convert.ToInt32(Console.ReadLine());
            int c = a;
            for (int t = 1; t < N; t++)
            {
                c = a * c;
            }
            Console.WriteLine("Результат:");
            Console.WriteLine(c);
        }

        else if (d == 6)
        {
            Console.WriteLine("Ведите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(a));
        }

        else if (d == 7)
        {
            Console.WriteLine("Ведите число:");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите процент, который надо найти:");
            double n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Резульат:" + a / 100 * n);
        }
        else if (d == 8)
        {
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for (int r = 2; r <= a; r++)
            {
                f = f * r;
            }
            Console.WriteLine("Резульат:" + f);
        }
        else if (d == 9)
        {
            Console.WriteLine();
        }

    }
}
