
// ----- Task #1
static string MatrixToString(char[,] array)
{
    string stroka = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            stroka += array[i, j];
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    return (stroka);
}

// ----- Task #2
static void StringToLowToUpp(string stroka)
{
    Console.Write(stroka.ToLower());
    Console.WriteLine();
    Console.WriteLine(stroka.ToUpper());
}

// ----- Task #3
static string IsPolindrom(string stroka)
{
    char[] chars = stroka.ToCharArray();
    string polindrom = "";
    int j = chars.Length - 1;
    for (int i = 0; i < chars.Length / 2; i++)
    {
        if (chars[i] == chars[j])
        {
            polindrom = "Да";
        }
        else
        {
            polindrom = "Нет";
            break;
        }
        j -= 1;
    }
    return polindrom;
}

//  ------ Task #4
static string ReversString(string stroka)
{
    string[] words = stroka.Split(' ');
    string[] new_words = new string[words.Length];
    for (int i = 0, j = words.Length - 1; i < words.Length; i++, j--)
    {
        new_words[i] = words[j];
    }
    string new_stroka = string.Join(" ", new_words);
    return new_stroka;
}

//  ------- Homework string
Console.Clear();
Console.WriteLine("--- Task #1 ---");
char[,] matrix_char = new char[,] {
    {'a', 'b', 'c', 'd'},
    {'e', 'f', 'g', 'h'},
    {'i', 'j', 'k', 'l'}
};
Console.WriteLine($"{MatrixToString(matrix_char)}");
Console.WriteLine();

Console.WriteLine("--- Task #2 ---");
string stroka2 = "asFyTbgJGDiuR!";
Console.WriteLine($"random string - '{stroka2}'");
StringToLowToUpp(stroka2);
Console.WriteLine();

Console.WriteLine("--- Task #3 ---");
string stroka3 = "qwerttrewq";
Console.WriteLine($"is string - '{stroka3}' polindrom?");
Console.WriteLine(IsPolindrom(stroka3));
Console.WriteLine();

Console.WriteLine("--- Task #4 ---");
string stroka4 = "Hello my world";
Console.WriteLine($"string - {stroka4}");
Console.WriteLine(ReversString(stroka4));
Console.WriteLine();
