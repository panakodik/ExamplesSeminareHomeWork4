// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.Clear();
System.Console.WriteLine();

int size = new Random().Next(10, 20);
int min = 1;
int max = 200;
System.Console.WriteLine($"Количество элементов массива: {size}");

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}

int[] array = FillArray(size, min, max);
PrintArray(array);

void PrintProductPairs(int[] dataArray)
{
    int last = dataArray.Length - 1;
    for (int i = 0; i < dataArray.Length / 2; i++)
    {
        System.Console.WriteLine($"{dataArray[i]} x {dataArray[last]} = {dataArray[i] * dataArray[last]} ");
        last--;
    }
    if (dataArray.Length % 2 > 0) System.Console.WriteLine($"Число {dataArray[dataArray.Length / 2]} не имеет пары");
    System.Console.WriteLine();
}
System.Console.WriteLine();
System.Console.WriteLine("Второй вариант:");
PrintProductPairs(array);