using System;

//Царегородцев Артемий МО-261 Лабараторная за 08.09.26

class Lab1 {
    static void Main() {
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
        
    }

    static void Ex1() {
        
        Console.WriteLine("Задание 1");
        int k = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"h: {k / (60 * 60)}; m: {(k / 60) % 60}; s: {k % 60}");
    }

    static void Ex2() {
        Console.WriteLine("\n Задание 2");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double h = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Площадь трапеции: {a * b * h}");
        Console.WriteLine($"Площадь усеченного конуса: {(a + b) * h / 2}");
    }

    static void Ex3() {
        Console.WriteLine("\n Задание 3");
        double r = Convert.ToDouble(Console.ReadLine());
        
        double V = (4.0/3) * Math.PI * Math.Cbrt(r);
        double S = Math.PI * Math.Pow(r, 2);
            
        Console.WriteLine($"Объем шара: {V}");
        Console.WriteLine($"Площадь круга: {S}");
        Console.WriteLine($"Соотношения: {V / S}");
    }

    static void Ex4() {
        Console.WriteLine("\n Задание 4");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double ma = 0.5 * Math.Sqrt(2 * Math.Pow(b, 2) + 2 * Math.Pow(c, 2) - Math.Pow(a, 2));
        double mb = 0.5 * Math.Sqrt(2 * Math.Pow(a, 2) + 2 * Math.Pow(c, 2) - Math.Pow(b, 2));
        double mc = 0.5 * Math.Sqrt(2 * Math.Pow(b, 2) + 2 * Math.Pow(a, 2) - Math.Pow(c, 2));

        Console.WriteLine($"Медиана ma: {ma}; Медиана mb: {mb}; Медиана mc: {mc};");
    }

    static void Ex5() {
        Console.WriteLine("\n Задание 5");
        double r = Convert.ToDouble(Console.ReadLine());
        double h = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Объем конуса: {Math.PI * h * Math.Pow(r, 2) / 3}");
        Console.WriteLine($"Площадь поверхности: {Math.PI * r * (r + Math.Sqrt(Math.Pow(r,2) + Math.Pow(h,2)))}");
    }

    static void Ex6() {
        Console.WriteLine("\n Задание 6");
        double r = Convert.ToDouble(Console.ReadLine());
        
        double V = (4.0/3) * Math.PI * Math.Pow(r, 3);
        double S = 4 * Math.PI * r * r;
            
        Console.WriteLine($"Объем шара: {Math.Round(V ,3)}");
        Console.WriteLine($"Площадь поверхности шара: {Math.Round(S ,3)}");
    }

    static void Ex7() {
        Console.WriteLine("\n Задание 7");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Расстояние: {Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))}");
    }

    static void Ex8() {
        Console.WriteLine("\n Задание 8");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Макс: {(a + b + Math.Abs(a - b)) / 2}");
    }

    static void Ex9() {
        Console.WriteLine("\n Задание 9");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"a: {a}; b: {b}");
    }

    static void Ex10() {
        Console.WriteLine("\n Задание 10");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Среднее: {Math.Round((a + b + c) / 3, 2)}");
    }

    static void Ex11() {
        Console.WriteLine("\n Задание 11");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Скидка: {Math.Round((a + b + c) * 0.13, 1)}");
    }

    static void Ex12() {
       Console.WriteLine("\n Задание 12");
       int a = Convert.ToInt32(Console.ReadLine());

       int a1 = a % 10;
       int a2 = a % 100 / 10;
       int a3 = a / 100;

       Console.WriteLine($"Сумма: {a1 + a2 + a3}");

    }

    static void Ex13() {
        Console.WriteLine("\n Задание 13");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Гипотенуза: {Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)),5)}");
    }
}