namespace Algorithmization.Practice;

public class Practice7
{
    public static void MainPractice7()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        string[] delays = new string[n];
        for (int i = 0; i < n; i++)
        {
            delays[i] = Console.ReadLine();
        }
        
        double num = int.Parse(Console.ReadLine());
        double x = 0;
        
        for (int i = n -1; i >= 0; i--)
        {
            string[] delay = delays[i].Split(" ");
            if (delay[0] == "+")
            {
                if (delay[1] == "x")
                {
                    x -= 1;
                }
                else
                {
                    num -= int.Parse(delay[1]);
                }
            }
            else if (delay[0] == "-")
            {
                if (delay[1] == "x")
                {
                    x += 1;
                }
                else
                {
                    num += int.Parse(delay[1]);
                }
            }
            else if (delay[0] == "*")
            {
                num /= int.Parse(delay[1]);
                x /= int.Parse(delay[1]);
            }
            
        }

        double otvet = num / (1 - x);
        Console.WriteLine(otvet);
    }
}