namespace Algorithmization.Practice;

public class Practice4
{
    static void MainPractice4()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int z = 1;
        int count = 0;
        while ((Math.Pow(2, z) - 1) <= n)
        {
            count += (int)(n / (Math.Pow(2, z) - 1));
            z++;
        }
        Console.WriteLine(count);
    }
}