// Определить, присутствует ли в заданном массиве, некоторое число
int[] array = new int[20];
int length = array.Length;
Console.WriteLine("Дан массив. Введите число для поиска совпадений в массиве");
int n = int.Parse(Console.ReadLine()!);
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(-9, 11);
    if(n == array[i])
    {
        Console.WriteLine("Найдено совпадение в элементе массива! " + i);
    }
}
Console.WriteLine("{0}", string.Join("; ", array));
