namespace Lab;

public class Lab4
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
    }

    public static void Ex1()
    {
        string s = Console.ReadLine();
        int countA = 0;
        int countB = 0;
        while (s != "0")
        {
            //a
            countA++;
            int sum = 0;
            foreach (char i in s)
            {
                if (i == '-')
                {
                    continue;
                }
                int a = Convert.ToInt32(i);
                sum += a;
            }
            for(int i =2;i<sum;i++)
            {
                if (sum % i == 0)
                {
                    countA--;
                    break;
                }
            }
            //b
            if (Convert.ToInt32(s) > 0)
            {
                foreach (char i in s)
                {
                    if (i == '2')
                    {
                        countB++;
                    }
                }
            }
            s = Console.ReadLine();
        }
        countA++;
        Console.WriteLine($"{countA} {countB}");
    }

    public static void Ex2()
    {
        string s = Console.ReadLine();
        int c = 1;
        foreach (char i in s)
        {
            int a = Convert.ToInt32(i);
            c *= a;
        }
        Console.WriteLine(c);
    }

    public static void Ex3()
    {
        int s = Convert.ToInt32(Console.ReadLine());
        int i = 1;

        int MaxI = 0;
        int MaxS = -100000;
        while (s != 0)
        {
            if (s < 0 && s > MaxS)
            {
                int count = 0;
                foreach (char n in Convert.ToString(s))
                {
                    if (n == '-')
                    {
                        continue;
                    }

                    if (Convert.ToInt32(n) % 2 != 0)
                    {
                        count++;
                    }
                }
                if (count % 2 == 0)
                {
                    MaxS = s;
                    MaxI = i;
                }
            }
            
            s = Convert.ToInt32(Console.ReadLine());
            i++;
        }
        
        Console.WriteLine($"{MaxS}, {MaxI}");
    }

    public static void Ex4()
    {
        
        int counter = 0;
        
        double old = -1;
        double number = Convert.ToDouble(Console.ReadLine());
        double number2 = Convert.ToDouble(Console.ReadLine());
        if (number2 < 0)
        {
            counter ++;
        }
        while(number2 > 0){
            if (number > old && number2 < number)
            {
                counter++;
            }

            old = number;
            number = number2;
            
            number2 = Convert.ToDouble(Console.ReadLine()); 
        }
        
        Console.WriteLine($"Больше соседий : {counter}");
    }

    public static void Ex5()
    {
        int N = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        int sum = 0;

        while (N > 0)
        {
            count++;
            
            int a = N % 10;
            sum += a;
            
            N /= 10;
        }
    }

    public static void Ex6()
    {
        double x = Convert.ToDouble(Console.ReadLine());
        double y = 0;

        int n = 0;
        double i = 1;
        while (i >= 0.0001)
        {
            y += i;
            n++;

            i = Math.Pow(x, n);
            for (int j = 2; j <= n; j++)
            {
                i /= j;
            }
        }
        
        Console.WriteLine($"{y}, {Math.Exp(x)}");
    }
    
    public static void Ex7()
    {
        double x = Convert.ToDouble(Console.ReadLine());
        double y = 0;

        int n = 0;
        double i = x;
        while (Math.Abs(i) >= 0.0001)
        {
            y += i;
            n++;

            i = Math.Pow(x, 2 * n + 1) * Math.Pow(-1,n);
            for (int j = 2; j <= 2 * n + 1; j++)
            {
                i /= j;
            }
        }
        
        Console.WriteLine($"{y}, {Math.Sin(x)}");
    }
    
    public static void Ex8()
    {
        double x = Convert.ToDouble(Console.ReadLine());
        double y = 0;

        int n = 0;
        double i = 1;
        while (Math.Abs(i) >= 0.0001)
        {
            y += i;
            n++;

            i = Math.Pow(x, 2 * n) * Math.Pow(-1,n);
            for (int j = 2; j <= 2 * n; j++)
            {
                i /= j;
            }
        }
        
        Console.WriteLine($"{y}, {Math.Cos(x)}");
    }

    public static void Ex9()
    {
        string s = Console.ReadLine();
        int c = 1;
        foreach (char i in s)
        {
            int a = Convert.ToInt32(i);
            c *= a;
        }
        Console.WriteLine(c);
    }

    public static void Ex10()
    {
        int s = Convert.ToInt32(Console.ReadLine());
        int i = 1;

        int MaxI = 0;
        int MaxS = -100000;
        while (s != 0)
        {
            if (s < 0 && s > MaxS)
            {
                    MaxS = s;
                    MaxI = i;
            }
            
            s = Convert.ToInt32(Console.ReadLine());
            i++;
        }
        
        Console.WriteLine($"{MaxS}, {MaxI}");
    }

    public static void Ex11()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        
        int old = 0;
        int counter = 0;
        
        while(number != 0)
        {
            if ((old > 0 && number < 0) ||  (old < 0 && number > 0))
            {
                counter++;
            }
            old = number;
            number = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Знак меняется: {old}");

    }

    public static void Ex12()
    {
        int f0 = 1;
        int f1 = 1;

        int f = f1 + f0;
        Console.WriteLine($"{f0},{f1}");
        while (f <= 1000)
        {
            Console.WriteLine(f);
            f0 = f1;
            f1 = f;
            f = f1 + f0;
        }
    }

    public static void Ex13()
    {
        string s = Console.ReadLine();

        string Us = "";
        foreach (char i in s)
        {
            Us = i + Us;
        }

        if (s == Us)
        {
            Console.WriteLine("палиндром");
        }
        else
        {
            Console.WriteLine("не палиндром");
        }
    }
}
