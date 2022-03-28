//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.

int[] RandArray(int lenght)
{
int[] answer = new int[lenght];
for (int i = 0; i < lenght; i++)
{
answer[i] = new Random().Next(0, 10);
}
return answer;
}

void PrintArray(int[] Mas)
{
int count = Mas.Length;
for (int pos = 0; pos < count; pos++)
{
Console.Write(Mas[pos] + ", ");
}

}

int[] array = RandArray(11);
PrintArray(array);
Console.WriteLine();


int[] newarray = new int[array.Length/2];
for(int i=0; i<array.Length/2; i++)
{
    newarray[i] = array[i] * array[array.Length - i - 1];
}
   
PrintArray(newarray);
if(array.Length%2 != 0) Console.Write(array[array.Length/2]); 
//Последняя строчка на случай нечётного кол-ва элементов массива 
//- дописываем число в центре. В условии про то, что с таким делать - нет.
// Можно его игнорировать, можно умножить на самого себя, или написать как есть.
