// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int[] FillArray(int length)
{
    int[] arr = new int[length];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

void MinMaxRezult(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    for(int i=0; i<arr.Length; i++)
    {
        if(arr[i] <= min) min = arr[i];
        if(arr[i] >= max) max = arr[i];
    }
    Console.Write($"min = {min}, max = {max} Разница: {max} - {min} = {max - min}");
}

int[] array = FillArray(10);
PrintArray(array);
MinMaxRezult(array);