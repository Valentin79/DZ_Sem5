// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] FillArray(int length)
{
    Random rand = new Random();
    double[] arr = new double[length];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.NextDouble()*100;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i].ToString("0.000")}, ");
    }
    Console.WriteLine();
}

void MinMaxRezult(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for(int i=0; i<arr.Length; i++)
    {
        if(arr[i] <= min) min = arr[i];
        if(arr[i] >= max) max = arr[i];
    }
    Console.Write($"min = {min.ToString("0.000")}, max = {max.ToString("0.000")} Разница: {max.ToString("0.000")} - {min.ToString("0.000")} = {(max - min).ToString("0.000")}");
}

double[] array = FillArray(10);
PrintArray(array);
MinMaxRezult(array);