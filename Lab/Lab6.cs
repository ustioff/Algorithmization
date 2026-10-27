
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
        int[] X = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        int n = 3;
        int[n,n] A = new int[n,n];
        int[n,n] B = new int[n,n];
        for(int i = 0, i < n, i++)
        {
            for(int j = 0, j < n, j++)
            {
                A[i, j] = X[i * n + j];
                B[i,j] = X[i * n + j + n * n]
            }
        }
        int[n,n] C = new int[n,n];
        for(int i = 0, i < n, i++)
        {
            for (int j = 0, j < n,
            j++)
            {
                k = 0;
                for (int l = 0; l < n; l++)
                {
                    k += A[i, l] * B[l, j];
                }
                C[i, j] = k;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(C[i,j] + " ");
            }
            Console.Write("\n");
        }
    }

    public static void Ex2()
    {
        double[,] A = new double[,] { { 1m, 2m, 3m }, { 4m, 5m, 6m }, { 7m, 8m, 9m } };
        double Max = -10000;
        int MAxi = 0;
        for (int i = 0; i < UPPER; i++)
        {
            for (int j = 0; j < m; j++)
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
        double[,] A = new double[,] { { 1m, 2m, 3m }, { 4m, 3m, 6m }, { 7m, 7m, 9m } };
        int[] upI = new Int32[A.R]
        for (int i = 0; i < UPPER; i++)
        {
            for (int j = 1; j < m; j++)
            {
                if (A[j-1,i] >=  A[j, i])
                {
                    upI[i] = 0;
                    continue;
                }
                
            }
        }

        for (int i = 0; i < upI; i++)
        {
            if (upI[i] == 1)
            {
                Console.Write(i);
            }
            
        }
    }

    public static void Ex4()
    {
        double[,] A = new double[,] { { 1m, 2m, 3m }, { 4m, 3m, 6m }, { 7m, 7m, 9m } };
        double[] x = new Double[]
        for (int i = 0; i < UPPER; i++)
        {
            x[i] = A[i + 1, i];
        }

        Array.Sort(x);
        for (int i = 0; i < 3; i++)
        {
            Console.Write(x[i])
        }
    }

    public static void Ex5()
    {
        double[,] A = new double[,] { { 1m, 2m, 3m }, { 4m, 3m, 6m }, { 7m, 7m, 9m } };
        
        int n = A.GetLength(0);
        
        // Находим начальную точку (центр)
        int rowCenter = n / 2;
        int colCenter = n / 2;

        // Направления движения: вправо, вниз, влево, вверх
        int[] dRow = { 0, 1, 0, -1 };
        int[] dCol = { 1, 0, -1, 0 };

        int dir = 0;          // Текущее направление (0: вправо, 1: вниз и т.д.)
        int stepLength = 1;   // Сколько шагов нужно сделать в текущем направлении
        int totalElements = n * n;
        int printedCount = 0;

        // Выводим центральный элемент
        Console.Write(A[rowCenter, colCenter] + " ");
        printedCount++;

        while (printedCount < totalElements)
        {
            // Делаем два прохода с одинаковой длиной шага (например: 1 вправо, 1 вниз, затем 2 влево, 2 вверх)
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < stepLength; j++)
                {
                    rowCenter += dRow[dir];
                    colCenter += dCol[dir];

                    // Проверяем, не вышли ли мы за границы массива (актуально для последнего витка)
                    if (rowCenter >= 0 && rowCenter < n && colCenter >= 0 && colCenter < n)
                    {
                        Console.Write(A[rowCenter, colCenter] + " ");
                        printedCount++;
                    }
                }
                
                // Меняем направление по часовой стрелке
                dir = (dir + 1) % 4; 
            }
            
            // После двух смен направлений увеличиваем длину шага
            stepLength++;
        }
    }


    public static void Ex6()
    {
        double[,] A = new double[,] { { 1m, 2m, 3m }, { 4m, 3m, 6m }, { 7m, 7m, 9m } };
        int k = 1;
        Console.Write(A.getLength(0) / k)
    }

    public static void Ex7()
    {
        double[,] A = new double[,] { { 1m, 2m, 3m }, { 4m, 3m, 6m }, { 7m, 7m, 9m } };
        int n = inputMatrix.GetLength(0);
        double[,] a = (double[,])inputMatrix.Clone();
        double det = 1.0;
        double eps = 1e-9;

        for (int i = 0; i < n; i++)
        {
            // Поиск главного элемента в столбце
            int pivot = i;
            for (int j = i + 1; j < n; j++)
            {
                if (Math.Abs(a[j, i]) > Math.Abs(a[pivot, i]))
                {
                    pivot = j;
                }
            }

            // Если главный элемент близок к нулю, определитель равен 0
            if (Math.Abs(a[pivot, i]) < eps)
            {
                return 0.0;
            }

            // Перестановка строк, если нужно
            if (pivot != i)
            {
                for (int k = 0; k < n; k++)
                {
                    double temp = a[i, k];
                    a[i, k] = a[pivot, k];
                    a[pivot, k] = temp;
                }
                det = -det; // Смена знака при перестановке строк
            }

            det *= a[i, i];

            // Обнуление элементов под главной диагональю
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
        int[,] A = new Int32[,];
        int[,] B = new Int32[,];
        
        int n = B.Length;
        
        // Создаем копии данных, чтобы не изменять оригинальные массивы
        double[,] a = (double[,])A.Clone();
        double[] b = (double[])B.Clone();
        double[] x = new double[n];

        // 1. ПРЯМОЙ ХОД (Приведение к верхнетреугольному виду)
        for (int k = 0; k < n; k++)
        {
            // Поиск максимального элемента в текущем столбце (выбор главного элемента для стабильности)
            int maxRow = k;
            for (int i = k + 1; i < n; i++)
            {
                if (Math.Abs(a[i, k]) > Math.Abs(a[maxRow, k]))
                {
                    maxRow = i;
                }
            }

            // Перестановка строк в матрице A и векторе B, если необходимо
            if (maxRow != k)
            {
                for (int j = k; j < n; j++)
                {
                    double tempA = a[k, j];
                    a[k, j] = a[maxRow, j];
                    a[maxRow, j] = tempA;
                }
                double tempB = b[k];
                b[k] = b[maxRow];
                b[maxRow] = tempB;
            }

            // Исключение неизвестных ниже текущей строки
            for (int i = k + 1; i < n; i++)
            {
                double factor = a[i, k] / a[k, k];
                
                // Корректируем свободный член i-й строки
                b[i] -= factor * b[k];
                
                // Корректируем коэффициенты i-й строки
                for (int j = k; j < n; j++)
                {
                    a[i, j] -= factor * a[k, j];
                }
            }
        }

        // 2. ОБРАТНЫЙ ХОД (Нахождение неизвестных)
        for (int i = n - 1; i >= 0; i--)
        {
            double sum = 0.0;
            for (int j = i + 1; j < n; j++)
            {
                sum += a[i, j] * x[j];
            }
            x[i] = (b[i] - sum) / a[i, i];
        }

        for (int i = 0; i < x; i++)
        {
           Console.Write(x[i]);
        }
    }
}