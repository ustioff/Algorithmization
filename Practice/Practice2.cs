using System;

class Practice2 {
    
    static void MainPractice2() {
        int N = Convert.ToInt32(Console.ReadLine());

        double minPrice = double.PositiveInfinity;
        int farm = 0;
        
        for (int i = 0; i < N; i++)
        {
            String[] S = Console.ReadLine().Split(' ');
            
            double x1 = Convert.ToDouble(S[0]);
            double y1 = Convert.ToDouble(S[1]);
            double z1 = Convert.ToDouble(S[2]);
            double x2 = Convert.ToDouble(S[3]);
            double y2 = Convert.ToDouble(S[4]);
            double z2 = Convert.ToDouble(S[5]);
            double c1 = Convert.ToDouble(S[6]);
            double c2 = Convert.ToDouble(S[7]);

            double V1 = x1 * y1 * z1;
            double V2 = x2 * y2 * z2;

            double S1 = 2 * (x1 * y1) + 2 * (x1 * z1) + 2 * (z1 * y1);
            double S2 = 2 * (x2 * y2) + 2 * (x2 * z2) + 2 * (z2 * y2);

            //отношение
            double ratio = S2 / S1;
            //цена за см в кубе
            double price = (c2 - c1 * ratio)/(V2 - V1 * ratio); 
                
            if (price < minPrice)
            {
                minPrice = price;
                farm = i + 1;
            }

        }
        //цена за литр
        double fullPrice = Math.Round(minPrice * 1000, 2);
        Console.WriteLine($"{farm} {fullPrice}");
    }
}
