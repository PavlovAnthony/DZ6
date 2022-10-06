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


void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}


int b1 = CheckNumber(ReadData("b1 = : "));
int k1 = CheckNumber(ReadData("k1 = : "));
int b2 = CheckNumber(ReadData("b2 = : "));
int k2 = CheckNumber(ReadData("k2 = : "));

// y = k1 * x + b1, y = k2 * x + b2

try
{
    int x = (b1 - b2) / (k2 - k1);
    int y = k1 * x + b1;
    Console.WriteLine($"Координаты точек пересечения прямых: ({x}, {y})");

}
catch (DivideByZeroException)
{
    Console.WriteLine("Деление на 0, Прямые не пересекаются!");
}






