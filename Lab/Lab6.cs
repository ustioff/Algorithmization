namespace Lab;

public class Lab6
{
    public static void Ex16()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int l = Convert.ToInt32(Console.ReadLine());
        int c1 = Convert.ToInt32(Console.ReadLine());
        int c2 = Convert.ToInt32(Console.ReadLine());
        int c3 = Convert.ToInt32(Console.ReadLine());
        int c4 = Convert.ToInt32(Console.ReadLine());
        int c5 = Convert.ToInt32(Console.ReadLine());
        int c6 = Convert.ToInt32(Console.ReadLine());

        int P = 2 * (x + y);
        int maxS = Math.Max(x, y); 
        int minTotal = 1000000; 
        int maxK = Math.Min(l, maxS); 
        for (int k = 0; k <= maxK; k++) {

            int maxM = l - k; 
            for (int m = 0; m <= maxM; m++) { 
                if (k + m <= P) { 
                    int repair = k * c1; 
                    int demolish = (l - k) * c2;
                    int reuseBuild = m * c3;
                    int newBuild = (P - k - m) * (c4 + c5); 
                    int waste = (l - k - m) * c6; 
                    int total = repair + demolish + reuseBuild + newBuild + waste;
                    if (total < minTotal)
                    {
                        minTotal = total; 
                        
                    } 
                } 
            } 
        } 
        Console.WriteLine(minTotal);

    }
}