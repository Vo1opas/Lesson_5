///Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int[] getArray(int n)
{

    int[] arr = new int[n];
    Random rnd = new Random();


    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(0, 99);
    }
    return arr;
}

int arraySize = 4;

int[] array = getArray(arraySize);

int sum = 0;

for (int i = 0; i < arraySize; i++)
{
    Console.Write(array[i] + " ");



    if (i % 2 != 0)
    {
        sum += array[i];
    }

}
Console.Write("-> {0}", sum);