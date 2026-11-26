namespace Algorithmization.Practice;

public class Practice6
{
    public static void MainPractice6()
    {
        String[] names = new string[101];
        String magic = Console.ReadLine();
        
        
        String finallMagic = "";
        int count = 1;
        while (magic != "")
        {
            string[] magicArray = magic.Split(' ');
            
            for (int i = 1; i < magicArray.Length; i++)
            {
                if (int.TryParse(magicArray[i], out int number))
                {
                    magicArray[i] = names[number];
                }
            }
            
            finallMagic = String.Join("", magicArray.Skip(1));
            if (magicArray[0] == "MIX")
            {
                finallMagic = "MX" + finallMagic + "XM";
            }
            else if (magicArray[0] == "WATER")
            {
                 finallMagic = "WT" + finallMagic + "TW";
            }else if (magicArray[0] == "DUST")
            {
                 finallMagic = "DT" + finallMagic + "TD";
            }else if (magicArray[0] == "FIRE")
            {
                 finallMagic = "FR" + finallMagic + "RF";
            }
            
            names[count] = finallMagic;
            count++;
            
            magic = Console.ReadLine();
        }
        Console.WriteLine(finallMagic);

    }
}