namespace Lab;

public class Lab8
{
    public static void MainLab8()
    {
        Ex1();

    }

    public static void Ex1()
    {
        String text = "test test";
        Console.WriteLine(text.Count(c => c == 't'));
    }

    public static void Ex2()
    {
        String text = "te(st te)st";
        Console.WriteLine(text.Split("(")[1].Split(")")[0]);
    }

    public static void Ex3()
    {
        String text = "testx testy splitx";
        foreach (String s in text.Split())
        {
            if (s.EndsWith("x"))
            {
                Console.WriteLine(s);
            }
        }
    }

    public static void Ex4()
    {
        String text = "testx testy splitx aprare";
        foreach (String s in text.Split())
        {
            if (s.EndsWith("y") || s.StartsWith("a"))
            {
                Console.WriteLine(s);
            }
        }
    }

    public static void Ex5()
    {
        String text = "nnn! nnnnnn! nn! n! nnn!";
        int max = 0;
        int count = 0;
        foreach (Char s in text)
        {
            
            if (s.Equals('n'))
            {
                count++;
            }
            else
            {
                max = Math.Max(max, count);
                count = 0;
            }
        }
        Console.WriteLine($"max {max}");
        text = text.Replace("!", ".");
        Console.WriteLine(text);
    }

    public static void Ex6()
    {
        String text = "test game test testy soap";
        String word = "test";
        Console.WriteLine(text.Split().Count(c => c == word));
    }

    public static void Ex7()
    {
        String text = "ABCghjklhtujРРЛДДЛЬИ";
        foreach (char i in text)
        {
            if ("qwertyuiopasdfghjklzxcvbnm".Contains(i))
            {
               Console.WriteLine(i); 
            }
        }
    }

    public static void Ex8()
    {
        String text = "aabbbabbbaqwer";
        Console.WriteLine($"a: {text.Count(c => c == 'a')}");
        Console.WriteLine($"b: {text.Count(c => c == 'b')}");
    }

    public static void Ex9()
    {
        String text = "aabbybabbbaqwer";
        Console.WriteLine(text.IndexOf("y") + 1);
    }

    public static void Ex10()
    {
        String text = "aabbbabbbaqwerQWERFFFGGafegjoesgrsgFJENKGNSEDNVKSNKD";
        foreach (char i in "abcdefghijklmnopqrstuvwxyz")
        {
            if (text.Contains(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void Ex11()
    {
        String text = "abcba";
        int flag = 1;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != text[text.Length - i - 1])
            {
                flag = 0;
                Console.WriteLine("no");
                break;
            }
        }

        if (flag == 1)
        {
            Console.WriteLine("yes");
        }
    }

    public static void Ex12()
    {
        String text = "test bool cbrod cbool";
        text  = text.Replace("cb", "c");
        Console.WriteLine(text);
    }

    public static void Ex13()
    {
        String text = "амрпсиаа";
        int count = 1;
        foreach (char i in text)
        {
            if ("аеёиоуыэюя".Contains(i))
            {
                Console.WriteLine(count);
            }
            count++;
        }
    }

    public static void Ex14()
    {
        String text = "amefwlwaaatyyr";
        String textOld = "";
        foreach (char i in text)
        {
            if (!textOld.Contains(i))
            {
                Console.Write(i);
                textOld += i;
            }
            else
            {
                Console.Write(" ");
            }
        }
    }

    public static void Ex15()
    {
        String text = "test replace name.";
        text = text.Substring(0, text.Length - 1);
        String[] words = text.Split();
        words = words.Where(w => w.Length % 2 == 0).ToArray();
        Console.WriteLine(words.Length);
    }

    public static void Ex16()
    {
        String text = "test replace name";
        String[] words = text.Split();
        String word = words[words.Length - 1];
        words[words.Length - 1] = words[0];
        words[0] = word;
        String newText = string.Join(" ", words);
        Console.WriteLine(newText);
    }

    public static void Ex17()
    {
        String text = "test,replace,name";
        text = text.Substring(0, text.Length - 1);
        String[] words = text.Split(",");
        words = words.Reverse().ToArray();
        String newText = string.Join(",", words);
        newText += ".";
        Console.WriteLine(newText);
    }

    public static void Ex18()
    {
        String text = "25673652";
        text = text.ToLower();
        int flag16 = 1;
        foreach (char i in "qwrtyuiopsghjklzxvnm")
        {
            if (text.Contains(i))
            {
                flag16 = 0;
                break;
            }
        }

        if (flag16 == 1)
        {
            int flag10 = 1;
            foreach (char i in "abcdef")
            {
                if (text.Contains(i))
                {
                    flag10 = 0;
                    break;
                }
            }
            if (flag10 == 1)
            {
                int flag2 = 1;
                foreach (char i in "98765432")
                {
                    if (text.Contains(i))
                    {
                        flag2 = 0;
                        break;
                    }
                }

                if (flag2 == 1)
                {
                    Console.WriteLine("2");
                }
                else
                {
                    Console.WriteLine("10");
                }
            }
            else
            {
                Console.WriteLine("16");
            }
        }
        else
        {
            Console.WriteLine("не подходит");
        }
    }

    public static void Ex19()
    {
        String text = "test replace name";
        String[] words = text.Split();
        foreach (string w in words)
        {
            int flag = 1;
            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] != w[w.Length - i - 1])
                {
                    flag = 0;
                    Console.WriteLine("no");
                    break;
                }
            }

            if (flag == 1)
            {
                Console.WriteLine("yes");
            }
        }
    }

    public static void Ex20()
    {
        String text = "Test Replace Name";
        int f = 3;
        String textNew = "";
        foreach (char s in text)
        {
            int index = s.GetHashCode();
            if ("qwertyuiopasdfghjklzxcvbnm".Contains(s.ToString().ToLower()))
            {
                index += f;
            }
            textNew += (char)index;
        }
        
        Console.WriteLine(textNew);
    }

    public static void Ex21()
    {
        String text = "test,replace,name,test,name.";
        text = text.Substring(0, text.Length - 1);
        String[] words = text.Split(",");
        words = words.Reverse().ToArray();
        for (int i = 1; i < words.Length - 1; i++)
        {
            if (words[i - 1] == words[i + 1])
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}

