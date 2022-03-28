// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] FillArray(int length)
{
    int[] arr = new int[length];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(99, 1000);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

void PrintPosRes(int[] arr)
{
    Console.Write("Положительные числа: ");
    int countPos = 0;
    int count = arr.Length;
    for(int i=0; i<count; i++)
    {
        if(arr[i]%2 == 0) 
        {
            countPos++;
            Console.Write($"{arr[i]}; ");
        }
    }
    Console.Write($"Всего = {countPos}");
}

int[] array = FillArray(10);
PrintArray(array);
PrintPosRes(array);