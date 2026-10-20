namespace Algorithmization.Practice;

public class Practice5
{
    static void MainPractice4()
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

        int ocnjva = Math.Max(x, y);
        int perimetr = (x + y) * 2;
        
        int perimetr_remont = Math.Min(ocnjva, l);
        int perimetr_bez_remont = Math.Min(0,perimetr-perimetr_remont);
        
        int remont = perimetr_remont * c1;
        int musor = l - perimetr_remont;
        int razbor_musor = musor * c2;
        
        int isp_musor = Math.Min(perimetr_bez_remont, musor);
        int ost_musor = musor - isp_musor;
        int remot_musor = isp_musor * c3;
        int ost_remont = Math.Min(0,perimetr_bez_remont - isp_musor) * c4 * c5;
        int vivoz = ost_musor * c6;
        Console.WriteLine(remont + razbor_musor + remot_musor + ost_remont + vivoz);
    }
}