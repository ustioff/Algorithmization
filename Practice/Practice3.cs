class Practice3
{
    static void MainPractice3()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int nCopy = n;
        
        int c = 0;
        while (nCopy > 1)
        {
            nCopy /= 2;
            c++;
        }

        double min = Math.Pow(2, c);
        double max = Math.Pow(2, c + 1);
        min = n - min;
        max -= n;
        Console.WriteLine(Math.Min(min, max));
    }
}