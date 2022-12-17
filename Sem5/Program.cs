// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Размер массива вводим через консоль.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива");
int number = int.Parse(Console.ReadLine()!);

int minsize = 100;
int maxsize = 999;
int[] arr = FillArray(number, minsize, maxsize);

PrintArray(arr);
Console.WriteLine($" -> {EvenNumber(arr)}");

int[] FillArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int EvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.Размер массива, минимальное значение и максимальное значение
// вводим через консоль.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длину массива");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение");
int minsize = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение");
int maxsize = int.Parse(Console.ReadLine()!);

int[] arr = FillArray(number, minsize, maxsize);
PrintArray(arr);
Console.WriteLine($" -> {SumOddPos(arr)}");


int[] FillArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int SumOddPos(int[] array)
{
    int sum = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }
    return sum;
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
// элементов массива.Размер массива, минимальное значение и максимальное значение вводим через
// консоль. Для генерации вещественных чисeл, по аналогии с int, есть функция NextDouble().
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите длину массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение");
int minvalue = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение");
int maxvalue = int.Parse(Console.ReadLine()!);

double[] arr = FillArray(num, minvalue, maxvalue);
PrintArray(arr);
double maxrand = MaxFunc(arr);
double minrand = Minfunc(arr);
Console.WriteLine($" -> {Math.Round(DiffFunc(maxrand, minrand), 2)}");

double[] FillArray(int n, int min, int max)
{
    double[] array = new double[n];
    for (int i = 0; i < array.Length; i++)
    {

        array[i] = Math.Round(new Random().NextDouble() * (max - min) + min);  
    }
    return array;
}

void PrintArray(double[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");

    }
}

double MaxFunc(double[] array)
{
   double max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
    return max;
}

double Minfunc(double[] array)
{
    double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
    return min;
}

double DiffFunc(double max, double min)
{
    double diff = max - min;
    return diff;
}
