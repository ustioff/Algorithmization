
namespace Lab;

public class Lab6
{
    public static void MainLab5()
    {
        Ex1();
        Ex2();
        Ex3();
        Ex4();
        Ex5();
        Ex6();
        Ex7();
        Ex8();
    }

    public static void Ex1()
    {
        int[] X = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        int n = 3;
        int[,] A = new int[n,n];
        int[,] B = new int[n,n];
        for (int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                A[i, j] = X[i * n + j];
                B[i, j] = X[i * n + j + n * n];
            }
        }
        int[,] C = new int[n,n];
        for(int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int k = 0;
                for (int l = 0; l < n; l++)
                {
                    k += A[i, l] * B[l, j];
                }
                C[i, j] = k;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(C[i,j] + " ");
            }
            Console.Write("\n");
        }
    }

    public static void Ex2()
    {
        double[,] A = new double[,] { { 1.0, 2.0, 3.0 }, { 4.0, 5.0, 6.0 }, { 7.0, 8.0, 9.0 } };
        double Max = -10000;
        int MAxi = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i,j] > Max)
                {
                    MAxi = i;
                    Max = A[i,j];
                }
            }
        }
        Console.Write(MAxi);
    }

    public static void Ex3()
    {
        double[,] A = new double[,] { { 1.0, 2.0, 3.0 }, { 4.0, 5.0, 6.0 }, { 7.0, 8.0, 9.0 } };
        int[] upI = new Int32[A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[j-1,i] >=  A[j, i])
                {
                    upI[i] = 0;
                    continue;
                }
                
            }
        }

        for (int i = 0; i < upI.Length; i++)
        {
            if (upI[i] == 1)
            {
                Console.Write(i);
            }
            
        }
    }

    public static void Ex4()
    {
        double[,] A = new double[,] { { 1.0, 2.0, 3.0 }, { 4.0, 5.0, 6.0 }, { 7.0, 8.0, 9.0 } };
        double[] x = new Double[A.GetLength(0) -1];
        for (int i = 0; i < A.GetLength(0) -1; i++)
        {
            x[i] = A[i + 1, i];
        }

        Array.Sort(x);
        for (int i = 0; i < 3; i++)
        {
            Console.Write(x[i]);
        }
    }

    public static void Ex5()
    {
        double[,] A = new double[,] { { 1.0, 2.0, 3.0 }, { 4.0, 5.0, 6.0 }, { 7.0, 8.0, 9.0 } };
        
        int n = A.GetLength(0);
        
        int rowCenter = n / 2;
        int colCenter = n / 2;

        int[] dRow = { 0, 1, 0, -1 };
        int[] dCol = { 1, 0, -1, 0 };

        int dir = 0;        
        int step = 1;  
        int total = n * n;
        int print = 0;

        // Выводим центральный элемент
        Console.Write(A[rowCenter, colCenter] + " ");
        print++;

        while (print < total)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < step; j++)
                {
                    rowCenter += dRow[dir];
                    colCenter += dCol[dir];

                    if (rowCenter >= 0 && rowCenter < n && colCenter >= 0 && colCenter < n)
                    {
                        Console.Write(A[rowCenter, colCenter] + " ");
                        print++;
                    }
                }

                dir = (dir + 1) % 4; 
            }

            step++;
        }
    }


    public static void Ex6()
    {
        double[,] A = new double[,] { { 1.0, 2.0, 3.0 }, { 4.0, 5.0, 6.0 }, { 7.0, 8.0, 9.0 } };
        int k = 1;
        Console.Write(A.GetLength(0) / k);
    }

    public static void Ex7()
    {
        double[,] A = new double[,] { { 1.0, 2.0, 3.0 }, { 4.0, 5.0, 6.0 }, { 7.0, 8.0, 9.0 } };
        int n = A.GetLength(0);
        double[,] a = (double[,])A.Clone();
        double det = 1.0;

        for (int i = 0; i < n; i++)
        {
            int pivot = i;
            for (int j = i + 1; j < n; j++)
            {
                if (Math.Abs(a[j, i]) > Math.Abs(a[pivot, i]))
                {
                    pivot = j;
                }
            }

            if (a[pivot, i] == 0)
            {
                det = 0;
                continue;
            }

            if (pivot != i)
            {
                for (int k = 0; k < n; k++)
                {
                    double temp = a[i, k];
                    a[i, k] = a[pivot, k];
                    a[pivot, k] = temp;
                }
                det = -det;
            }

            det *= a[i, i];
            
            for (int j = i + 1; j < n; j++)
            {
                double factor = a[j, i] / a[i, i];
                for (int k = i; k < n; k++)
                {
                    a[j, k] -= factor * a[i, k];
                }
            }
        }

        Console.Write(Math.Round(det, 10));
    }

    public static void Ex8()
    {
        double[,] A = new Double[3,3] {{1.84, 2.25, 2.53},{2.32, 2.6, 2.82},{1.86, 2.06, 2.24}};
        double[] B = new Double[3]{-6.09,-6.98,-5.52};
        
        int n = B.Length;
        double[] x = new double[n];

        for (int k = 0; k < n; k++)
        {

            int max = k;
            for (int i = k + 1; i < n; i++)
            {
                if (Math.Abs(A[i, k]) > Math.Abs(A[max, k]))
                {
                    max = i;
                }
            }

            if (max != k)
            {
                for (int j = k; j < n; j++)
                {
                    double tempA = A[k, j];
                    A[k, j] = A[max, j];
                    A[max, j] = tempA;
                }
                double tempB = B[k];
                B[k] = B[max];
                B[max] = tempB;
            }

            for (int i = k + 1; i < n; i++)
            {
                double factor = A[i, k] / A[k, k];

                B[i] -= factor * B[k];

                for (int j = k; j < n; j++)
                {
                    A[i, j] -= factor * A[k, j];
                }
            }
        }

        for (int i = n - 1; i >= 0; i--)
        {
            double sum = 0.0;
            for (int j = i + 1; j < n; j++)
            {
                sum += A[i, j] * x[j];
            }
            x[i] = (B[i] - sum) / A[i, i];
        }

        for (int i = 0; i < x.Length; i++)
        {
           Console.Write(x[i]);
        }
    }
}