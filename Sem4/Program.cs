// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

int digitFunction = Sumdigit(number);
Console.WriteLine(digitFunction);

int Sumdigit(int num)
{
    int sum = 0;
    while (num >= 10)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum + num;
}

// Задача 29: Напишите программу, которая принимает на вход числа n, min, max. Затем генерирует
// массив размером n и заполняет его случайными числами в диапазоне от min до max.
// 5, 1, 19 -> [1, 2, 5, 7, 19]
// 3, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите число n");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число min");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число max ");
int max = int.Parse(Console.ReadLine()!);

int[] array = new int[num];

FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("A= ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("B= ");
int numberB = int.Parse(Console.ReadLine()!);

int constFunction = Power(numberA, numberB);
Console.WriteLine(constFunction);

int Power(int numberA, int numberB)
{
    int constAinB = numberA;
    for (int i = 1; i < numberB; i++)
    {
        constAinB = constAinB * numberA;
    }
    return constAinB;
}
