using System;
namespace Lab;

public class Lab2
{
    public static void Main2()
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
        Ex16();
    }

    public static void Ex1()
    {
        Console.WriteLine();
        Console.WriteLine(1);
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        if (1 <= a && a <= 3) Console.WriteLine(a);
        if (1 <= b && b <= 3) Console.WriteLine(b);
        if (1 <= c && c <= 3) Console.WriteLine(c);
        
    }
    public static void Ex2()
    {
        Console.WriteLine();
        Console.WriteLine(2);
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        if (a <= b && a <= c)
        {
            Console.WriteLine(a);
        }
        else if  (b <= a && b <= c)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }

    public static void Ex3()
    {
        Console.WriteLine();
        Console.WriteLine(3);
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 4 == 0 && (a % 100 != 0 || a % 400 == 0))
        {
            Console.WriteLine(365);
        }
        else
        {
            Console.WriteLine(365);
        }
    }

    public static void Ex4()
    {
        Console.WriteLine();
        Console.WriteLine(4);
        double a = Convert.ToDouble(Console.ReadLine());

        if (a > 500)
        {
            Console.WriteLine(a * 0.97);
        }
        else if (a > 1000)
        {
            Console.WriteLine(a * 0.95);
        }else
        {
            Console.WriteLine(a);
        }
    }

    public static void Ex5()
    {
        Console.WriteLine();
        Console.WriteLine(5);

        int  a = Convert.ToInt32(Console.ReadLine());

        switch (a)
        {
            case 1: Console.WriteLine("Январь"); break;
            case 2: Console.WriteLine("Февраль"); break;
            case 3: Console.WriteLine("Март"); break;
            case 4: Console.WriteLine("Апрель"); break;
            case 5: Console.WriteLine("Июнь"); break;
            case 6: Console.WriteLine("Июль"); break;
            case 7: Console.WriteLine("Август"); break;
            case 8: Console.WriteLine("Сентябрь"); break;
            case 9: Console.WriteLine("Октябрь"); break;
            case 10: Console.WriteLine("Ноябрь"); break;
            case 12: Console.WriteLine("Декабрь"); break;
            
        }
    }

    public static void Ex6()
    {
        Console.WriteLine();
        Console.WriteLine(6);

        int a = Convert.ToInt32(Console.ReadLine());
        int  b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        int k = 0;

        if (a < 0) k++;
        if (b < 0) k++;
        if (c < 0) k++;
        
        Console.WriteLine(k);
    }

    public static void Ex7()
    {
        Console.WriteLine();
        Console.WriteLine(7);
        int x =  Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        if (x == 0)
        {
            Console.WriteLine("x");
        }else if (y == 0)
        {
            Console.WriteLine("y");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("I");
        }else if (x < 0 && y > 0)
        {
            Console.WriteLine("II");
        }else if (x < 0 && y < 0)
        {
            Console.WriteLine("III");
        }else if (x > 0 && y < 0)
        {
            Console.WriteLine("IV");
        }
    }

    public static void Ex8()
    {
        Console.WriteLine();
        Console.WriteLine(8);

        switch (Console.ReadLine())
        {
            case "0": Console.WriteLine("ноль"); break;
            case "1": Console.WriteLine("один"); break;
            case "2": Console.WriteLine("два"); break;
            case "3": Console.WriteLine("три"); break;
            case "4": Console.WriteLine("четыре"); break;
            case "5": Console.WriteLine("пять"); break;
            case "6": Console.WriteLine("шесть"); break;
            case "7": Console.WriteLine("семь"); break;
            case "8": Console.WriteLine("восемь"); break;
            case "9": Console.WriteLine("девять"); break;
        }
    }

    public static void Ex9()
    {
        Console.WriteLine();
        Console.WriteLine(9);

        int a = Convert.ToInt32(Console.ReadLine());
        switch (a % 7)
        {
            case 1: Console.WriteLine("Понедельник"); break;
            case 2: Console.WriteLine("Вторник"); break;
            case 3: Console.WriteLine("Среда"); break;
            case 4: Console.WriteLine("Четверг"); break;
            case 5: Console.WriteLine("Пятница"); break;
            case 6: Console.WriteLine("Суббота"); break;
            case 0: Console.WriteLine("Воскресенье"); break;
        }
    }

    public static void Ex10()
    {
        Console.WriteLine();
        Console.WriteLine(10);

        int n = Convert.ToInt32(Console.ReadLine());
        
        double r = Convert.ToDouble(Console.ReadLine());

        switch (n)
        {
            case 1: Console.WriteLine(Math.PI * Math.Pow(r, 2)); break;
            case 2: Console.WriteLine(Math.PI * Math.Pow(r, 3) * (4.0/3.0)); break;
            case 4: Console.WriteLine(Math.PI * Math.Pow(r, 2)  * 4); break;
        }

        if (n == 3)
        {
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.PI * Math.Pow(r, 2) * h);
        }
    }

    public static void Ex11()
    {
        Console.WriteLine();
        Console.WriteLine(11);

        int n = Convert.ToInt32(Console.ReadLine());
        double a = Convert.ToDouble(Console.ReadLine());

        if (n == 1)
        {
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a * b);
        } else if (n == 2)
        {
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a * h);
        }else if (n == 3)
        {
            double b = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((a + b) / 2 * h);
        }
    }

    public static void Ex12()
    {
        Console.WriteLine();
        Console.WriteLine(12);
        int a = Convert.ToInt32(Console.ReadLine());
        
        switch (a % 5)
        {
            case 0: Console.WriteLine("ноль"); break;
            case 1: Console.WriteLine("один"); break;
            case 2: Console.WriteLine("два"); break;
            case 3: Console.WriteLine("три"); break;
            case 4: Console.WriteLine("четыре"); break;
        }
    }

    public static void Ex13()
    {
        Console.WriteLine();
        Console.WriteLine(13);

        double expr1 = 2 * Math.Pow(10 + Math.Pow(10, 1.0 / 10.0), 1.0 / 10.0) + 2 * Math.Pow(10, -3);
        double expr2 = Math.PI / 12 + Math.Asin(Math.Sqrt(3) / 2);

        if (1.0 / expr1 > expr2)
        {
            Console.WriteLine(Math.Acos((expr1 + expr2) /  (1 + expr1 * Math.Sin(expr2))));
        }
        else
        {
            Console.WriteLine(Math.Sin(expr2) /(expr1 * Math.Sqrt(expr1)) + Math.Pow(Math.E, Math.Pow(expr1, 2) - 1));
        }
    }

    public static void Ex14()
    {
        Console.WriteLine();
        Console.WriteLine(14);
        double p = Math.Pow(Math.E, Math.Pow(Math.Sin(2.0 / 3.0), 3)) + Math.Log10(Math.Atan(2.0 / 3.0));
        double q = 7.5 * Math.Pow(2.8, -8.0 / 3.0) - Math.Log10(Math.Pow(1.6, Math.Pow(1.2, 1.0 / 3.0)));

        double u;
        double f;
        if (Math.Pow(p, 2) > q)
        {
            u = Math.Pow(p * p - q, 1.0 / 5.0);
            f = Math.Sin(p * p);
        }
        else
        {
            u = 2 * Math.Asin(p * p /q);
            f = Math.Sin(q);
        }
        
        Console.WriteLine(u);
        Console.WriteLine(f);
    }

    public static void Ex15()
    {
        Console.WriteLine();
        Console.WriteLine(15);
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());
        double z = Convert.ToDouble(Console.ReadLine());

        double u = Math.Cos(Math.Abs(x + Math.Pow(Math.Abs(y), 1.0 / 3.0))) + Math.Sin(z - (Math.Pow(x, 10) / (1 + y * y + z * z)));
        double v = Math.Pow(Math.E, -x * x) + Math.Pow(Math.Abs(x + y + z), 1.0 / 7.0) + Math.Pow(Math.E, y);

        if (u * u + v * v >= 5)
        {
            Console.WriteLine(Math.Log2(v) + u * u + Math.Pow(5, 1.0/5.0));
        }
        else
        {
            Console.WriteLine(Math.Log10(v) + Math.Pow(u, 2.0/3.0) + Math.Sin(Math.Sqrt(5)));
        }
    }

    public static void Ex16()
    {
        Console.WriteLine();
        Console.WriteLine(16);
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());
        
        double f;
        double u;

        if (Math.Abs(x) >= Math.Abs(y))
        {
            f = Math.Log10(x + y) / (Math.Log10(x) + Math.Log10(y)) - Math.Sin(Math.Pow(Math.Pow(x,8) + Math.Pow(y,4),1.0/5.0));
        }
        else
        {
            f = Math.Asin(Math.Abs(x)/ Math.Sqrt(x *x + y * y)) + Math.Pow(Math.E, Math.Cos(Math.Sqrt(Math.Abs(x + y))));
        }

        if (Math.Pow(x,8) + Math.Pow(y,8) >= 12)
        {
            u = Math.Sin(Math.Abs(x - y/(Math.Pow(x,8) + Math.Pow(y,8))));
        }
        else
        {
            u = Math.Cos(Math.Abs(x - y/(Math.Pow(x,8) + Math.Pow(y,8))));
        }
        
        Console.WriteLine(f);
        Console.WriteLine(u);
    }
}