// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число 
// большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3string input1 = Console.ReadLine()!;

string input1 = Console.ReadLine()!;
int parsedInput1 = int.Parse(input1);

string input2 = Console.ReadLine()!;
int parsedInput2 = int.Parse(input2);
if (parsedInput1 > parsedInput2)
{  
    Console.WriteLine("Первое число больше второго");
}
else 
{
    Console.WriteLine("Второе число больше первого");
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное 
// из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

string input1 = Console.ReadLine()!;
int parsedInput1 = int.Parse(input1);

string input2 = Console.ReadLine()!;
int parsedInput2 = int.Parse(input2);

string input3 = Console.ReadLine()!;
int parsedInput3 = int.Parse(input3);

int max = 0;

if (int.Parse(input1) > max)
{
    max = int.Parse(input1);
}
if (int.Parse(input2) > max)
{
    max = int.Parse(input2);
}
if (int.Parse(input3) > max)
{
    max = int.Parse(input3);
}

Console.WriteLine(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число 
// чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
string input1 = Console.ReadLine()!;
int parsedInput1 = int.Parse(input1);
if (parsedInput1 % 2 == 0) Console.WriteLine("Четное");
else Console.WriteLine("Нечетное");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
// все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8     

Console.WriteLine("Введите число ");
string input1 = Console.ReadLine()!;
int N = int.Parse(input1);
int i = 1;
while (i < N)
{
    if (i % 2 !=1)
    {
    Console.WriteLine(i);
    }  
     i++;  
}
