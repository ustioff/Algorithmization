namespace Lab;

public class Lab9
{
    public static void MainLab5()
    {
        Ex1();
        Ex2();
        Ex3();
    }

    public static void Ex1()
    {
        string[] text = new[] { "3r3wr", "egiewgijwgijrwg", "fengiewgirm" };
        for (int i = 0; i < text.Length; i++)
        {
            text[i] = text[i].ToUpper();
        }
    }

    public static void Ex2()
    {
        string[] text = new[] { "3r3wr", "egiewgijwgijrwg", "fengiewgirm",  "3r3wr", "egiewgijwgijrwg", "fengiewgirm" };
        int minLen = text.Min(s => s.Length); 
        int maxLen = text.Max(s => s.Length); 
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Length == minLen)
            {
                Console.WriteLine($"min {i}:  {text[i]}");
                break;
            }
        }
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Length == maxLen)
            {
                Console.WriteLine($"max {i}:  {text[i]}");
                break;
            }
        }
    }

    public static void Ex3()
    {
        string[] text = new[] { "3r3wr","egeggrgeg","egiewgijwgijrwg", "fengiewgirm",  "3r3wr", "egiewgijwgijrwg", "fengiewgirm" };
        char c = 'e';
        string[] finall = Array.FindAll(text, t => t[0] == c);

        foreach(string s in finall)
        {
            Console.WriteLine(s);
        }
    }

    public static void Ex4()
    {
        string[] text = new[] { "3r3wr","egeggrgeg","egiewgijwgijrwg", "fengiewgirm",  "3r3wr", "EgiewGijwgijrwg", "fengiewgirm" };
        string c = "egiewgijwgijrwg";
        string[] finall = Array.FindAll(text, t => t.ToLower() == c.ToLower());
        foreach(string s in finall)
        {
            Console.WriteLine(s);
        }
    }

    public static void Ex5()
    {
        string[] text = new[] { "3r3wr","egeggrgeg","egiewgijwgijrwg", "fengiewgirm",  "3r3wr", "EgiewGijwgijrwg", "fengiewgirm" };
        string c = ";";
        string final = String.Join(c, text);
        Console.WriteLine(final);
    }

    public static void Ex6()
    {
        string[] text = new[] { "3r3wr","egeggrgeg","egiewgijwgijrwg", "fengiewgirm",  "3r3wr", "EgiewGijwgijrwg", "fengiewgirm" };
        string[] final = new String[text.Length];
        int c = 0;
        for (int i = 0; i < text.Length; i++)
        {

            if (final.Any(t => string.Equals(text[i], t, StringComparison.CurrentCultureIgnoreCase)))
            {
                continue;
            }
            
            final[c] = text[i];
            c++;
        }
        foreach(string s in final)
        {
            Console.WriteLine(s);
        }
        
    }

    public static void Ex7()
    {
        string[] text = new[] { "3r3wr","egeggrgeg","egiewgijwgijrwg", "fengiewgirm",  "3r3wr", "EgiewGijwgijrwg", "fengiewgirm" };
        string[] final = new String[text.Length];
        
        Array.Sort(text);
        for (int i = 0; i < text.Length; i++)
        {
            if (final.Any(t => string.Equals(text[i], t, StringComparison.CurrentCultureIgnoreCase)))
            {
                continue;
            }
            final[i] = text[i];
            Console.WriteLine($"{text[i]}: {text.Count(t => string.Equals(text[i], t, StringComparison.CurrentCultureIgnoreCase))}");
        }
    }

    public static void Ex8()
    {
        string[] text = new[] { "3r3wr","egeggrgeg","Egiewgijwgijrwg", "fengiewgirm",  "3r3wr", "egiewGijwgijrwg", "fengiewgirm" };
        string[] final = text.OrderBy(t => t.Length).ThenBy(t => t).ToArray();
        foreach(string s in final)
        {
            Console.WriteLine(s);
        }
    }

    public static void Ex9()
    {
        string[] text = new[] { "3r3wr","egeggrgeg","Egiewgijwgijrwg", "fengiewgirm",  "3r3wr", "egiewGijwgijrwg", "fengiewgirm" };
        string[] k = new[] { "3r3wr","fengiewgirm" };
        int l = 1;
        for (int i = 0; i < text.Length; i++)
        {
            if (k.All(t => text[0..i].Contains(t)))
            {
                Console.WriteLine(text[0..i].Length);
                l = 0;
                break;
            }
        }

        if (l == 1)
        {
            Console.WriteLine("-1");
        }
        
    }

    public static void Ex10()
    {
        int k = 1;
        string text = "квкккымывм";
        string fin = "";
        string alfphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";//работаю с русским алфавитом
 
        int m = alfphabet.Length; //количество знаков в алфавите
 
        for (int i = 0; i < text.Length; i++)//цикл перебора букв шифруемого слова
        {
            for (int j = 0; j < alfphabet.Length; j++)//цикл сравнения каждой бкувы с алфавитом
            {
                if (text[i] == alfphabet[j]) // в случае совпадения создаем темп, где храню номер буквы со сдвигом
                {
                    int temp = j + k;//номер буквы+сдвиг в темп
 
                    while (temp >= m)//чтобы темп не уходил за рамки алфавита
                        temp -= m;
 
                    fin = fin + alfphabet[temp];//заношу зашифрованную букву в переменную для ее хранения
                }
            }
 
        }
 
        Console.WriteLine("Зашифрованное слово:" + fin);
    }
    
    public static void Ex11()
    {
        string c = "efewgiewgirgiregir  gregregregr 2343";
        foreach (var s in c)
        {
            Console.WriteLine($"{s}: {c.Count(t => t == s)}");
            
        }
    }

    public static void Ex12()
    {
        string text = "(efef)))efg((";
        int openNeeded = 0;  // Сколько нужно добавить '('
        int closeNeeded = 0; // Сколько нужно добавить ')'

        foreach (char c in text)
        {
            if (c == '(')
            {
                closeNeeded++; // Каждая '(' требует одну ')'
            }
            else if (c == ')')
            {
                if (closeNeeded > 0)
                {
                    closeNeeded--; // Нашли пару для ранее открытой скобки
                }
                else
                {
                    openNeeded++; // Закрывающая скобка без пары — нужна '(' в начале
                }
            }
        }
        Console.WriteLine(openNeeded+closeNeeded);
    }

    public static void Ex13()
    {
        string[] fio = new[] { "Тест Аня Семенова", "Крут Олег Кирилович", "Кирик  Серег Николаев" };
        foreach (var s in fio)
        {
            Console.WriteLine(s);
        }
        
        Array.Sort(fio);

        string[] name = Array.FindAll(fio, s => s.Split()[1][0] == 'А');
        foreach (var c in name)
        {
            Console.WriteLine(c);
        }

        int l = 0;
        foreach (var c in fio)
        {
            l += c.Length;
        }
        
        Console.WriteLine(l);
    }

    public static void Ex14()
    {
        string[] words = { "кот", "ток", "дом", "окт", "лес", "мод" };

        int anagramWordsCount = words
            .Select(w => w.ToLower()) // приводим к одному регистру
            .GroupBy(w => String.Concat(w.OrderBy(c => c))) // группируем по отсортированным буквам
            .Where(g => g.Count() > 1) // оставляем только группы, где больше 1 слова
            .Sum(g => g.Count()); // суммируем количество слов в этих группах

        Console.WriteLine(anagramWordsCount);
    }

    public static void Ex15()
    {
        string text = "тест ваня аня пуп зуз лул зуз";
        String[] words = text.Split(' ');

        foreach (var s in words)
        {
            int l = 1;
            if (s != words[words.Length-1])
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != s[s.Length - 1- i])
                    {
                        l = 0;
                    }
                }
                if (l == 1)
                {
                    Console.WriteLine(s);
                }
            }

            
        }
    }

    public static void Ex16()
    {
        string text = "туст вуня ауя пуп зуз лул зуз";
        String[] words = text.Split(' ');
        
        int l = words.Min(w => w.Length);

        for (int i = 0; i < l; i++)
        {
            int f = 1;
            char k = words[0][i];
            foreach (string s in words)
            {
                if (s[i] != k)
                {
                    f = 0;
                }
            }

            if (f == 1)
            {
                Console.WriteLine(k);
            }
        }
    }

    public static void Ex17()
    {
        string text = "FFFYYYYYYYCCCCOOD";
        int c = 0;
        char old = text[0];
        string fin = "";
        foreach (var s in text)
        {
            if (s == old)
            {
                c++;
            }
            else
            {
                fin += old;
                fin += c;
                old = s;
                c = 1;
            }
        }
        fin += old;
        fin += c;
        
        Console.WriteLine(fin);
    }
}