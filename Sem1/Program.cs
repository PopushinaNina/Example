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
