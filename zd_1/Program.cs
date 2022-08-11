//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

//int[]

int[] getArray(int n)
{

    int[] arr = new int[n];
    Random rnd = new Random();


    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(100, 999);
    }
    return arr;
}


int arraySize = 4;
int[] array = getArray(arraySize);
int count = 0;
for (int i = 0; i < arraySize; i++)
{
    Console.Write(array[i] + " ");



    if (array[i] % 2 == 0)
    {
        count++;
    }
    
}
Console.Write(":Количество четных чисел-> " + count);









//int sum = getArray(arr) / 2;

//for (int j)

//System.Console.WriteLine(sum);