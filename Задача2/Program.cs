//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillArray(int length)
{
    int[] arr = new int[length];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
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

void PrintSumNeg(int[] arr)
{
    Console.Write("Отрицательные числа: ");
    int sum = 0;
    int count = arr.Length;
    for(int i=0; i<count; i++)
    {
        if(arr[i]%2 != 0) 
        {
            sum = sum + arr[i];
            Console.Write($"{arr[i]}; ");
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма отрицательных чисел = {sum}");
}

int[] array = FillArray(10);
PrintArray(array);
PrintSumNeg(array);