//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

int[] getArray(int n)
{

    int[] arr = new int[n];
    Random rnd = new Random();


    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}

int arraySize = 4;

int[] array = getArray(arraySize);

int min = array[0];

int max = 0;


Console.Write(array[0] + " ");

for (int i = 1; i < arraySize; i++)
{
    Console.Write(array[i] + " ");
    if (array[i] < min)
    {
        min = array[i];
    }
    else if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine("\nМинимальный элемент: " + min);
Console.WriteLine("Максимальный элемент: " + max);
Console.WriteLine("Результат вычитания : " + (max - min));