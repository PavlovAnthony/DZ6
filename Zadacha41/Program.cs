string ReadData(string line)
{

    Console.Write(line);
    string a = Console.ReadLine();
    CheckString(a);
    return a;
}

void CheckString(string x)
{

    if (string.IsNullOrWhiteSpace(x))
    {
        PrintData("Ошибка ввода: ", "значение Null либо введены не числа");
        Environment.Exit(0);
    }

}
int CheckNumber(string x)
{
    int num = 0;

    bool isNum = int.TryParse(x, out num);
    if (isNum == false)
    {
        PrintData("Ошибка ввода: ", "значение Null либо введены не числа");
        Environment.Exit(0);
    }
    return num;
}
int[] ParseData(string s)
{
    char[] separators = { ',' };
    int a = 0;
    string[] split = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    int[] array1 = new int[split.Length];
    for (int i = 0; i <= split.Length - 1; i++)

    {
        a = CheckNumber(split[i]);
        array1[i] = a;
    }
    return array1;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

int NumMoreZero(int[] array)
{
    int count = 0;
    for (int i = 0; i <= array.Length - 1; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}
string array = ReadData("Введите ряд целых чисел через запятую : ");
int[] ar1 = ParseData(array);

PrintData("Количество чисел больше 0: ", Convert.ToString(NumMoreZero(ar1)));

