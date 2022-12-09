// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число ");
int number = int.Parse(Console.ReadLine()!);

if (number < 0)
{
    number = -number;
}

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Введено число не соответствуещее запросу");
}
else
{
    int firstdigit = number / 10000;
    int seconddigit = (number / 1000) % 10;
    int fourthdigit = (number / 10) % 10;
    int fifthdigit = number % 10;

    if (firstdigit == fifthdigit && seconddigit == fourthdigit)
    {
        Console.WriteLine("Число является палиндромом ");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом ");
    }
}

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите Х координату первой точки");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Y координату первой точки");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Z координату первой точки");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Х координату второй точки");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Y координату второй точки");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Z координату второй точки");
int z2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
// чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

for (int i = 1; i < number; i++)
{
    Console.Write(Math.Pow(i, 3) + " | ");
}
Console.WriteLine(Math.Pow(number, 3));
