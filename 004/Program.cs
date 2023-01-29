// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.Clear();
int[] array = new int[123];
int length = array.Length;
int sum1 = 0;
Console.WriteLine("Дан массив из 123 чисел");
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(1, 124);
    if(array[i] > 9 && array[i] < 100)
    {
        sum1 = sum1 + 1;
    }
}
Console.WriteLine("{0}", string.Join("; ", array));
Console.WriteLine("Количество элементов из отрезка [10,99] содержащихся в массиве = " + sum1);
