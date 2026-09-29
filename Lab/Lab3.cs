namespace Lab;

//Царегородцев Артемий МО-261 Лабараторная за 29.09.26

public class Lab3
{
    public static void MainLab3()
    {
        Ex1();
        Ex2();
        Ex3();
        Ex4();
        Ex5();
        Ex6();
        Ex7();
        Ex8();
        Ex9();
        Ex10();
        Ex11();
        Ex12();
        Ex13();
        Ex14();
        Ex15();
    }

    public static void Ex1()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Стоимость за {i} кг: {i*a}");
        }
    }

    public static void Ex2()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        double sum = 0;
        for (int i = a; i <= b; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Среднее {sum/(b-a)}");
    }

    public static void Ex3()
    {
        int sum = 0;
        for (int i = 0; i < 20; i++)
        {
            sum += Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine($"Среднее {sum/20}");
    }

    public static void Ex4()
    {
        for (int i = 3; i < 25; i += 3)
        {
            Console.WriteLine($"Амеб через {i}: {Math.Pow(2, i/3)}");
        }
    }

    public static void Ex5()
    {
        double sum = 10;
        for (int i = 2; i <= 10; i++)
        {
            Console.WriteLine($"пробег за {i} день:  {10d * Math.Pow(1.1, i -1)}");
            if (i <= 7)
            {
                sum += 10 * Math.Pow(1.1, i - 1);
            }
        }
        
        Console.WriteLine($"Путь за 7 дней: {sum}");
    }

    public static void Ex6()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        
        int sum = 0;
        int counter = 0;

        for (int i = 0; i < n; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            sum += number;
            if (number > 0)
            {
                counter++;
            }
        }
        
        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Положительная: {counter}");
    }

    public static void Ex7()
    {
        double x = 0;
        for (int i = 1; i <= 10; i++)
        {
            x += (1d / i);
        }
        
        Console.WriteLine($"X: {x}");
    }

    public static void Ex8()
    {
        double z = 1;
        for (int i = 2; i <= 20; i++)
        {
            z *= i;
        }
        
        Console.WriteLine($"Z: {z}");
    }

    public static void Ex9()
    {
        double x = Convert.ToDouble(Console.ReadLine());
        double y = 0;
        for (int i = 1; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                y -= Math.Pow(i,2) * x;
            }
            else
            {
                y += Math.Pow(i,2) * x;
            }
        }
        
        Console.WriteLine($"Y: {y}");
    }

    public static void Ex10()
    {
        double x = Convert.ToDouble(Console.ReadLine());
        double y = 0;
        for (int i = 1; i <= 17; i += 2)
        {
            y += (x / i);
        }
        
        Console.WriteLine($"Y: {y}");
    }

    public static void Ex11()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int y = 1;
        for (int i = 1; i <= n; i++)
        {
            y *= n;
        }
        Console.WriteLine($"Y: {y}");
    }

    public static void Ex12()
    {
        double y = 0;
        for (int i = 0; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                y += Math.Pow(3, i);
            }
            else
            {
                y -= Math.Pow(3, i);
            }
        }
        Console.WriteLine($"Y: {y}");
    }

    public static void Ex13()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        double old = -1;
        int counter = 0;
        
        double number = Convert.ToDouble(Console.ReadLine());
        for (int i = 0; i < (n -1); i++)
        {
            
            double number2 = Convert.ToDouble(Console.ReadLine());
            if (i == (n - 2) && number2 > number)
            {
                counter++;
            }else if (number > old && number2 < number)
            {
                counter++;
            }

            old = number;
            number = number2;
        }
        
        Console.WriteLine($"Больше соседий : {counter}");
    }

    public static void Ex14()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        
        int old = 0;
        int counter = 0;
        
        for (int i = 0; i <n; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if ((old > 0 && number < 0) ||  (old < 0 && number > 0))
            {
                counter++;
            }
            old = number;
        }
        Console.WriteLine($"Знак меняется: {old}");
    }

    public static void Ex15()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }

        if (sum == n)
        {
            Console.WriteLine("Совершенно");
        }
        else
        {
            Console.WriteLine("Не совершенно");
        }
    }
}