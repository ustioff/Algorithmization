namespace Lab;

public class Lab7
{
    public static void MainLab7()
    {
        Ex1();
        Ex2();
        
    }

    public static void Ex1()
    {
        int n = 4;
        int[][] A = new int[n][];
        A[0] = new int[] { 1, 2 };
        A[1] = new int[] { 1, 2,4,5 };
        A[2] = new int[] { 1, 2 };
        A[3] = new int[] { 1, 2,3 };
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < A[i].Length; j++)
            {
                sum += A[i][j];
            }
        }
        Console.WriteLine("sum = " + sum);
    }

    public static void Ex2()
    {
        int n = 4;
        int[][] A = new int[n][];
        A[0] = new int[] { 1, 2 };
        A[1] = new int[] { 1, 2, 4, 5 };
        A[2] = new int[] { 1, 2 };
        A[3] = new int[] { -1, -2, -3, -6 };
        int max = 0;
        int index = 0;

        for (int i = 0; i < n; i++)
        {
            if (A[i].Length > max)
            {
                if (Array.FindAll(A[i], x => x >0).Length > 0)
                {
                    max = A[i].Length;
                    index = i;
                }
            }
        }
        Console.WriteLine("max = " + index);
    }

    public static void Ex3()
    {
        int n = 4;
        int[][] A = new int[n][];
        A[0] = new int[] { };
        A[1] = new int[] { 1, 2, 4, 5 };
        A[2] = new int[] { 1, 2 };
        A[3] = new int[] { -1, -2, -3, -6 };

        for (int i = 0; i < n; i++)
        {
            if (A[i].Length > 0)
            {
                int max = A[i].Max();
                Console.WriteLine($"{i}: {max}");
            }
            else
            {
                Console.WriteLine($"{i}: Empty");
            }

        }
    }

    public static void Ex4()
    {
        int n = 4;
        int[][] A = new int[n][];
        A[0] = new int[] { };
        A[1] = new int[] { 1, 2, 4, 5 };
        A[2] = new int[] { 1, 2 };
        A[3] = new int[] { -1, -2, -3, -6 };

        for (int i = 0; i < n; i++)
        {
            A[i] = A[i].Reverse().ToArray();
            
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < A[i].Length; j++)
            {
                Console.Write(A[i][j]);
            }
            Console.WriteLine();
        }
    }

    public static void Ex5()
    {
        int n = 4;
        int[][] A = new int[n][];
        for (int i = 0; i < n; i++)
        {
            int[] X = new int[i + 1];
            for (int j = 0; j < i + 1; j++)
            {
                X[j] = i + j;
            }

            A[i] = X;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < A[i].Length; j++)
            {
                Console.Write(A[i][j]);
            }
            Console.WriteLine();
        }
    }

    public static void Ex6()
    {
        int n = 4;
        int[][] A = new int[n][];
        A[0] = new int[] { };
        A[1] = new int[] { 1, 2, 4, 5 };
        A[2] = new int[] { 1, 2 };
        A[3] = new int[] { -1, -2, -3, -6 };
        int k = 3;
        for (int i = 0; i < n; i++)
        {
            if (A[i].Length > k)
            {
                Console.WriteLine($"{i}: {A[i][k]}");
            } 
        }
    }

    public static void Ex7()
    {
        int n = 4;
        int[][] A = new int[n][];
        A[0] = new int[] { };
        A[1] = new int[] { 1, 2, 4, 5 };
        A[2] = new int[] { 1, 2 };
        A[3] = new int[] { -1, -2, -3, -6 };
        double sr = -1000;
        double index = -1;
        for (int i = 0; i < n; i++)
        {
            if (A[i].Length > 0)
            {
                double sum = 0;
                for (int j = 0; j < A[i].Length; j++)
                {
                    sum += A[i][j];
                }

                if (sum/A[i].Length > sr )
                {
                    sr = sum / A[i].Length;
                    index = i;
                }
            }
        }

        if (index > -1)
        {
            Console.WriteLine($"index = {index}");
        }
        else
        {
            Console.WriteLine($"index = -1");
        }
    }

    public static void Ex8()
    {
        int n = 4;
        int[][] A = new int[n][];
        A[0] = new int[] { };
        A[1] = new int[] { 1, 2, 4, 5 };
        A[2] = new int[] { 1, 2 };
        A[3] = new int[] { 2, -2, -3, -6 };
        double powtor = 0;
        double index = -1;

        for (int i = 0; i < n; i++)
        {
            int powI = 0;
            for (int j = 0; j < A[i].Length; j++)
            {
                if (A[i].Count(x => x == A[i][j]) > powI)
                {
                    powI = A[i].Count(x => x == A[i][j]);
                }
            }
            if (powI >= powtor)
            {
                powtor = powI;
                index = i;
            }
        }
        
        Console.WriteLine($"index = {index}");
    }

    public static void Ex9()
    {
        int n = 4;
        int[][] A = new int[n][];
        A[0] = new int[] { };
        A[1] = new int[] { 1, 2, 4, 5 };
        A[2] = new int[] { 1, 2 };
        A[3] = new int[] { 2, -2, -3, -6 };
        
        int m = 4;
        int[][] B = new int[n][];
        B[0] = new int[] { 10,20};
        B[1] = new int[] { };
        B[2] = new int[] { 10, 20,30 };
        B[3] = new int[] { 20, -20, -30, -60 };

        int[][] C = new int[n + m][];
        for (int i = 0; i < n + m; i++)
        {
            if (i % 2 == 0)
            {
                C[i] = A[i / 2];
            }
            else
            {
                C[i] = B[i / 2];
            }
        }
        
        for (int i = 0; i < n + m; i++)
        {
            for (int j = 0; j < C[i].Length; j++)
            {
                Console.Write(C[i][j]);
            }
            Console.WriteLine();
        }
    }
}