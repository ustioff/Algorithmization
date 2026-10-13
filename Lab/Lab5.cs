namespace Lab;

public class Lab5
{
    public static void MainLab4()
    {
        Ex1();
        
    }

    public static void Ex1()
    {
        double[] X = new[] { 1.0, 0.0, -2.0, -5.0, 0.0, 6.0, 8.0, -9.0 };
        double M = 3;
        double[] Y = Array.FindAll(X, x => Math.Abs(x) > M);
        Console.WriteLine($"X: {String.Join(";", X)}, Y: {String.Join(";", Y)}, M: {M}");
    }

    public static void Ex2()
    {

        int[] X = new int[] { 1, -6, 3, -4, -5, -8, 7, 8, 9, -10, -15, -12, -10, 11 ,20};
        int otr = Array.FindAll(X,x => x < 0).Length;
        int maxOtr = 0;
        int Nowotr = 0;
        foreach (int x in X)
        {
            if (x < 0)
            {
                Nowotr++;
                if (Nowotr > maxOtr)
                {
                    maxOtr = Nowotr;
                }
            }
            else
            {
                Nowotr = 0;
            }
        }
        Console.WriteLine($"Отрицательных: {otr}, Подряд: {maxOtr}");
    }

    public static void Ex3()
    {
        int[] X = new int[] { 20, -6, 20, -4, -5, -8, 7, 8, 9, -10, -15, -12, -10, 11 ,20};
        int max = X.Max();
        int count = Array.FindAll(X,x => x == max).Length;
        Console.WriteLine($"МАкс {max} штук {count}");
    }

    public static void Ex4()
    {
        double[] X = new[] { 10.0, 40.0, 100.0, 30.0, 90.0, 200.0, 250.0, 15.0 };
        int count = 100;
        double[] Y = Array.ConvertAll(X, x => x < count ? x * 0.97 : x * 0.95);
        Console.WriteLine($"X {String.Join(";", X)}, {count}, Y {String.Join(";", Y)}");
    }

    public static void Ex5()
    {
        int N = Convert.ToInt32(Console.ReadLine());
        int[] X = new int[N];
        for (int i = 0; i < N; i++)
        {
            X[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(String.Join(",", X.Reverse()));
        Console.WriteLine($"Max: {X.Max()}");
    }

    public static void Ex6()
    {
        double[] D = new []{-2.0, 5.0,7.0,8.0,-20.0,-15.0,6.0};
        double sum = 0;
        for (int i = 0; i < D.Length; i++)
        {
            if (i % 2 != 0)
            {
                sum += D[i];
            }
        }
        
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"D: {String.Join(";", D)}");
    }

    public static void Ex7()
    {
        int[] X = new int[] { 1, -6, 3, -4, -5, -8, 7, 8, 9, -10, -15, -12, -10, 11 ,20};
        int flag = 0;
        foreach (int x in X)
        {
            if (X.Count(i => i == x) > 1)
            {
                Console.WriteLine($"Повтор {x}");
                flag = 1;
            }
        }

        if (flag != 1)
        {
            Console.WriteLine("Нету");
        }
        
    }

    public static void Ex8()
    {
        int[,] X =  {{ 3,5,-8,9 },{ -3,-6,-8,4 },{ -6,8,9,-1 }};
        int mult = 1;
        for (int i = 0; i < 3; i++)
        {
            int max = -1000;
            for (int j = 0; j < 4; j++)
            {
                if (X[i, j] > max)
                {
                    max = X[i, j];
                }
                if (X[i, j] > 0)
                {
                    mult *= X[i, j];
                }
            }
            Console.WriteLine($"строка {i + 1}:  {max}");
        }
        Console.WriteLine(mult);
    }

    public static void Ex9()
    {
        int n = 3;
        int m = 4;
        int[,] X =  {{ 3,5,-8,9 },{ -3,-6,-8,-10 },{ -6,8,9,-1 }};
        for (int i = 0; i < 3; i++)
        {
            int flag = 1;
            for (int j = 1; j < 4; j++)
            {
                if (X[i, j] >= X[i, j - 1])
                {
                    flag = 0;
                    break;
                }
            }

            if (flag == 1)
            {
                Console.WriteLine($"убывает {i + 1}");
            }
        }
    }

    public static void Ex10()
    {
        int n = 5;
        int m = 4;
        int[,] X =  {{ 3,5,-8,9 },{ -3,-6,-8,-10 },{3,5,-8,9},{ -3,-6,-8,-10 },{3,5,-8,9}};
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j <n; j++)
            {
                int[] X1 = new int[m];
                int[] X2 = new int[m];
                for (int l = 0; l < m; l++)
                {
                    X1[l] = X[i, l];
                    X2[l] = X[j, l];
                }

                int flag = 1;
                for (int k = 0; k < m; k++)
                {
                    int l = X1[k];
                    if (X1.Count(i => i == l) != X2.Count(i => i == l))
                    {
                        flag = 0;
                    }

                }
                if (flag == 1)
                {
                    Console.WriteLine($"{i + 1}, {j + 1}");
                }
               
            }
        }
    }

    public static void Ex11()
    {
        int n = 5;
        int m = 4;
        int[,] X = { { 3, 5, -8, 9 }, { -3, -6, -8, -10 }, { 3, 5, -8, 9 }, { -3, -6, -8, -10 }, { 3, 5, -8, 9 } };
        for (int i = 0; i < m - 1; i++)
        {
            int sum = 0;
            int mult = 1;
            for (int j = 0; j < n; j++)
            {
                sum += X[j,i];
                mult *= X[j,i];
            }

            if (sum > mult)
            {
                Console.WriteLine($"{i + 1}");
            }

        }

    }

    public static void Ex12()
    {
        int[,] X = { { 3, 5, -8, 9 }, { -3, -6, -8, -10 }, { 3, 5, -8, 9 }, { -3, -6, -8, -10 }};
        int n = X.GetLength(0);
        double sum = 0;
        int count = 0;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i +1; j < n; j++)
            {
                count++;
                sum += X[i,j];
            }
        }
        Console.WriteLine(sum / count);
    }

    public static void Ex13()
    {
        int n = 5;
        int m = 4;
        int[,] X = { { 3, 5, -8, 9 }, { -3, -6, -8, -10 }, { 3, 5, -8, 9 }, { -3, -6, -8, -10 }, { -3, -6, -8, -10 } };
        int flag = 0;
        for (int i = 0; i < n; i++)
        {
            int min = 1000;
            int Jmin = 0;
            int max = -1000;
            int Jmax = 0;
            for (int j = 0; j < m; j++)
            {
                if (X[i, j] < min)
                {
                    min = X[i, j];
                    Jmin = j;
                }

                if (X[i, j] > max)
                {
                    max = X[i, j];
                    Jmax = j;
                }
            }

            int flag1 = 1;
            int flag2 = 1;
            
            for (int k = 0; k < n; k++)
            {
                if (X[k,Jmax] < max )
                {
                    flag1 = 0;
                    break;
                }
                if (X[k,Jmin] > min )
                {
                    flag2 = 0;
                    break;
                }
            }

            if (flag1 == 1)
            {
                flag = 1;
                Console.WriteLine($"{i + 1}, {Jmax + 1}");
            }
            if (flag2 == 1)
            {
                flag = 1;
                Console.WriteLine($"{i + 1}, {Jmin + 1}");
            }
        }

        if (flag == 0)
        {
            Console.WriteLine("нету");
        }
    }

    public static void Ex14()
    {
        int[,] X = { { 3, 5, -8, 9 }, { -3, -6, -8, -10 }, { 3, 5, -8, 9 }, { -3, -6, -8, -10 } };
        int n = X.GetLength(0);
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            int flag = 0;
            for (int j = 0; j < n; j++)
            {
                if (i == 0)
                {
                    sum += X[i,j];
                }else 
                {
                    flag += X[i,j];
                }
            }

            if (flag != sum)
            {
                Console.WriteLine($"Не магический");
                return;

            }
        }

        for (int i = 0; i < n; i++)
        {
            int flag = 0;
            for (int j = 0; j < n; j++)
            {
                flag += X[i,j];
            }
            if (flag != sum)
            {
                Console.WriteLine($"Не магический");
                return;

            }
        }

        int flag1 = 0;
        for (int i = 0; i < n; i++)
        {
            flag1 += X[i,i];
        }
        if (flag1 != sum)
        {
            Console.WriteLine($"Не магический");
            return;

        }
        
        flag1 = 0;
        for (int i = n -1; i > 0; i--)
        {
            flag1 += X[i,i];
        }
        if (flag1 != sum)
        {
            Console.WriteLine($"Не магический");
            return;
        }
        Console.WriteLine($"магический");
    }

    public static void Ex15()
    {
        int n = 5;
        int m = 4;
        int[,] X = { { 3, 5, -8, 9 }, { -3, -6, -8, -10 }, { 3, 5, -8, 9 }, { -3, -6, -8, -10 }, { -3, -6, -8, -10 } };
        int iMax = 0;
        int jMax = 0;
        int max = -1000;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (X[i, j] > max)
                {
                    max = X[i, j];
                    jMax = j;
                    iMax = i;
                }
            }
        }

        if (iMax != 0)
        {
            for (int j = 0; j < m; j++)
            {
                int a = X[iMax, j];
                X[iMax, j] = X[0, j];
                X[0, j] = a;
            }
        }

        if (jMax != 0)
        {
            for (int i = 0; i < m; i++)
            {
                int a = X[i, jMax];
                X[i,jMax] = X[i,0];
                X[i, 0] = a;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(X[i,j] + " ");
            }
            Console.Write("\n");
        }
    }

    public static void Ex16()
    {
        int[,] arr = new int[,] { {1,1,4,0,5},
            {2,11,9,1,7},
            {3,1,4,40,3}, 
            {4,15,6,30,3}, 
            {12,1,9,10,3} };
 
        //сам цикл
        for (int n = 0; n < arr.GetLength(1); n++) 
        {
            for (int j = 1; j < arr.GetLength(1); j++)
            {
                int sumPrev = 0;
                int maxPrev = 0;
                for (int i = 0; i < arr.GetLength(0); i ++)
                {
                    if (arr[i, j - 1] % 2 ==0)
                    {
                        sumPrev += arr[i, j - 1];
                    }

                    if (arr[i, j - 1] > maxPrev)
                    {
                        maxPrev = arr[i, j - 1];
                    }
                }

                if (sumPrev == 0)
                {
                    sumPrev = maxPrev;
                }
 
                int sumCur = 0;
                int maxCur = 0;
                for (int i = 0; i < arr.GetLength(0); i ++)
                {
                    if (arr[i, j] % 2 ==0)
                    {
                        sumCur += arr[i, j];
                    }
                    if (arr[i, j] > maxCur)
                    {
                        maxCur = arr[i, j];
                    }
                }

                if (sumCur == 0)
                {
                    sumCur = maxCur;
                }
 
                if (sumPrev > sumCur)
                {
                    for (int k = 0; k < arr.GetLength(0); k++)
                    {
                        int temp = arr[k, j];
                        arr[k, j] = arr[k, j - 1];
                        arr[k, j - 1] = temp;
                    }
                }
            }
        }
        
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}