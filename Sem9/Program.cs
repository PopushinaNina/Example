// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine()!);
int m = 1;
Console.WriteLine(FromN1(m, n));

string FromN1(int m, int n)
{

    if (m == n)
    {
        return m.ToString();
    }
    else
    {
        return FromN1(m + 1, n) + ", " + m.ToString();
    }
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30 

Console.WriteLine("Введите M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine()!);

if (m < n) Console.WriteLine(SumElementsMinM(m, n));
else Console.WriteLine(SumElementsMaxM(n, m));

int SumElementsMinM(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    else
    {
        return n  + SumElementsMinM(m, n - 1);
    }
}

int SumElementsMaxM(int n, int m)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return m  + SumElementsMaxM(n, m - 1);
    }
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(Ackermann(m, n));

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

