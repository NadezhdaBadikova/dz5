void Zadacha0034()
{
    /* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

    Console.Clear();
    int size = 4;
    int[] numbers = new int[size];
    FillArray(numbers);
    FindCountEven(numbers);
}

void FillArray(int[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(100, 1000);
    }
     Console.WriteLine($"[{String.Join(",",numbers)}]");
}

void FindCountEven(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count++;
        }
    }

    Console.WriteLine($"Количество четных чисел: {count}");
}

void Zadacha0036()
{ /* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
        Найдите сумму элементов, стоящих на нечётных позициях.
    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0 */
    Console.Clear();
    int size = 4;
    int[] numbers = new int[size];
    FillArray2(numbers);
    FindSum(numbers);
}

void FillArray2(int[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(-10, 100);
    }
    Console.WriteLine($"[{String.Join(",",numbers)}]");
}

void FindSum(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += numbers[i];
        }
    }

    Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {sum}");
}

void Zadacha0038()
{ /* Задача 38: Задайте массив вещественных чисел. 
    Найдите  разницу между максимальным и минимальным элементов массива.
    [3 7 22 2 78] -> 76 */
    Console.Clear();
    int size = 7;
    int[] numbers = new int[size];
    FillArray2(numbers);
    FindDiff(numbers);

    void FindDiff(int[] numbers)
    {
        int max = numbers.Max();
        int min = numbers.Min();
        int diff = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            diff = numbers.Max() - numbers.Min();
        }

        Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {diff}");
    }
}

// Zadacha0034();
// Zadacha0036();
Zadacha0038();
