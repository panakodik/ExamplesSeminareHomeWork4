// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.Clear();
int[] array = new int[20];
int length = array.Length;
int sum1 = 0;
int sum2 = 0;
Console.WriteLine("Дан массив c случайными положительными трёхзначными числами");
//int n = int.Parse(Console.ReadLine()!);
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(100, 1000);
    if(array[i] % 2 == 0)
    {
        sum1 = sum1 + 1;
    }
    else
    {
        sum2 = sum2 + 1;
    }
}
Console.WriteLine("{0}", string.Join("; ", array));
Console.WriteLine("Количество нечетных значений элементов массива = " + sum2);
Console.WriteLine("Количество четных значений элементов массива = " + sum1);