// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число");
int number = int.Parse(Console.ReadLine()!);
int secondDigit = number / 10;
int result = secondDigit % 10;
Console.WriteLine(result);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что 
// третьей цифры нет. Отрицательные числа должны нормально работать.
// -645 -> 5
// 645 -> 5
// 78 -> третьей цифры нет
// 3261279 -> 6

Console.Write("Введите число: ");
string number = Console.ReadLine()!;
if (number[0] == '-')
{
   if (number.Length >= 4)
    {
        Console.WriteLine("Третья цифрa:" + number[3]);
    }

}
else
{
    if (number.Length >= 3)
    {
        Console.WriteLine("Третья цифрa:" + number[2]);
    }

    else
    {
        Console.Write("Третьей цифры нет");
    }
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели...");
int day = int.Parse(Console.ReadLine());
if (day < 6 && day > 0)
{
    Console.WriteLine("Ответ: Рабочий день.");
}
else if (day == 7)
{
    Console.WriteLine("Ответ: Воскресенье. Выходной день.");
}
else if (day == 6)
{
    Console.WriteLine("Ответ: Суббота. Выходной день.");
}
else if (day > 7)
{
    Console.WriteLine("Ошибка: не является днем недели!");
}
else if (day <= 0)
{
    Console.WriteLine("Ошибка: не является днем недели!");
}
